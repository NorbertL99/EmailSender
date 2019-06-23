namespace Email_Sender.GUI.UserPanels.AccountTemplatesUserPanel
{
    partial class EditTemplateAT
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
            this.accountPasswordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountLoginTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clearLognBT = new System.Windows.Forms.Button();
            this.clearPasswordBT = new System.Windows.Forms.Button();
            this.templateNameCB = new System.Windows.Forms.ComboBox();
            this.refreshBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountPasswordTB
            // 
            this.accountPasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountPasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.accountPasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountPasswordTB.Location = new System.Drawing.Point(184, 265);
            this.accountPasswordTB.Name = "accountPasswordTB";
            this.accountPasswordTB.PasswordChar = '*';
            this.accountPasswordTB.Size = new System.Drawing.Size(342, 29);
            this.accountPasswordTB.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(179, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Email password";
            // 
            // accountLoginTB
            // 
            this.accountLoginTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountLoginTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountLoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.accountLoginTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.accountLoginTB.Location = new System.Drawing.Point(184, 205);
            this.accountLoginTB.Name = "accountLoginTB";
            this.accountLoginTB.Size = new System.Drawing.Size(342, 29);
            this.accountLoginTB.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(179, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Email login";
            // 
            // editBT
            // 
            this.editBT.BackColor = System.Drawing.Color.SeaGreen;
            this.editBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editBT.Location = new System.Drawing.Point(184, 300);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(342, 30);
            this.editBT.TabIndex = 28;
            this.editBT.Text = "Edit template";
            this.editBT.UseVisualStyleBackColor = false;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(179, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Template name";
            // 
            // clearLognBT
            // 
            this.clearLognBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearLognBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearLognBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearLognBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearLognBT.Location = new System.Drawing.Point(532, 205);
            this.clearLognBT.Name = "clearLognBT";
            this.clearLognBT.Size = new System.Drawing.Size(32, 29);
            this.clearLognBT.TabIndex = 33;
            this.clearLognBT.Text = " X";
            this.clearLognBT.UseVisualStyleBackColor = false;
            this.clearLognBT.Click += new System.EventHandler(this.clearLognBT_Click);
            // 
            // clearPasswordBT
            // 
            this.clearPasswordBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearPasswordBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearPasswordBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearPasswordBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearPasswordBT.Location = new System.Drawing.Point(532, 265);
            this.clearPasswordBT.Name = "clearPasswordBT";
            this.clearPasswordBT.Size = new System.Drawing.Size(32, 29);
            this.clearPasswordBT.TabIndex = 34;
            this.clearPasswordBT.Text = " X";
            this.clearPasswordBT.UseVisualStyleBackColor = false;
            this.clearPasswordBT.Click += new System.EventHandler(this.clearPasswordBT_Click);
            // 
            // templateNameCB
            // 
            this.templateNameCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.templateNameCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.templateNameCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.templateNameCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.templateNameCB.FormattingEnabled = true;
            this.templateNameCB.Location = new System.Drawing.Point(184, 145);
            this.templateNameCB.Name = "templateNameCB";
            this.templateNameCB.Size = new System.Drawing.Size(342, 32);
            this.templateNameCB.TabIndex = 44;
            this.templateNameCB.Text = "none";
            this.templateNameCB.SelectedIndexChanged += new System.EventHandler(this.templateNameCB_SelectedIndexChanged);
            // 
            // refreshBT
            // 
            this.refreshBT.BackColor = System.Drawing.Color.SeaGreen;
            this.refreshBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refreshBT.Location = new System.Drawing.Point(532, 145);
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(147, 32);
            this.refreshBT.TabIndex = 45;
            this.refreshBT.Text = "Refresh";
            this.refreshBT.UseVisualStyleBackColor = false;
            this.refreshBT.Click += new System.EventHandler(this.refreshBT_Click);
            // 
            // EditTemplateAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.refreshBT);
            this.Controls.Add(this.templateNameCB);
            this.Controls.Add(this.clearPasswordBT);
            this.Controls.Add(this.clearLognBT);
            this.Controls.Add(this.accountPasswordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountLoginTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editBT);
            this.Controls.Add(this.label2);
            this.Name = "EditTemplateAT";
            this.Size = new System.Drawing.Size(709, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountPasswordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountLoginTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearLognBT;
        private System.Windows.Forms.Button clearPasswordBT;
        private System.Windows.Forms.ComboBox templateNameCB;
        private System.Windows.Forms.Button refreshBT;
    }
}
