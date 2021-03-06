﻿namespace Email_Sender.GUI.UserPanels.EmailTemplateUserPanels
{
    partial class EditTemplateET
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textFileBT = new System.Windows.Forms.Button();
            this.manualBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshEmailsBT = new System.Windows.Forms.Button();
            this.quantityBT = new System.Windows.Forms.Button();
            this.removeDuplicatsBT = new System.Windows.Forms.Button();
            this.clearBT = new System.Windows.Forms.Button();
            this.refreshBT = new System.Windows.Forms.Button();
            this.editBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.templateNameCB = new System.Windows.Forms.ComboBox();
            this.emailsRTB = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textFileBT);
            this.groupBox2.Controls.Add(this.manualBT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(532, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 274);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Email source";
            // 
            // textFileBT
            // 
            this.textFileBT.BackColor = System.Drawing.Color.SeaGreen;
            this.textFileBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textFileBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textFileBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textFileBT.Location = new System.Drawing.Point(6, 57);
            this.textFileBT.Name = "textFileBT";
            this.textFileBT.Size = new System.Drawing.Size(147, 30);
            this.textFileBT.TabIndex = 26;
            this.textFileBT.Text = "Text file";
            this.textFileBT.UseVisualStyleBackColor = false;
            this.textFileBT.Click += new System.EventHandler(this.textFileBT_Click);
            // 
            // manualBT
            // 
            this.manualBT.BackColor = System.Drawing.Color.SeaGreen;
            this.manualBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manualBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.manualBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.manualBT.Location = new System.Drawing.Point(6, 21);
            this.manualBT.Name = "manualBT";
            this.manualBT.Size = new System.Drawing.Size(147, 30);
            this.manualBT.TabIndex = 25;
            this.manualBT.Text = "Manual";
            this.manualBT.UseVisualStyleBackColor = false;
            this.manualBT.Click += new System.EventHandler(this.manualBT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreshEmailsBT);
            this.groupBox1.Controls.Add(this.quantityBT);
            this.groupBox1.Controls.Add(this.removeDuplicatsBT);
            this.groupBox1.Controls.Add(this.clearBT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(19, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 274);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // refreshEmailsBT
            // 
            this.refreshEmailsBT.BackColor = System.Drawing.Color.SeaGreen;
            this.refreshEmailsBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshEmailsBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshEmailsBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refreshEmailsBT.Location = new System.Drawing.Point(6, 21);
            this.refreshEmailsBT.Name = "refreshEmailsBT";
            this.refreshEmailsBT.Size = new System.Drawing.Size(147, 30);
            this.refreshEmailsBT.TabIndex = 45;
            this.refreshEmailsBT.Text = "Refresh";
            this.refreshEmailsBT.UseVisualStyleBackColor = false;
            this.refreshEmailsBT.Click += new System.EventHandler(this.refreshEmailsBT_Click);
            // 
            // quantityBT
            // 
            this.quantityBT.BackColor = System.Drawing.Color.SeaGreen;
            this.quantityBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quantityBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quantityBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.quantityBT.Location = new System.Drawing.Point(6, 94);
            this.quantityBT.Name = "quantityBT";
            this.quantityBT.Size = new System.Drawing.Size(147, 30);
            this.quantityBT.TabIndex = 26;
            this.quantityBT.Text = "Quantity";
            this.quantityBT.UseVisualStyleBackColor = false;
            this.quantityBT.Click += new System.EventHandler(this.quantityBT_Click);
            // 
            // removeDuplicatsBT
            // 
            this.removeDuplicatsBT.BackColor = System.Drawing.Color.SeaGreen;
            this.removeDuplicatsBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeDuplicatsBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.removeDuplicatsBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.removeDuplicatsBT.Location = new System.Drawing.Point(6, 57);
            this.removeDuplicatsBT.Name = "removeDuplicatsBT";
            this.removeDuplicatsBT.Size = new System.Drawing.Size(147, 30);
            this.removeDuplicatsBT.TabIndex = 24;
            this.removeDuplicatsBT.Text = "Remove duplicats";
            this.removeDuplicatsBT.UseVisualStyleBackColor = false;
            this.removeDuplicatsBT.Click += new System.EventHandler(this.removeDuplicatsBT_Click);
            // 
            // clearBT
            // 
            this.clearBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearBT.Location = new System.Drawing.Point(6, 130);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(147, 30);
            this.clearBT.TabIndex = 23;
            this.clearBT.Text = "Clear";
            this.clearBT.UseVisualStyleBackColor = false;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // refreshBT
            // 
            this.refreshBT.BackColor = System.Drawing.Color.SeaGreen;
            this.refreshBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refreshBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.refreshBT.Location = new System.Drawing.Point(538, 78);
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(147, 30);
            this.refreshBT.TabIndex = 27;
            this.refreshBT.Text = "Refresh";
            this.refreshBT.UseVisualStyleBackColor = false;
            this.refreshBT.Click += new System.EventHandler(this.refreshBT_Click);
            // 
            // editBT
            // 
            this.editBT.BackColor = System.Drawing.Color.SeaGreen;
            this.editBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editBT.Location = new System.Drawing.Point(184, 418);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(342, 30);
            this.editBT.TabIndex = 28;
            this.editBT.Text = "Edit template";
            this.editBT.UseVisualStyleBackColor = false;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(179, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Emails";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(179, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Template name";
            // 
            // templateNameCB
            // 
            this.templateNameCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.templateNameCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.templateNameCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.templateNameCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.templateNameCB.FormattingEnabled = true;
            this.templateNameCB.Location = new System.Drawing.Point(184, 78);
            this.templateNameCB.Name = "templateNameCB";
            this.templateNameCB.Size = new System.Drawing.Size(342, 32);
            this.templateNameCB.TabIndex = 43;
            this.templateNameCB.Text = "none";
            this.templateNameCB.SelectedIndexChanged += new System.EventHandler(this.templateNameCB_SelectedIndexChanged);
            // 
            // emailsRTB
            // 
            this.emailsRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailsRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailsRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailsRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailsRTB.Location = new System.Drawing.Point(184, 138);
            this.emailsRTB.Name = "emailsRTB";
            this.emailsRTB.Size = new System.Drawing.Size(342, 274);
            this.emailsRTB.TabIndex = 44;
            this.emailsRTB.Text = "";
            // 
            // EditTemplateET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.emailsRTB);
            this.Controls.Add(this.refreshBT);
            this.Controls.Add(this.templateNameCB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "EditTemplateET";
            this.Size = new System.Drawing.Size(709, 512);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button textFileBT;
        private System.Windows.Forms.Button manualBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button removeDuplicatsBT;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button editBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox templateNameCB;
        private System.Windows.Forms.Button quantityBT;
        private System.Windows.Forms.Button refreshBT;
        private System.Windows.Forms.RichTextBox emailsRTB;
        private System.Windows.Forms.Button refreshEmailsBT;
    }
}
