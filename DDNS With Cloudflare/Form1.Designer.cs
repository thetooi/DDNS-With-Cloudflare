﻿namespace DDNS_With_Cloudflare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_CurrentIP = new System.Windows.Forms.TextBox();
            this.label_currentIP = new System.Windows.Forms.Label();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.groupLog = new System.Windows.Forms.GroupBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.CF_AuthKey_TXT = new System.Windows.Forms.TextBox();
            this.CF_DNS_ZONE_ID_TXT = new System.Windows.Forms.TextBox();
            this.CF_DNS_RECORD_ID_TXT = new System.Windows.Forms.TextBox();
            this.CF_AuthEmail_TXT = new System.Windows.Forms.TextBox();
            this.CF_AuthKey = new System.Windows.Forms.Label();
            this.CF_DNS_ZONE_ID = new System.Windows.Forms.Label();
            this.CF_DNS_RECORD_ID = new System.Windows.Forms.Label();
            this.CF_AuthEmail = new System.Windows.Forms.Label();
            this.CF_DOMIAN_TXT = new System.Windows.Forms.TextBox();
            this.CF_DOMIAN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CurrentIP
            // 
            this.txt_CurrentIP.BackColor = System.Drawing.Color.Green;
            this.txt_CurrentIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_CurrentIP.Location = new System.Drawing.Point(297, 32);
            this.txt_CurrentIP.MaxLength = 15;
            this.txt_CurrentIP.Name = "txt_CurrentIP";
            this.txt_CurrentIP.ReadOnly = true;
            this.txt_CurrentIP.Size = new System.Drawing.Size(197, 31);
            this.txt_CurrentIP.TabIndex = 4;
            this.txt_CurrentIP.Text = "111.111.111.111";
            this.txt_CurrentIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_currentIP
            // 
            this.label_currentIP.AutoSize = true;
            this.label_currentIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_currentIP.Location = new System.Drawing.Point(199, 35);
            this.label_currentIP.Name = "label_currentIP";
            this.label_currentIP.Size = new System.Drawing.Size(92, 25);
            this.label_currentIP.TabIndex = 2;
            this.label_currentIP.Text = "IP Now:";
            // 
            // txt_Log
            // 
            this.txt_Log.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Log.Location = new System.Drawing.Point(6, 20);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Log.Size = new System.Drawing.Size(189, 397);
            this.txt_Log.TabIndex = 0;
            // 
            // groupLog
            // 
            this.groupLog.Controls.Add(this.txt_Log);
            this.groupLog.Location = new System.Drawing.Point(518, 12);
            this.groupLog.Name = "groupLog";
            this.groupLog.Size = new System.Drawing.Size(201, 423);
            this.groupLog.TabIndex = 3;
            this.groupLog.TabStop = false;
            this.groupLog.Text = "Log";
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button_Update.Location = new System.Drawing.Point(366, 255);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(128, 45);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "UPDATE DNS";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // CF_AuthKey_TXT
            // 
            this.CF_AuthKey_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_AuthKey_TXT.Location = new System.Drawing.Point(220, 114);
            this.CF_AuthKey_TXT.Name = "CF_AuthKey_TXT";
            this.CF_AuthKey_TXT.Size = new System.Drawing.Size(274, 26);
            this.CF_AuthKey_TXT.TabIndex = 5;
            this.CF_AuthKey_TXT.Text = "c02062aefc38219d38f1ae642b4b33021accd";
            // 
            // CF_DNS_ZONE_ID_TXT
            // 
            this.CF_DNS_ZONE_ID_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_DNS_ZONE_ID_TXT.Location = new System.Drawing.Point(220, 146);
            this.CF_DNS_ZONE_ID_TXT.Name = "CF_DNS_ZONE_ID_TXT";
            this.CF_DNS_ZONE_ID_TXT.Size = new System.Drawing.Size(274, 26);
            this.CF_DNS_ZONE_ID_TXT.TabIndex = 5;
            this.CF_DNS_ZONE_ID_TXT.Text = "5c3348bf45f617e0f69438a26240e0dd";
            // 
            // CF_DNS_RECORD_ID_TXT
            // 
            this.CF_DNS_RECORD_ID_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_DNS_RECORD_ID_TXT.Location = new System.Drawing.Point(220, 178);
            this.CF_DNS_RECORD_ID_TXT.Name = "CF_DNS_RECORD_ID_TXT";
            this.CF_DNS_RECORD_ID_TXT.Size = new System.Drawing.Size(274, 26);
            this.CF_DNS_RECORD_ID_TXT.TabIndex = 5;
            // 
            // CF_AuthEmail_TXT
            // 
            this.CF_AuthEmail_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_AuthEmail_TXT.Location = new System.Drawing.Point(220, 82);
            this.CF_AuthEmail_TXT.Name = "CF_AuthEmail_TXT";
            this.CF_AuthEmail_TXT.Size = new System.Drawing.Size(274, 26);
            this.CF_AuthEmail_TXT.TabIndex = 5;
            this.CF_AuthEmail_TXT.Text = "mythetooi@gmail.com";
            // 
            // CF_AuthKey
            // 
            this.CF_AuthKey.AutoSize = true;
            this.CF_AuthKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_AuthKey.Location = new System.Drawing.Point(115, 117);
            this.CF_AuthKey.Name = "CF_AuthKey";
            this.CF_AuthKey.Size = new System.Drawing.Size(99, 20);
            this.CF_AuthKey.TabIndex = 6;
            this.CF_AuthKey.Text = "CF_AuthKey";
            // 
            // CF_DNS_ZONE_ID
            // 
            this.CF_DNS_ZONE_ID.AutoSize = true;
            this.CF_DNS_ZONE_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_DNS_ZONE_ID.Location = new System.Drawing.Point(62, 149);
            this.CF_DNS_ZONE_ID.Name = "CF_DNS_ZONE_ID";
            this.CF_DNS_ZONE_ID.Size = new System.Drawing.Size(152, 20);
            this.CF_DNS_ZONE_ID.TabIndex = 6;
            this.CF_DNS_ZONE_ID.Text = "CF_DNS_ZONE_ID";
            // 
            // CF_DNS_RECORD_ID
            // 
            this.CF_DNS_RECORD_ID.AutoSize = true;
            this.CF_DNS_RECORD_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_DNS_RECORD_ID.Location = new System.Drawing.Point(36, 181);
            this.CF_DNS_RECORD_ID.Name = "CF_DNS_RECORD_ID";
            this.CF_DNS_RECORD_ID.Size = new System.Drawing.Size(178, 20);
            this.CF_DNS_RECORD_ID.TabIndex = 6;
            this.CF_DNS_RECORD_ID.Text = "CF_DNS_RECORD_ID";
            // 
            // CF_AuthEmail
            // 
            this.CF_AuthEmail.AutoSize = true;
            this.CF_AuthEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_AuthEmail.Location = new System.Drawing.Point(102, 85);
            this.CF_AuthEmail.Name = "CF_AuthEmail";
            this.CF_AuthEmail.Size = new System.Drawing.Size(112, 20);
            this.CF_AuthEmail.TabIndex = 6;
            this.CF_AuthEmail.Text = "CF_AuthEmail";
            // 
            // CF_DOMIAN_TXT
            // 
            this.CF_DOMIAN_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_DOMIAN_TXT.Location = new System.Drawing.Point(220, 210);
            this.CF_DOMIAN_TXT.Name = "CF_DOMIAN_TXT";
            this.CF_DOMIAN_TXT.Size = new System.Drawing.Size(274, 26);
            this.CF_DOMIAN_TXT.TabIndex = 5;
            this.CF_DOMIAN_TXT.Text = "mah-noii.info";
            // 
            // CF_DOMIAN
            // 
            this.CF_DOMIAN.AutoSize = true;
            this.CF_DOMIAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_DOMIAN.Location = new System.Drawing.Point(111, 213);
            this.CF_DOMIAN.Name = "CF_DOMIAN";
            this.CF_DOMIAN.Size = new System.Drawing.Size(103, 20);
            this.CF_DOMIAN.TabIndex = 6;
            this.CF_DOMIAN.Text = "CF_DOMIAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DDNS_With_Cloudflare.Properties.Resources.cf_logo_h_rgb;
            this.pictureBox1.Location = new System.Drawing.Point(1, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CF_DOMIAN);
            this.Controls.Add(this.CF_AuthEmail);
            this.Controls.Add(this.CF_DNS_RECORD_ID);
            this.Controls.Add(this.CF_DNS_ZONE_ID);
            this.Controls.Add(this.CF_AuthKey);
            this.Controls.Add(this.CF_DOMIAN_TXT);
            this.Controls.Add(this.CF_AuthEmail_TXT);
            this.Controls.Add(this.CF_DNS_RECORD_ID_TXT);
            this.Controls.Add(this.CF_DNS_ZONE_ID_TXT);
            this.Controls.Add(this.CF_AuthKey_TXT);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.groupLog);
            this.Controls.Add(this.label_currentIP);
            this.Controls.Add(this.txt_CurrentIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DDNS With Cloudflare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupLog.ResumeLayout(false);
            this.groupLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CurrentIP;
        private System.Windows.Forms.Label label_currentIP;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.GroupBox groupLog;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox CF_AuthKey_TXT;
        private System.Windows.Forms.TextBox CF_DNS_ZONE_ID_TXT;
        private System.Windows.Forms.TextBox CF_DNS_RECORD_ID_TXT;
        private System.Windows.Forms.TextBox CF_AuthEmail_TXT;
        private System.Windows.Forms.Label CF_AuthKey;
        private System.Windows.Forms.Label CF_DNS_ZONE_ID;
        private System.Windows.Forms.Label CF_DNS_RECORD_ID;
        private System.Windows.Forms.Label CF_AuthEmail;
        private System.Windows.Forms.TextBox CF_DOMIAN_TXT;
        private System.Windows.Forms.Label CF_DOMIAN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

