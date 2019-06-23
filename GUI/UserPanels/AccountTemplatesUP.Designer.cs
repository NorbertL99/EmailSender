namespace Email_Sender.GUI.UserPanels
{
    partial class AccountTemplatesUP
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
            this.upMenu = new System.Windows.Forms.MenuStrip();
            this.addTemplateBT = new System.Windows.Forms.ToolStripMenuItem();
            this.editTemplateBT = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTemplateBT = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addTemplateAT = new Email_Sender.GUI.UserPanels.AccountTemplatesUserPanel.AddTemplateAT();
            this.editTemplateAT = new Email_Sender.GUI.UserPanels.AccountTemplatesUserPanel.EditTemplateAT();
            this.removeTemplateAT = new Email_Sender.GUI.UserPanels.AccountTemplatesUserPanel.RemoveTemplateAT();
            this.panel1.SuspendLayout();
            this.upMenu.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(518, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Templates GUI, version: 0.00";
            // 
            // upMenu
            // 
            this.upMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTemplateBT,
            this.editTemplateBT,
            this.removeTemplateBT});
            this.upMenu.Location = new System.Drawing.Point(0, 0);
            this.upMenu.Name = "upMenu";
            this.upMenu.Size = new System.Drawing.Size(709, 25);
            this.upMenu.TabIndex = 6;
            this.upMenu.Text = "menuStrip1";
            // 
            // addTemplateBT
            // 
            this.addTemplateBT.ForeColor = System.Drawing.Color.SeaGreen;
            this.addTemplateBT.Name = "addTemplateBT";
            this.addTemplateBT.Size = new System.Drawing.Size(106, 21);
            this.addTemplateBT.Text = "Add Template ";
            this.addTemplateBT.Click += new System.EventHandler(this.addTemplateBT_Click);
            // 
            // editTemplateBT
            // 
            this.editTemplateBT.ForeColor = System.Drawing.Color.SeaGreen;
            this.editTemplateBT.Name = "editTemplateBT";
            this.editTemplateBT.Size = new System.Drawing.Size(100, 21);
            this.editTemplateBT.Text = "Edit Template";
            this.editTemplateBT.Click += new System.EventHandler(this.editTemplateBT_Click);
            // 
            // removeTemplateBT
            // 
            this.removeTemplateBT.ForeColor = System.Drawing.Color.SeaGreen;
            this.removeTemplateBT.Name = "removeTemplateBT";
            this.removeTemplateBT.Size = new System.Drawing.Size(125, 21);
            this.removeTemplateBT.Text = "Remove Template";
            this.removeTemplateBT.Click += new System.EventHandler(this.removeTemplateBT_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addTemplateAT);
            this.panel2.Controls.Add(this.removeTemplateAT);
            this.panel2.Controls.Add(this.editTemplateAT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 512);
            this.panel2.TabIndex = 7;
            // 
            // addTemplateAT
            // 
            this.addTemplateAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addTemplateAT.Location = new System.Drawing.Point(0, 0);
            this.addTemplateAT.Name = "addTemplateAT";
            this.addTemplateAT.Size = new System.Drawing.Size(709, 512);
            this.addTemplateAT.TabIndex = 0;
            // 
            // editTemplateAT
            // 
            this.editTemplateAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editTemplateAT.Location = new System.Drawing.Point(0, 0);
            this.editTemplateAT.Name = "editTemplateAT";
            this.editTemplateAT.Size = new System.Drawing.Size(709, 512);
            this.editTemplateAT.TabIndex = 1;
            // 
            // removeTemplateAT
            // 
            this.removeTemplateAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.removeTemplateAT.Location = new System.Drawing.Point(0, 0);
            this.removeTemplateAT.Name = "removeTemplateAT";
            this.removeTemplateAT.Size = new System.Drawing.Size(709, 512);
            this.removeTemplateAT.TabIndex = 2;
            // 
            // AccountTemplatesUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.upMenu);
            this.Controls.Add(this.panel1);
            this.Name = "AccountTemplatesUP";
            this.Size = new System.Drawing.Size(709, 562);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.upMenu.ResumeLayout(false);
            this.upMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip upMenu;
        private System.Windows.Forms.ToolStripMenuItem addTemplateBT;
        private System.Windows.Forms.ToolStripMenuItem editTemplateBT;
        private System.Windows.Forms.ToolStripMenuItem removeTemplateBT;
        private System.Windows.Forms.Panel panel2;
        private AccountTemplatesUserPanel.AddTemplateAT addTemplateAT;
        private AccountTemplatesUserPanel.RemoveTemplateAT removeTemplateAT;
        private AccountTemplatesUserPanel.EditTemplateAT editTemplateAT;
    }
}
