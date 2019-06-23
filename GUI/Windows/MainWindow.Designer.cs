using Email_Sender.GUI.UserPanels;

namespace Email_Sender.GUI.Windows
{
    partial class MainWindow
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.accountTemplatesBT = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.historyBT = new System.Windows.Forms.Button();
            this.messageTemplatesBT = new System.Windows.Forms.Button();
            this.emailTemplatesBT = new System.Windows.Forms.Button();
            this.senderBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sendersys = new Email_Sender.GUI.UserPanels.SenderUP();
            this.messageTemplate = new Email_Sender.GUI.UserPanels.MessageTemplateUP();
            this.history = new Email_Sender.GUI.UserPanels.HistoryUP();
            this.emailTemplate = new Email_Sender.GUI.UserPanels.EmailTemplateUP();
            this.configuration = new Email_Sender.GUI.UserPanels.ConfigurationUP();
            this.accountTemplates = new Email_Sender.GUI.UserPanels.AccountTemplatesUP();
            this.menuPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.accountTemplatesBT);
            this.menuPanel.Controls.Add(this.panel4);
            this.menuPanel.Controls.Add(this.panel3);
            this.menuPanel.Controls.Add(this.historyBT);
            this.menuPanel.Controls.Add(this.messageTemplatesBT);
            this.menuPanel.Controls.Add(this.emailTemplatesBT);
            this.menuPanel.Controls.Add(this.senderBT);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(175, 562);
            this.menuPanel.TabIndex = 0;
            // 
            // accountTemplatesBT
            // 
            this.accountTemplatesBT.BackColor = System.Drawing.Color.SeaGreen;
            this.accountTemplatesBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountTemplatesBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountTemplatesBT.Location = new System.Drawing.Point(-2, 135);
            this.accountTemplatesBT.Name = "accountTemplatesBT";
            this.accountTemplatesBT.Size = new System.Drawing.Size(175, 29);
            this.accountTemplatesBT.TabIndex = 11;
            this.accountTemplatesBT.Text = "Account Templates";
            this.accountTemplatesBT.UseVisualStyleBackColor = false;
            this.accountTemplatesBT.Click += new System.EventHandler(this.accountTemplatesBT_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 536);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 24);
            this.panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(35, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "System version: 0.00";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 25);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(63, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // historyBT
            // 
            this.historyBT.BackColor = System.Drawing.Color.SeaGreen;
            this.historyBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.historyBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.historyBT.Location = new System.Drawing.Point(-2, 170);
            this.historyBT.Name = "historyBT";
            this.historyBT.Size = new System.Drawing.Size(175, 29);
            this.historyBT.TabIndex = 5;
            this.historyBT.Text = "History";
            this.historyBT.UseVisualStyleBackColor = false;
            this.historyBT.Click += new System.EventHandler(this.historyBT_Click);
            // 
            // messageTemplatesBT
            // 
            this.messageTemplatesBT.BackColor = System.Drawing.Color.SeaGreen;
            this.messageTemplatesBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.messageTemplatesBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.messageTemplatesBT.Location = new System.Drawing.Point(-2, 100);
            this.messageTemplatesBT.Name = "messageTemplatesBT";
            this.messageTemplatesBT.Size = new System.Drawing.Size(175, 29);
            this.messageTemplatesBT.TabIndex = 3;
            this.messageTemplatesBT.Text = "Message Templates";
            this.messageTemplatesBT.UseVisualStyleBackColor = false;
            this.messageTemplatesBT.Click += new System.EventHandler(this.messageTemplatesBT_Click);
            // 
            // emailTemplatesBT
            // 
            this.emailTemplatesBT.BackColor = System.Drawing.Color.SeaGreen;
            this.emailTemplatesBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emailTemplatesBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailTemplatesBT.Location = new System.Drawing.Point(-2, 65);
            this.emailTemplatesBT.Name = "emailTemplatesBT";
            this.emailTemplatesBT.Size = new System.Drawing.Size(175, 29);
            this.emailTemplatesBT.TabIndex = 2;
            this.emailTemplatesBT.Text = "Email Templates";
            this.emailTemplatesBT.UseVisualStyleBackColor = false;
            this.emailTemplatesBT.Click += new System.EventHandler(this.emailTemplatesBT_Click);
            // 
            // senderBT
            // 
            this.senderBT.BackColor = System.Drawing.Color.SeaGreen;
            this.senderBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.senderBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.senderBT.Location = new System.Drawing.Point(-2, 30);
            this.senderBT.Name = "senderBT";
            this.senderBT.Size = new System.Drawing.Size(175, 29);
            this.senderBT.TabIndex = 1;
            this.senderBT.Text = "Sender";
            this.senderBT.UseVisualStyleBackColor = false;
            this.senderBT.Click += new System.EventHandler(this.senderBT_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sendersys);
            this.panel2.Controls.Add(this.messageTemplate);
            this.panel2.Controls.Add(this.history);
            this.panel2.Controls.Add(this.emailTemplate);
            this.panel2.Controls.Add(this.configuration);
            this.panel2.Controls.Add(this.accountTemplates);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 562);
            this.panel2.TabIndex = 1;
            // 
            // sendersys
            // 
            this.sendersys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendersys.Location = new System.Drawing.Point(0, 0);
            this.sendersys.Name = "sendersys";
            this.sendersys.Size = new System.Drawing.Size(709, 562);
            this.sendersys.TabIndex = 5;
            // 
            // messageTemplate
            // 
            this.messageTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messageTemplate.Location = new System.Drawing.Point(0, 0);
            this.messageTemplate.Name = "messageTemplate";
            this.messageTemplate.Size = new System.Drawing.Size(709, 562);
            this.messageTemplate.TabIndex = 3;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.history.Location = new System.Drawing.Point(0, -1);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(709, 562);
            this.history.TabIndex = 2;
            // 
            // emailTemplate
            // 
            this.emailTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTemplate.Location = new System.Drawing.Point(0, 0);
            this.emailTemplate.Name = "emailTemplate";
            this.emailTemplate.Size = new System.Drawing.Size(709, 562);
            this.emailTemplate.TabIndex = 1;
            // 
            // configuration
            // 
            this.configuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.configuration.Location = new System.Drawing.Point(0, 0);
            this.configuration.Name = "configuration";
            this.configuration.Size = new System.Drawing.Size(709, 562);
            this.configuration.TabIndex = 0;
            // 
            // accountTemplates
            // 
            this.accountTemplates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountTemplates.Location = new System.Drawing.Point(0, 0);
            this.accountTemplates.Name = "accountTemplates";
            this.accountTemplates.Size = new System.Drawing.Size(709, 562);
            this.accountTemplates.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Email Sender ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button emailTemplatesBT;
        private System.Windows.Forms.Button senderBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button messageTemplatesBT;
        private System.Windows.Forms.Button historyBT;        
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ConfigurationUP configuration;
        private SenderUP sendersys;
        private MessageTemplateUP messageTemplate;
        private HistoryUP history;
        private EmailTemplateUP emailTemplate;
        private System.Windows.Forms.Button accountTemplatesBT;
        private UserPanels.AccountTemplatesUP accountTemplates;
    }
}