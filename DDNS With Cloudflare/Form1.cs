﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace DDNS_With_Cloudflare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CF_ApiUrl = "https://api.cloudflare.com/client/v4/";

        public static string GetIPAddress()
        {
            WebClient webClient = new WebClient();
            return webClient.DownloadString("https://icanhazip.com/");
        }

        private string m_exePath = string.Empty;
        public void WriteLog(string logMessage)
        {
            LogWrite(logMessage);
            txt_Log.AppendText(Environment.NewLine);
            txt_Log.AppendText(logMessage);  
        }
        public void LogWrite(string logMessage)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception)
            {
            }
        }

        public static void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :");
                txtWriter.WriteLine("  :{0}", logMessage);
                txtWriter.WriteLine("-------------------------------");
            }
            catch (Exception)
            {

            }
        }

        public static string PutJsonDataToApi(string apiUrl, string authEmail, string authKey, string dnsZoneId, string dnsRecordId, string jsonData)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrl + "/zones/" + dnsZoneId + "/dns_records/" + dnsRecordId);
            httpWebRequest.ReadWriteTimeout = 100000;
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "*/*";
            httpWebRequest.Method = "PUT";
            httpWebRequest.Headers.Add("X-Auth-Email", authEmail.ToString());
            httpWebRequest.Headers.Add("X-Auth-Key", authKey.ToString());

            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                jsonData = jsonData.Replace("\n", "");
                jsonData = jsonData.Replace("\r", "");
                streamWriter.Write(jsonData);
                streamWriter.Flush();
                streamWriter.Close();
            }

            string res;
            try
            {
                HttpWebResponse resp = (HttpWebResponse)httpWebRequest.GetResponse();
                string respStr = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                dynamic Result = JsonConvert.DeserializeObject(respStr);
                string success = Result.success;
                string modified_on = Result.result.modified_on;
                res = success + "," + modified_on; // Output response to Console Window
                //res = success;
            }
            catch (Exception ex)
            {

                res = ex.ToString();
            }
            return res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_CurrentIP.Text = GetIPAddress();
            txt_Log.Text = "GetIPAddress..." + GetIPAddress();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string CF_AuthEmail = CF_AuthEmail_TXT.Text;
            string CF_AuthKey = CF_AuthKey_TXT.Text;
            string CF_DNS_ZONE_ID = CF_DNS_ZONE_ID_TXT.Text;
            //string CF_DNS_RECORD_ID = CF_DNS_RECORD_ID_TXT.Text;
            string CF_DOMIAN = CF_DOMIAN_TXT.Text;

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(CF_ApiUrl + "zones/" + CF_DNS_ZONE_ID + "/dns_records?type=A&name=" + CF_DOMIAN);
            httpWebRequest.ReadWriteTimeout = 100000;
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add("X-Auth-Email", CF_AuthEmail.ToString());
            httpWebRequest.Headers.Add("X-Auth-Key", CF_AuthKey.ToString());

            try
            {
                string srZoneResult;
                using (WebResponse response = httpWebRequest.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        srZoneResult = (streamReader.ReadToEnd());
                    }
                }
                dynamic zoneResult = JsonConvert.DeserializeObject(srZoneResult);
                string zoneId = zoneResult.result[0].id;
                //CF_DNS_RECORD_ID_TXT.Text = zoneId;
                //WriteLog("DNS_RECORD_ID....OK");
                string publicIpAddress = GetIPAddress(); // Get Public IP of my Home Server
                txt_CurrentIP.Text = GetIPAddress();

                // Build a JSON string to PUT to CloudFlare API
                Dictionary<string, string> jsonData = new Dictionary<string, string>
            {
                { "type", "A" },
                { "name", "" + CF_DOMIAN + "" },
                { "content", publicIpAddress.Trim() } // Trim Public IP Address Variable
            };
                string jsonPostData = JsonConvert.SerializeObject(jsonData);

                string data = PutJsonDataToApi(CF_ApiUrl, CF_AuthEmail, CF_AuthKey, CF_DNS_ZONE_ID, zoneId, jsonPostData);
                string[] arr = data.Split(',');
                if (arr[0] == "True")
                {
                    txt_Status.Text = "OK";
                    txt_Status.BackColor = Color.Green;
                    txt_Last_update.Text = arr[1];
                    WriteLog("[OK].." + publicIpAddress + "@" + arr[1]);
                }
                else
                {
                    txt_Status.Text = "NG";
                    txt_Status.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                txt_Status.Text = "NG";
                txt_Status.BackColor = Color.Red;
                WriteLog("[NG].." + ex.ToString());
            }
        }
    }
}