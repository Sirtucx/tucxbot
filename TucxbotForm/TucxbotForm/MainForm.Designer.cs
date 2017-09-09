﻿namespace TucxbotForm
{
    partial class MainForm
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
            this.tcpBtnJoin = new System.Windows.Forms.Button();
            this.tcpBtnLeave = new System.Windows.Forms.Button();
            this.tcpTBoxJoin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcpRTBoxChat = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tcpRTBoxEvents = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tcpTBoxWhisper = new System.Windows.Forms.TextBox();
            this.tcpCBoxJoinedChannels = new System.Windows.Forms.ComboBox();
            this.tcpRBtnWhisper = new System.Windows.Forms.RadioButton();
            this.tcpRBtnChat = new System.Windows.Forms.RadioButton();
            this.tcpRTBoxChatOutput = new System.Windows.Forms.RichTextBox();
            this.tcpCBoxChannels = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.versionTab = new System.Windows.Forms.TabControl();
            this.tcpPage = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tcpBtnDisconnect = new System.Windows.Forms.Button();
            this.tcp_BtnConnect = new System.Windows.Forms.Button();
            this.websocketPage = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.webBtnJoin = new System.Windows.Forms.Button();
            this.webTBoxJoin = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.webBtnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.versionTab.SuspendLayout();
            this.tcpPage.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.websocketPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcpBtnJoin
            // 
            this.tcpBtnJoin.Enabled = false;
            this.tcpBtnJoin.Location = new System.Drawing.Point(7, 48);
            this.tcpBtnJoin.Name = "tcpBtnJoin";
            this.tcpBtnJoin.Size = new System.Drawing.Size(133, 23);
            this.tcpBtnJoin.TabIndex = 0;
            this.tcpBtnJoin.TabStop = false;
            this.tcpBtnJoin.Text = "Join";
            this.tcpBtnJoin.UseVisualStyleBackColor = true;
            this.tcpBtnJoin.Click += new System.EventHandler(this.TCP_BtnJoin_Click);
            // 
            // tcpBtnLeave
            // 
            this.tcpBtnLeave.Enabled = false;
            this.tcpBtnLeave.Location = new System.Drawing.Point(168, 48);
            this.tcpBtnLeave.Name = "tcpBtnLeave";
            this.tcpBtnLeave.Size = new System.Drawing.Size(133, 23);
            this.tcpBtnLeave.TabIndex = 1;
            this.tcpBtnLeave.TabStop = false;
            this.tcpBtnLeave.Text = "Leave";
            this.tcpBtnLeave.UseVisualStyleBackColor = true;
            this.tcpBtnLeave.Click += new System.EventHandler(this.TCP_BtnLeave_Click);
            // 
            // tcpTBoxJoin
            // 
            this.tcpTBoxJoin.Location = new System.Drawing.Point(7, 22);
            this.tcpTBoxJoin.Name = "tcpTBoxJoin";
            this.tcpTBoxJoin.Size = new System.Drawing.Size(133, 20);
            this.tcpTBoxJoin.TabIndex = 2;
            this.tcpTBoxJoin.Text = "Channel to join";
            this.tcpTBoxJoin.Enter += new System.EventHandler(this.TCP_TBoxJoin_Enter);
            this.tcpTBoxJoin.Leave += new System.EventHandler(this.TCP_TBoxJoin_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcpRTBoxChat);
            this.groupBox1.Location = new System.Drawing.Point(6, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 218);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // tcpRTBoxChat
            // 
            this.tcpRTBoxChat.Location = new System.Drawing.Point(7, 19);
            this.tcpRTBoxChat.Name = "tcpRTBoxChat";
            this.tcpRTBoxChat.ReadOnly = true;
            this.tcpRTBoxChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tcpRTBoxChat.Size = new System.Drawing.Size(288, 193);
            this.tcpRTBoxChat.TabIndex = 0;
            this.tcpRTBoxChat.TabStop = false;
            this.tcpRTBoxChat.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tcpRTBoxEvents);
            this.groupBox2.Location = new System.Drawing.Point(318, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 406);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Logs";
            // 
            // tcpRTBoxEvents
            // 
            this.tcpRTBoxEvents.Location = new System.Drawing.Point(6, 19);
            this.tcpRTBoxEvents.Name = "tcpRTBoxEvents";
            this.tcpRTBoxEvents.ReadOnly = true;
            this.tcpRTBoxEvents.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tcpRTBoxEvents.Size = new System.Drawing.Size(184, 381);
            this.tcpRTBoxEvents.TabIndex = 0;
            this.tcpRTBoxEvents.TabStop = false;
            this.tcpRTBoxEvents.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tcpTBoxWhisper);
            this.groupBox3.Controls.Add(this.tcpCBoxJoinedChannels);
            this.groupBox3.Controls.Add(this.tcpRBtnWhisper);
            this.groupBox3.Controls.Add(this.tcpRBtnChat);
            this.groupBox3.Controls.Add(this.tcpRTBoxChatOutput);
            this.groupBox3.Location = new System.Drawing.Point(6, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 94);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chat Input";
            // 
            // tcpTBoxWhisper
            // 
            this.tcpTBoxWhisper.Location = new System.Drawing.Point(168, 16);
            this.tcpTBoxWhisper.Name = "tcpTBoxWhisper";
            this.tcpTBoxWhisper.Size = new System.Drawing.Size(133, 20);
            this.tcpTBoxWhisper.TabIndex = 4;
            this.tcpTBoxWhisper.Text = "Username to whisper";
            this.tcpTBoxWhisper.Visible = false;
            this.tcpTBoxWhisper.Enter += new System.EventHandler(this.TCP_TBoxWhisper_Enter);
            this.tcpTBoxWhisper.Leave += new System.EventHandler(this.TCP_TBoxWhisper_Leave);
            // 
            // tcpCBoxJoinedChannels
            // 
            this.tcpCBoxJoinedChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tcpCBoxJoinedChannels.Enabled = false;
            this.tcpCBoxJoinedChannels.FormattingEnabled = true;
            this.tcpCBoxJoinedChannels.Location = new System.Drawing.Point(168, 15);
            this.tcpCBoxJoinedChannels.Name = "tcpCBoxJoinedChannels";
            this.tcpCBoxJoinedChannels.Size = new System.Drawing.Size(133, 21);
            this.tcpCBoxJoinedChannels.TabIndex = 5;
            // 
            // tcpRBtnWhisper
            // 
            this.tcpRBtnWhisper.AutoSize = true;
            this.tcpRBtnWhisper.Location = new System.Drawing.Point(60, 19);
            this.tcpRBtnWhisper.Name = "tcpRBtnWhisper";
            this.tcpRBtnWhisper.Size = new System.Drawing.Size(64, 17);
            this.tcpRBtnWhisper.TabIndex = 2;
            this.tcpRBtnWhisper.Text = "Whisper";
            this.tcpRBtnWhisper.UseVisualStyleBackColor = true;
            this.tcpRBtnWhisper.CheckedChanged += new System.EventHandler(this.TCP_RBtnWhisper_CheckedChanged);
            // 
            // tcpRBtnChat
            // 
            this.tcpRBtnChat.AutoSize = true;
            this.tcpRBtnChat.Checked = true;
            this.tcpRBtnChat.Location = new System.Drawing.Point(7, 20);
            this.tcpRBtnChat.Name = "tcpRBtnChat";
            this.tcpRBtnChat.Size = new System.Drawing.Size(47, 17);
            this.tcpRBtnChat.TabIndex = 1;
            this.tcpRBtnChat.TabStop = true;
            this.tcpRBtnChat.Text = "Chat";
            this.tcpRBtnChat.UseVisualStyleBackColor = true;
            this.tcpRBtnChat.CheckedChanged += new System.EventHandler(this.TCP_RBtnChat_CheckedChanged);
            // 
            // tcpRTBoxChatOutput
            // 
            this.tcpRTBoxChatOutput.Location = new System.Drawing.Point(7, 42);
            this.tcpRTBoxChatOutput.Name = "tcpRTBoxChatOutput";
            this.tcpRTBoxChatOutput.Size = new System.Drawing.Size(288, 46);
            this.tcpRTBoxChatOutput.TabIndex = 0;
            this.tcpRTBoxChatOutput.TabStop = false;
            this.tcpRTBoxChatOutput.Text = "";
            this.tcpRTBoxChatOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCP_RTBoxChatOutput_KeyPress);
            this.tcpRTBoxChatOutput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TCP_RTBoxChatOutput_KeyUp);
            // 
            // tcpCBoxChannels
            // 
            this.tcpCBoxChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tcpCBoxChannels.Enabled = false;
            this.tcpCBoxChannels.FormattingEnabled = true;
            this.tcpCBoxChannels.Location = new System.Drawing.Point(168, 21);
            this.tcpCBoxChannels.Name = "tcpCBoxChannels";
            this.tcpCBoxChannels.Size = new System.Drawing.Size(133, 21);
            this.tcpCBoxChannels.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tcpTBoxJoin);
            this.groupBox4.Controls.Add(this.tcpCBoxChannels);
            this.groupBox4.Controls.Add(this.tcpBtnJoin);
            this.groupBox4.Controls.Add(this.tcpBtnLeave);
            this.groupBox4.Location = new System.Drawing.Point(6, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 84);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Join/Leave";
            // 
            // versionTab
            // 
            this.versionTab.Controls.Add(this.tcpPage);
            this.versionTab.Controls.Add(this.websocketPage);
            this.versionTab.Location = new System.Drawing.Point(7, 13);
            this.versionTab.Name = "versionTab";
            this.versionTab.SelectedIndex = 0;
            this.versionTab.Size = new System.Drawing.Size(531, 504);
            this.versionTab.TabIndex = 8;
            // 
            // tcpPage
            // 
            this.tcpPage.Controls.Add(this.groupBox5);
            this.tcpPage.Controls.Add(this.groupBox3);
            this.tcpPage.Controls.Add(this.groupBox1);
            this.tcpPage.Controls.Add(this.groupBox4);
            this.tcpPage.Controls.Add(this.groupBox2);
            this.tcpPage.Location = new System.Drawing.Point(4, 22);
            this.tcpPage.Name = "tcpPage";
            this.tcpPage.Padding = new System.Windows.Forms.Padding(3);
            this.tcpPage.Size = new System.Drawing.Size(523, 478);
            this.tcpPage.TabIndex = 0;
            this.tcpPage.Text = "TCPSocket";
            this.tcpPage.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tcpBtnDisconnect);
            this.groupBox5.Controls.Add(this.tcp_BtnConnect);
            this.groupBox5.Location = new System.Drawing.Point(6, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 52);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Connect/Disconnect";
            // 
            // tcpBtnDisconnect
            // 
            this.tcpBtnDisconnect.Enabled = false;
            this.tcpBtnDisconnect.Location = new System.Drawing.Point(260, 20);
            this.tcpBtnDisconnect.Name = "tcpBtnDisconnect";
            this.tcpBtnDisconnect.Size = new System.Drawing.Size(245, 23);
            this.tcpBtnDisconnect.TabIndex = 1;
            this.tcpBtnDisconnect.Text = "Disconnect";
            this.tcpBtnDisconnect.UseVisualStyleBackColor = true;
            this.tcpBtnDisconnect.Visible = false;
            this.tcpBtnDisconnect.Click += new System.EventHandler(this.TCP_BtnDisconnect_Click);
            // 
            // tcp_BtnConnect
            // 
            this.tcp_BtnConnect.Location = new System.Drawing.Point(7, 20);
            this.tcp_BtnConnect.Name = "tcp_BtnConnect";
            this.tcp_BtnConnect.Size = new System.Drawing.Size(245, 23);
            this.tcp_BtnConnect.TabIndex = 0;
            this.tcp_BtnConnect.Text = "Connect";
            this.tcp_BtnConnect.UseVisualStyleBackColor = true;
            this.tcp_BtnConnect.Click += new System.EventHandler(this.TCP_BtnConnect_Click);
            // 
            // websocketPage
            // 
            this.websocketPage.Controls.Add(this.groupBox7);
            this.websocketPage.Controls.Add(this.groupBox6);
            this.websocketPage.Location = new System.Drawing.Point(4, 22);
            this.websocketPage.Name = "websocketPage";
            this.websocketPage.Padding = new System.Windows.Forms.Padding(3);
            this.websocketPage.Size = new System.Drawing.Size(523, 478);
            this.websocketPage.TabIndex = 1;
            this.websocketPage.Text = "WebSocket";
            this.websocketPage.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.webBtnJoin);
            this.groupBox7.Controls.Add(this.webTBoxJoin);
            this.groupBox7.Location = new System.Drawing.Point(7, 63);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(149, 80);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Join";
            // 
            // webBtnJoin
            // 
            this.webBtnJoin.Enabled = false;
            this.webBtnJoin.Location = new System.Drawing.Point(6, 45);
            this.webBtnJoin.Name = "webBtnJoin";
            this.webBtnJoin.Size = new System.Drawing.Size(133, 23);
            this.webBtnJoin.TabIndex = 3;
            this.webBtnJoin.TabStop = false;
            this.webBtnJoin.Text = "Join";
            this.webBtnJoin.UseVisualStyleBackColor = true;
            this.webBtnJoin.Click += new System.EventHandler(this.Web_BtnJoin_Click);
            // 
            // webTBoxJoin
            // 
            this.webTBoxJoin.Location = new System.Drawing.Point(6, 19);
            this.webTBoxJoin.Name = "webTBoxJoin";
            this.webTBoxJoin.Size = new System.Drawing.Size(133, 20);
            this.webTBoxJoin.TabIndex = 4;
            this.webTBoxJoin.Text = "Channel to join";
            this.webTBoxJoin.Enter += new System.EventHandler(this.Web_TBoxJoin_Enter);
            this.webTBoxJoin.Leave += new System.EventHandler(this.Web_TBoxJoin_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.webBtnConnect);
            this.groupBox6.Location = new System.Drawing.Point(7, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(149, 50);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Connect";
            // 
            // webBtnConnect
            // 
            this.webBtnConnect.Location = new System.Drawing.Point(6, 19);
            this.webBtnConnect.Name = "webBtnConnect";
            this.webBtnConnect.Size = new System.Drawing.Size(133, 23);
            this.webBtnConnect.TabIndex = 0;
            this.webBtnConnect.Text = "Connect";
            this.webBtnConnect.UseVisualStyleBackColor = true;
            this.webBtnConnect.Click += new System.EventHandler(this.Web_BtnConnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 522);
            this.Controls.Add(this.versionTab);
            this.Name = "MainForm";
            this.Text = "Tucxbot Open Source";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.versionTab.ResumeLayout(false);
            this.tcpPage.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.websocketPage.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tcpBtnJoin;
        private System.Windows.Forms.Button tcpBtnLeave;
        private System.Windows.Forms.TextBox tcpTBoxJoin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tcpRTBoxChat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox tcpRTBoxEvents;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton tcpRBtnWhisper;
        private System.Windows.Forms.RadioButton tcpRBtnChat;
        private System.Windows.Forms.RichTextBox tcpRTBoxChatOutput;
        private System.Windows.Forms.TextBox tcpTBoxWhisper;
        private System.Windows.Forms.ComboBox tcpCBoxChannels;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox tcpCBoxJoinedChannels;
        private System.Windows.Forms.TabControl versionTab;
        private System.Windows.Forms.TabPage tcpPage;
        private System.Windows.Forms.TabPage websocketPage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button tcpBtnDisconnect;
        private System.Windows.Forms.Button tcp_BtnConnect;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button webBtnConnect;
        private System.Windows.Forms.Button webBtnJoin;
        private System.Windows.Forms.TextBox webTBoxJoin;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

