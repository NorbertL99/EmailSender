﻿namespace Email_Sender.GUI.UserPanels.AccountTemplatesUserPanel
{
    partial class RemoveTemplateAT
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
            this.refreshBT = new System.Windows.Forms.Button();
            this.templateNameCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.removeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refreshBT
            // 
            this.refreshBT.BackColor = System.Drawing.Color.SeaGreen;
            this.refreshBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refreshBT.Location = new System.Drawing.Point(525, 210);
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(147, 32);
            this.refreshBT.TabIndex = 48;
            this.refreshBT.Text = "Refresh";
            this.refreshBT.UseVisualStyleBackColor = false;
            this.refreshBT.Click += new System.EventHandler(this.refreshBT_Click);
            // 
            // templateNameCB
            // 
            this.templateNameCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.templateNameCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.templateNameCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.templateNameCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.templateNameCB.FormattingEnabled = true;
            this.templateNameCB.Location = new System.Drawing.Point(177, 210);
            this.templateNameCB.Name = "templateNameCB";
            this.templateNameCB.Size = new System.Drawing.Size(342, 32);
            this.templateNameCB.TabIndex = 47;
            this.templateNameCB.Text = "none";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(172, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Template name";
            // 
            // removeBT
            // 
            this.removeBT.BackColor = System.Drawing.Color.SeaGreen;
            this.removeBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeBT.Location = new System.Drawing.Point(177, 248);
            this.removeBT.Name = "removeBT";
            this.removeBT.Size = new System.Drawing.Size(342, 30);
            this.removeBT.TabIndex = 49;
            this.removeBT.Text = "Remove template";
            this.removeBT.UseVisualStyleBackColor = false;
            this.removeBT.Click += new System.EventHandler(this.removeBT_Click);
            // 
            // RemoveTemplateAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.removeBT);
            this.Controls.Add(this.refreshBT);
            this.Controls.Add(this.templateNameCB);
            this.Controls.Add(this.label2);
            this.Name = "RemoveTemplateAT";
            this.Size = new System.Drawing.Size(709, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refreshBT;
        private System.Windows.Forms.ComboBox templateNameCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeBT;
    }
}
