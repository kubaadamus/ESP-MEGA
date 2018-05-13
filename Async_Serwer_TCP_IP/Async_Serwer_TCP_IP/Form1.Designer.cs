namespace Async_Serwer_TCP_IP
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
            this.btnAcceptIncomingAsync = new System.Windows.Forms.Button();
            this.btnSenAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.LED_ON_BTN = new System.Windows.Forms.Button();
            this.LED_OFF_BTN = new System.Windows.Forms.Button();
            this.Serwo_0 = new System.Windows.Forms.Button();
            this.Serwo_20 = new System.Windows.Forms.Button();
            this.Serwo_40 = new System.Windows.Forms.Button();
            this.Serwo_60 = new System.Windows.Forms.Button();
            this.Serwo_80 = new System.Windows.Forms.Button();
            this.Serwo_100 = new System.Windows.Forms.Button();
            this.Serwo_120 = new System.Windows.Forms.Button();
            this.Serwo_140 = new System.Windows.Forms.Button();
            this.Serwo_160 = new System.Windows.Forms.Button();
            this.Serwo_180 = new System.Windows.Forms.Button();
            this.StatusCheckBox = new System.Windows.Forms.CheckBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.hScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // btnAcceptIncomingAsync
            // 
            this.btnAcceptIncomingAsync.Location = new System.Drawing.Point(12, 583);
            this.btnAcceptIncomingAsync.Name = "btnAcceptIncomingAsync";
            this.btnAcceptIncomingAsync.Size = new System.Drawing.Size(160, 23);
            this.btnAcceptIncomingAsync.TabIndex = 0;
            this.btnAcceptIncomingAsync.Text = "Accept Incoming Connection";
            this.btnAcceptIncomingAsync.UseVisualStyleBackColor = true;
            this.btnAcceptIncomingAsync.Click += new System.EventHandler(this.btnAcceptIncomingAsync_Click);
            // 
            // btnSenAll
            // 
            this.btnSenAll.Location = new System.Drawing.Point(178, 583);
            this.btnSenAll.Name = "btnSenAll";
            this.btnSenAll.Size = new System.Drawing.Size(75, 23);
            this.btnSenAll.TabIndex = 1;
            this.btnSenAll.Text = "&Send All";
            this.btnSenAll.UseVisualStyleBackColor = true;
            this.btnSenAll.Click += new System.EventHandler(this.btnSenAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message";
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(315, 585);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(384, 20);
            this.textMessage.TabIndex = 3;
            this.textMessage.Text = "Cyka Blyet";
            // 
            // btnStopServer
            // 
            this.btnStopServer.Location = new System.Drawing.Point(12, 554);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(160, 23);
            this.btnStopServer.TabIndex = 4;
            this.btnStopServer.Text = "Stop Server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(12, 25);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(801, 483);
            this.txtConsole.TabIndex = 5;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // LED_ON_BTN
            // 
            this.LED_ON_BTN.Location = new System.Drawing.Point(202, 554);
            this.LED_ON_BTN.Name = "LED_ON_BTN";
            this.LED_ON_BTN.Size = new System.Drawing.Size(75, 23);
            this.LED_ON_BTN.TabIndex = 6;
            this.LED_ON_BTN.Text = "LED_ON";
            this.LED_ON_BTN.UseVisualStyleBackColor = true;
            this.LED_ON_BTN.Click += new System.EventHandler(this.LED_ON_BTN_Click);
            // 
            // LED_OFF_BTN
            // 
            this.LED_OFF_BTN.Location = new System.Drawing.Point(283, 554);
            this.LED_OFF_BTN.Name = "LED_OFF_BTN";
            this.LED_OFF_BTN.Size = new System.Drawing.Size(75, 23);
            this.LED_OFF_BTN.TabIndex = 7;
            this.LED_OFF_BTN.Text = "LED_OFF";
            this.LED_OFF_BTN.UseVisualStyleBackColor = true;
            this.LED_OFF_BTN.Click += new System.EventHandler(this.LED_OFF_BTN_Click);
            // 
            // Serwo_0
            // 
            this.Serwo_0.Location = new System.Drawing.Point(12, 514);
            this.Serwo_0.Name = "Serwo_0";
            this.Serwo_0.Size = new System.Drawing.Size(75, 23);
            this.Serwo_0.TabIndex = 9;
            this.Serwo_0.Text = "0";
            this.Serwo_0.UseVisualStyleBackColor = true;
            this.Serwo_0.Click += new System.EventHandler(this.Serwo_0_Click);
            // 
            // Serwo_20
            // 
            this.Serwo_20.Location = new System.Drawing.Point(93, 514);
            this.Serwo_20.Name = "Serwo_20";
            this.Serwo_20.Size = new System.Drawing.Size(75, 23);
            this.Serwo_20.TabIndex = 10;
            this.Serwo_20.Text = "20";
            this.Serwo_20.UseVisualStyleBackColor = true;
            this.Serwo_20.Click += new System.EventHandler(this.Serwo_20_Click);
            // 
            // Serwo_40
            // 
            this.Serwo_40.Location = new System.Drawing.Point(174, 514);
            this.Serwo_40.Name = "Serwo_40";
            this.Serwo_40.Size = new System.Drawing.Size(75, 23);
            this.Serwo_40.TabIndex = 11;
            this.Serwo_40.Text = "40";
            this.Serwo_40.UseVisualStyleBackColor = true;
            this.Serwo_40.Click += new System.EventHandler(this.Serwo_40_Click);
            // 
            // Serwo_60
            // 
            this.Serwo_60.Location = new System.Drawing.Point(255, 514);
            this.Serwo_60.Name = "Serwo_60";
            this.Serwo_60.Size = new System.Drawing.Size(75, 23);
            this.Serwo_60.TabIndex = 12;
            this.Serwo_60.Text = "60";
            this.Serwo_60.UseVisualStyleBackColor = true;
            this.Serwo_60.Click += new System.EventHandler(this.Serwo_60_Click);
            // 
            // Serwo_80
            // 
            this.Serwo_80.Location = new System.Drawing.Point(336, 514);
            this.Serwo_80.Name = "Serwo_80";
            this.Serwo_80.Size = new System.Drawing.Size(75, 23);
            this.Serwo_80.TabIndex = 13;
            this.Serwo_80.Text = "80";
            this.Serwo_80.UseVisualStyleBackColor = true;
            this.Serwo_80.Click += new System.EventHandler(this.Serwo_80_Click);
            // 
            // Serwo_100
            // 
            this.Serwo_100.Location = new System.Drawing.Point(417, 514);
            this.Serwo_100.Name = "Serwo_100";
            this.Serwo_100.Size = new System.Drawing.Size(75, 23);
            this.Serwo_100.TabIndex = 14;
            this.Serwo_100.Text = "100";
            this.Serwo_100.UseVisualStyleBackColor = true;
            this.Serwo_100.Click += new System.EventHandler(this.Serwo_100_Click);
            // 
            // Serwo_120
            // 
            this.Serwo_120.Location = new System.Drawing.Point(498, 514);
            this.Serwo_120.Name = "Serwo_120";
            this.Serwo_120.Size = new System.Drawing.Size(75, 23);
            this.Serwo_120.TabIndex = 15;
            this.Serwo_120.Text = "120";
            this.Serwo_120.UseVisualStyleBackColor = true;
            this.Serwo_120.Click += new System.EventHandler(this.Serwo_120_Click);
            // 
            // Serwo_140
            // 
            this.Serwo_140.Location = new System.Drawing.Point(579, 514);
            this.Serwo_140.Name = "Serwo_140";
            this.Serwo_140.Size = new System.Drawing.Size(75, 23);
            this.Serwo_140.TabIndex = 16;
            this.Serwo_140.Text = "140";
            this.Serwo_140.UseVisualStyleBackColor = true;
            this.Serwo_140.Click += new System.EventHandler(this.Serwo_140_Click);
            // 
            // Serwo_160
            // 
            this.Serwo_160.Location = new System.Drawing.Point(661, 515);
            this.Serwo_160.Name = "Serwo_160";
            this.Serwo_160.Size = new System.Drawing.Size(75, 23);
            this.Serwo_160.TabIndex = 17;
            this.Serwo_160.Text = "160";
            this.Serwo_160.UseVisualStyleBackColor = true;
            this.Serwo_160.Click += new System.EventHandler(this.Serwo_160_Click);
            // 
            // Serwo_180
            // 
            this.Serwo_180.Location = new System.Drawing.Point(742, 515);
            this.Serwo_180.Name = "Serwo_180";
            this.Serwo_180.Size = new System.Drawing.Size(75, 23);
            this.Serwo_180.TabIndex = 18;
            this.Serwo_180.Text = "180";
            this.Serwo_180.UseVisualStyleBackColor = true;
            this.Serwo_180.Click += new System.EventHandler(this.Serwo_180_Click);
            // 
            // StatusCheckBox
            // 
            this.StatusCheckBox.AutoSize = true;
            this.StatusCheckBox.Location = new System.Drawing.Point(705, 583);
            this.StatusCheckBox.Name = "StatusCheckBox";
            this.StatusCheckBox.Size = new System.Drawing.Size(95, 17);
            this.StatusCheckBox.TabIndex = 19;
            this.StatusCheckBox.Text = "Pokazuj status";
            this.StatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 2;
            this.hScrollBar1.Location = new System.Drawing.Point(373, 554);
            this.hScrollBar1.Maximum = 10;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(338, 17);
            this.hScrollBar1.TabIndex = 20;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // hScrollBar2
            // 
            this.hScrollBar2.Location = new System.Drawing.Point(373, 627);
            this.hScrollBar2.Maximum = 2000;
            this.hScrollBar2.Minimum = 100;
            this.hScrollBar2.Name = "hScrollBar2";
            this.hScrollBar2.Size = new System.Drawing.Size(306, 17);
            this.hScrollBar2.TabIndex = 21;
            this.hScrollBar2.Value = 200;
            this.hScrollBar2.ValueChanged += new System.EventHandler(this.hScrollBar2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 656);
            this.Controls.Add(this.hScrollBar2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.StatusCheckBox);
            this.Controls.Add(this.Serwo_180);
            this.Controls.Add(this.Serwo_160);
            this.Controls.Add(this.Serwo_140);
            this.Controls.Add(this.Serwo_120);
            this.Controls.Add(this.Serwo_100);
            this.Controls.Add(this.Serwo_80);
            this.Controls.Add(this.Serwo_60);
            this.Controls.Add(this.Serwo_40);
            this.Controls.Add(this.Serwo_20);
            this.Controls.Add(this.Serwo_0);
            this.Controls.Add(this.LED_OFF_BTN);
            this.Controls.Add(this.LED_ON_BTN);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSenAll);
            this.Controls.Add(this.btnAcceptIncomingAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcceptIncomingAsync;
        private System.Windows.Forms.Button btnSenAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button LED_ON_BTN;
        private System.Windows.Forms.Button LED_OFF_BTN;
        private System.Windows.Forms.Button Serwo_0;
        private System.Windows.Forms.Button Serwo_20;
        private System.Windows.Forms.Button Serwo_40;
        private System.Windows.Forms.Button Serwo_60;
        private System.Windows.Forms.Button Serwo_80;
        private System.Windows.Forms.Button Serwo_100;
        private System.Windows.Forms.Button Serwo_120;
        private System.Windows.Forms.Button Serwo_140;
        private System.Windows.Forms.Button Serwo_160;
        private System.Windows.Forms.Button Serwo_180;
        private System.Windows.Forms.CheckBox StatusCheckBox;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar2;
    }
}

