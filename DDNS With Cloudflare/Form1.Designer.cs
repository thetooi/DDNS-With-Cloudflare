namespace DDNS_With_Cloudflare
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_CurrentIP = new System.Windows.Forms.TextBox();
            this.label_currentIP = new System.Windows.Forms.Label();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.groupLog = new System.Windows.Forms.GroupBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.CF_AuthKey_TXT = new System.Windows.Forms.TextBox();
            this.CF_DNS_ZONE_ID_TXT = new System.Windows.Forms.TextBox();
            this.CF_AuthEmail_TXT = new System.Windows.Forms.TextBox();
            this.CF_AuthKey = new System.Windows.Forms.Label();
            this.CF_DNS_ZONE_ID = new System.Windows.Forms.Label();
            this.CF_AuthEmail = new System.Windows.Forms.Label();
            this.CF_DOMIAN_TXT = new System.Windows.Forms.TextBox();
            this.CF_DOMIAN = new System.Windows.Forms.Label();
            this.txt_Last_update = new System.Windows.Forms.TextBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_reloadIP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Now_IP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_NOW_IP_reload = new System.Windows.Forms.Button();
            this.groupLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CurrentIP
            // 
            this.txt_CurrentIP.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txt_CurrentIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_CurrentIP.Location = new System.Drawing.Point(253, 32);
            this.txt_CurrentIP.MaxLength = 15;
            this.txt_CurrentIP.Name = "txt_CurrentIP";
            this.txt_CurrentIP.ReadOnly = true;
            this.txt_CurrentIP.Size = new System.Drawing.Size(197, 31);
            this.txt_CurrentIP.TabIndex = 4;
            this.txt_CurrentIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_currentIP
            // 
            this.label_currentIP.AutoSize = true;
            this.label_currentIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_currentIP.Location = new System.Drawing.Point(106, 35);
            this.label_currentIP.Name = "label_currentIP";
            this.label_currentIP.Size = new System.Drawing.Size(141, 25);
            this.label_currentIP.TabIndex = 2;
            this.label_currentIP.Text = "You IP Now:";
            // 
            // txt_Log
            // 
            this.txt_Log.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Log.Location = new System.Drawing.Point(6, 20);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Log.Size = new System.Drawing.Size(263, 397);
            this.txt_Log.TabIndex = 0;
            // 
            // groupLog
            // 
            this.groupLog.Controls.Add(this.txt_Log);
            this.groupLog.Location = new System.Drawing.Point(518, 12);
            this.groupLog.Name = "groupLog";
            this.groupLog.Size = new System.Drawing.Size(275, 423);
            this.groupLog.TabIndex = 3;
            this.groupLog.TabStop = false;
            this.groupLog.Text = "Log";
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button_Update.Location = new System.Drawing.Point(366, 260);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(128, 31);
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
            // 
            // CF_DNS_ZONE_ID_TXT
            // 
            this.CF_DNS_ZONE_ID_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_DNS_ZONE_ID_TXT.Location = new System.Drawing.Point(220, 146);
            this.CF_DNS_ZONE_ID_TXT.Name = "CF_DNS_ZONE_ID_TXT";
            this.CF_DNS_ZONE_ID_TXT.Size = new System.Drawing.Size(274, 26);
            this.CF_DNS_ZONE_ID_TXT.TabIndex = 5;
            // 
            // CF_AuthEmail_TXT
            // 
            this.CF_AuthEmail_TXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CF_AuthEmail_TXT.Location = new System.Drawing.Point(220, 82);
            this.CF_AuthEmail_TXT.Name = "CF_AuthEmail_TXT";
            this.CF_AuthEmail_TXT.Size = new System.Drawing.Size(274, 26);
            this.CF_AuthEmail_TXT.TabIndex = 5;
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
            // txt_Last_update
            // 
            this.txt_Last_update.Location = new System.Drawing.Point(220, 352);
            this.txt_Last_update.Name = "txt_Last_update";
            this.txt_Last_update.ReadOnly = true;
            this.txt_Last_update.Size = new System.Drawing.Size(274, 20);
            this.txt_Last_update.TabIndex = 8;
            // 
            // txt_Status
            // 
            this.txt_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_Status.Location = new System.Drawing.Point(220, 260);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(52, 24);
            this.txt_Status.TabIndex = 9;
            this.txt_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Last Update";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_reloadIP
            // 
            this.btn_reloadIP.Image = global::DDNS_With_Cloudflare.Properties.Resources.reload_icon;
            this.btn_reloadIP.Location = new System.Drawing.Point(456, 35);
            this.btn_reloadIP.Name = "btn_reloadIP";
            this.btn_reloadIP.Size = new System.Drawing.Size(38, 28);
            this.btn_reloadIP.TabIndex = 11;
            this.btn_reloadIP.UseVisualStyleBackColor = true;
            this.btn_reloadIP.Click += new System.EventHandler(this.btn_reloadIP_Click);
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
            // txt_Now_IP
            // 
            this.txt_Now_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_Now_IP.Location = new System.Drawing.Point(220, 178);
            this.txt_Now_IP.Name = "txt_Now_IP";
            this.txt_Now_IP.Size = new System.Drawing.Size(230, 26);
            this.txt_Now_IP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(111, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "CF_NOW_IP";
            // 
            // btn_NOW_IP_reload
            // 
            this.btn_NOW_IP_reload.Image = global::DDNS_With_Cloudflare.Properties.Resources.reload_icon;
            this.btn_NOW_IP_reload.Location = new System.Drawing.Point(456, 178);
            this.btn_NOW_IP_reload.Name = "btn_NOW_IP_reload";
            this.btn_NOW_IP_reload.Size = new System.Drawing.Size(38, 26);
            this.btn_NOW_IP_reload.TabIndex = 12;
            this.btn_NOW_IP_reload.UseVisualStyleBackColor = true;
            this.btn_NOW_IP_reload.Click += new System.EventHandler(this.btn_NOW_IP_reload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.btn_NOW_IP_reload);
            this.Controls.Add(this.btn_reloadIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.txt_Last_update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CF_DOMIAN);
            this.Controls.Add(this.CF_AuthEmail);
            this.Controls.Add(this.CF_DNS_ZONE_ID);
            this.Controls.Add(this.CF_AuthKey);
            this.Controls.Add(this.txt_Now_IP);
            this.Controls.Add(this.CF_DOMIAN_TXT);
            this.Controls.Add(this.CF_AuthEmail_TXT);
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
        private System.Windows.Forms.TextBox CF_AuthEmail_TXT;
        private System.Windows.Forms.Label CF_AuthKey;
        private System.Windows.Forms.Label CF_DNS_ZONE_ID;
        private System.Windows.Forms.Label CF_AuthEmail;
        private System.Windows.Forms.TextBox CF_DOMIAN_TXT;
        private System.Windows.Forms.Label CF_DOMIAN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Last_update;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_reloadIP;
        private System.Windows.Forms.TextBox txt_Now_IP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_NOW_IP_reload;
    }
}

