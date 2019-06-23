namespace Email_Sender.GUI.UserPanels
{
    partial class SenderUP
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accountCB = new System.Windows.Forms.ComboBox();
            this.messageCB = new System.Windows.Forms.ComboBox();
            this.emailsCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearSourceBT = new System.Windows.Forms.Button();
            this.refreshBT = new System.Windows.Forms.Button();
            this.toConfigBT = new System.Windows.Forms.Button();
            this.sendBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearConfigBT = new System.Windows.Forms.Button();
            this.emailsRTB = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textRTB = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.infoLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 25);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(576, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sender GUI, version: 0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Account";
            // 
            // accountCB
            // 
            this.accountCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.accountCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountCB.FormattingEnabled = true;
            this.accountCB.Items.AddRange(new object[] {
            "none"});
            this.accountCB.Location = new System.Drawing.Point(11, 46);
            this.accountCB.Name = "accountCB";
            this.accountCB.Size = new System.Drawing.Size(294, 32);
            this.accountCB.TabIndex = 28;
            this.accountCB.Text = "none";
            // 
            // messageCB
            // 
            this.messageCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messageCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.messageCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.messageCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.messageCB.FormattingEnabled = true;
            this.messageCB.Items.AddRange(new object[] {
            "none"});
            this.messageCB.Location = new System.Drawing.Point(11, 109);
            this.messageCB.Name = "messageCB";
            this.messageCB.Size = new System.Drawing.Size(294, 32);
            this.messageCB.TabIndex = 29;
            this.messageCB.Text = "none";
            // 
            // emailsCB
            // 
            this.emailsCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailsCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emailsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.emailsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailsCB.FormattingEnabled = true;
            this.emailsCB.Items.AddRange(new object[] {
            "none"});
            this.emailsCB.Location = new System.Drawing.Point(11, 172);
            this.emailsCB.Name = "emailsCB";
            this.emailsCB.Size = new System.Drawing.Size(294, 32);
            this.emailsCB.TabIndex = 30;
            this.emailsCB.Text = "none";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Emails";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearSourceBT);
            this.groupBox2.Controls.Add(this.refreshBT);
            this.groupBox2.Controls.Add(this.toConfigBT);
            this.groupBox2.Controls.Add(this.accountCB);
            this.groupBox2.Controls.Add(this.emailsCB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.messageCB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 459);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data source";
            // 
            // clearSourceBT
            // 
            this.clearSourceBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearSourceBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearSourceBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearSourceBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearSourceBT.Location = new System.Drawing.Point(11, 282);
            this.clearSourceBT.Name = "clearSourceBT";
            this.clearSourceBT.Size = new System.Drawing.Size(294, 30);
            this.clearSourceBT.TabIndex = 35;
            this.clearSourceBT.Text = "Clear";
            this.clearSourceBT.UseVisualStyleBackColor = false;
            this.clearSourceBT.Click += new System.EventHandler(this.clearSourceBT_Click);
            // 
            // refreshBT
            // 
            this.refreshBT.BackColor = System.Drawing.Color.SeaGreen;
            this.refreshBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refreshBT.Location = new System.Drawing.Point(11, 246);
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(294, 30);
            this.refreshBT.TabIndex = 34;
            this.refreshBT.Text = "Refresh data sources";
            this.refreshBT.UseVisualStyleBackColor = false;
            this.refreshBT.Click += new System.EventHandler(this.refreshBT_Click);
            // 
            // toConfigBT
            // 
            this.toConfigBT.BackColor = System.Drawing.Color.SeaGreen;
            this.toConfigBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.toConfigBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toConfigBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toConfigBT.Location = new System.Drawing.Point(11, 210);
            this.toConfigBT.Name = "toConfigBT";
            this.toConfigBT.Size = new System.Drawing.Size(294, 30);
            this.toConfigBT.TabIndex = 33;
            this.toConfigBT.Text = "Get data to config";
            this.toConfigBT.UseVisualStyleBackColor = false;
            this.toConfigBT.Click += new System.EventHandler(this.toConfigBT_Click);
            // 
            // sendBT
            // 
            this.sendBT.BackColor = System.Drawing.Color.SeaGreen;
            this.sendBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sendBT.Location = new System.Drawing.Point(384, 489);
            this.sendBT.Name = "sendBT";
            this.sendBT.Size = new System.Drawing.Size(298, 30);
            this.sendBT.TabIndex = 36;
            this.sendBT.Text = "Send";
            this.sendBT.UseVisualStyleBackColor = false;
            this.sendBT.Click += new System.EventHandler(this.sendBT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearConfigBT);
            this.groupBox1.Controls.Add(this.emailsRTB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textRTB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.titleTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.loginTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(373, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 459);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message config";
            // 
            // clearConfigBT
            // 
            this.clearConfigBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearConfigBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearConfigBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearConfigBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearConfigBT.Location = new System.Drawing.Point(62, 420);
            this.clearConfigBT.Name = "clearConfigBT";
            this.clearConfigBT.Size = new System.Drawing.Size(208, 30);
            this.clearConfigBT.TabIndex = 37;
            this.clearConfigBT.Text = "Clear";
            this.clearConfigBT.UseVisualStyleBackColor = false;
            this.clearConfigBT.Click += new System.EventHandler(this.clearConfigBT_Click);
            // 
            // emailsRTB
            // 
            this.emailsRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailsRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailsRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailsRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailsRTB.Location = new System.Drawing.Point(11, 307);
            this.emailsRTB.Name = "emailsRTB";
            this.emailsRTB.Size = new System.Drawing.Size(298, 107);
            this.emailsRTB.TabIndex = 44;
            this.emailsRTB.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(7, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 43;
            this.label9.Text = "Emails";
            // 
            // textRTB
            // 
            this.textRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textRTB.Location = new System.Drawing.Point(11, 169);
            this.textRTB.Name = "textRTB";
            this.textRTB.Size = new System.Drawing.Size(298, 107);
            this.textRTB.TabIndex = 42;
            this.textRTB.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 41;
            this.label8.Text = "Text";
            // 
            // titleTB
            // 
            this.titleTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.titleTB.Location = new System.Drawing.Point(11, 109);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(298, 29);
            this.titleTB.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(158, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordTB.Location = new System.Drawing.Point(163, 46);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(146, 29);
            this.passwordTB.TabIndex = 38;
            // 
            // loginTB
            // 
            this.loginTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginTB.Location = new System.Drawing.Point(11, 46);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(146, 29);
            this.loginTB.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Login";
            // 
            // infoLB
            // 
            this.infoLB.AutoSize = true;
            this.infoLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.infoLB.Location = new System.Drawing.Point(64, 491);
            this.infoLB.Name = "infoLB";
            this.infoLB.Size = new System.Drawing.Size(113, 25);
            this.infoLB.TabIndex = 37;
            this.infoLB.Text = "Sending 0/0";
            this.infoLB.Visible = false;
            // 
            // SenderUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.infoLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sendBT);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "SenderUP";
            this.Size = new System.Drawing.Size(709, 562);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox accountCB;
        private System.Windows.Forms.ComboBox messageCB;
        private System.Windows.Forms.ComboBox emailsCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearSourceBT;
        private System.Windows.Forms.Button refreshBT;
        private System.Windows.Forms.Button toConfigBT;
        private System.Windows.Forms.Button sendBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Button clearConfigBT;
        private System.Windows.Forms.RichTextBox emailsRTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox textRTB;
        private System.Windows.Forms.Label infoLB;
    }
}
