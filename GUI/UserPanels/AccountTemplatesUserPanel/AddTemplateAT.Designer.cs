namespace Email_Sender.GUI.UserPanels.AccountTemplatesUserPanel
{
    partial class AddTemplateAT
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
            this.label2 = new System.Windows.Forms.Label();
            this.templateNameTB = new System.Windows.Forms.TextBox();
            this.createBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.accountLoginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.accountPasswordTB = new System.Windows.Forms.TextBox();
            this.clearNameBT = new System.Windows.Forms.Button();
            this.clearLoginBT = new System.Windows.Forms.Button();
            this.clearPasswordBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(179, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Template name";
            // 
            // templateNameTB
            // 
            this.templateNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.templateNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.templateNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.templateNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.templateNameTB.Location = new System.Drawing.Point(184, 145);
            this.templateNameTB.Name = "templateNameTB";
            this.templateNameTB.Size = new System.Drawing.Size(342, 29);
            this.templateNameTB.TabIndex = 18;
            // 
            // createBT
            // 
            this.createBT.BackColor = System.Drawing.Color.SeaGreen;
            this.createBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createBT.Location = new System.Drawing.Point(184, 300);
            this.createBT.Name = "createBT";
            this.createBT.Size = new System.Drawing.Size(342, 30);
            this.createBT.TabIndex = 21;
            this.createBT.Text = "Create template";
            this.createBT.UseVisualStyleBackColor = false;
            this.createBT.Click += new System.EventHandler(this.createBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(179, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Email login";
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
            this.accountLoginTB.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(179, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Email password";
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
            this.accountPasswordTB.TabIndex = 25;
            // 
            // clearNameBT
            // 
            this.clearNameBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearNameBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearNameBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearNameBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearNameBT.Location = new System.Drawing.Point(532, 145);
            this.clearNameBT.Name = "clearNameBT";
            this.clearNameBT.Size = new System.Drawing.Size(32, 29);
            this.clearNameBT.TabIndex = 26;
            this.clearNameBT.Text = " X";
            this.clearNameBT.UseVisualStyleBackColor = false;
            this.clearNameBT.Click += new System.EventHandler(this.clearNameBT_Click);
            // 
            // clearLoginBT
            // 
            this.clearLoginBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearLoginBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearLoginBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearLoginBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearLoginBT.Location = new System.Drawing.Point(532, 205);
            this.clearLoginBT.Name = "clearLoginBT";
            this.clearLoginBT.Size = new System.Drawing.Size(32, 29);
            this.clearLoginBT.TabIndex = 27;
            this.clearLoginBT.Text = " X";
            this.clearLoginBT.UseVisualStyleBackColor = false;
            this.clearLoginBT.Click += new System.EventHandler(this.clearLoginBT_Click);
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
            this.clearPasswordBT.TabIndex = 28;
            this.clearPasswordBT.Text = " X";
            this.clearPasswordBT.UseVisualStyleBackColor = false;
            this.clearPasswordBT.Click += new System.EventHandler(this.clearPasswordBT_Click);
            // 
            // AddTemplateAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.clearPasswordBT);
            this.Controls.Add(this.clearLoginBT);
            this.Controls.Add(this.clearNameBT);
            this.Controls.Add(this.accountPasswordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountLoginTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createBT);
            this.Controls.Add(this.templateNameTB);
            this.Controls.Add(this.label2);
            this.Name = "AddTemplateAT";
            this.Size = new System.Drawing.Size(709, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox templateNameTB;
        private System.Windows.Forms.Button createBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accountLoginTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accountPasswordTB;
        private System.Windows.Forms.Button clearNameBT;
        private System.Windows.Forms.Button clearLoginBT;
        private System.Windows.Forms.Button clearPasswordBT;
    }
}
