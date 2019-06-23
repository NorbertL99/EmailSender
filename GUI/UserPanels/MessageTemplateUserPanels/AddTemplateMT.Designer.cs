namespace Email_Sender.GUI.UserPanels.MessageTemplateUserPanels
{
    partial class AddTemplateMT
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
            this.templateNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messageTitleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.messageContentRTB = new System.Windows.Forms.RichTextBox();
            this.createBT = new System.Windows.Forms.Button();
            this.clearContentBT = new System.Windows.Forms.Button();
            this.fromFileBT = new System.Windows.Forms.Button();
            this.clearNameBT = new System.Windows.Forms.Button();
            this.clearTitleBT = new System.Windows.Forms.Button();
            this.fromFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // templateNameTB
            // 
            this.templateNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.templateNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.templateNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.templateNameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.templateNameTB.Location = new System.Drawing.Point(184, 78);
            this.templateNameTB.Name = "templateNameTB";
            this.templateNameTB.Size = new System.Drawing.Size(342, 29);
            this.templateNameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(179, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Template name";
            // 
            // messageTitleTB
            // 
            this.messageTitleTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messageTitleTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageTitleTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageTitleTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.messageTitleTB.Location = new System.Drawing.Point(184, 138);
            this.messageTitleTB.Name = "messageTitleTB";
            this.messageTitleTB.Size = new System.Drawing.Size(342, 29);
            this.messageTitleTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(179, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(179, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message content";
            // 
            // messageContentRTB
            // 
            this.messageContentRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.messageContentRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageContentRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageContentRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.messageContentRTB.Location = new System.Drawing.Point(184, 198);
            this.messageContentRTB.Name = "messageContentRTB";
            this.messageContentRTB.Size = new System.Drawing.Size(342, 178);
            this.messageContentRTB.TabIndex = 8;
            this.messageContentRTB.Text = "";
            // 
            // createBT
            // 
            this.createBT.BackColor = System.Drawing.Color.SeaGreen;
            this.createBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createBT.Location = new System.Drawing.Point(184, 418);
            this.createBT.Name = "createBT";
            this.createBT.Size = new System.Drawing.Size(342, 30);
            this.createBT.TabIndex = 9;
            this.createBT.Text = "Create template";
            this.createBT.UseVisualStyleBackColor = false;
            this.createBT.Click += new System.EventHandler(this.createBT_Click);
            // 
            // clearContentBT
            // 
            this.clearContentBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearContentBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearContentBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearContentBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearContentBT.Location = new System.Drawing.Point(419, 382);
            this.clearContentBT.Name = "clearContentBT";
            this.clearContentBT.Size = new System.Drawing.Size(107, 30);
            this.clearContentBT.TabIndex = 10;
            this.clearContentBT.Text = "Clear";
            this.clearContentBT.UseVisualStyleBackColor = false;
            this.clearContentBT.Click += new System.EventHandler(this.clearContentBT_Click);
            // 
            // fromFileBT
            // 
            this.fromFileBT.BackColor = System.Drawing.Color.SeaGreen;
            this.fromFileBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fromFileBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fromFileBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fromFileBT.Location = new System.Drawing.Point(184, 382);
            this.fromFileBT.Name = "fromFileBT";
            this.fromFileBT.Size = new System.Drawing.Size(229, 30);
            this.fromFileBT.TabIndex = 13;
            this.fromFileBT.Text = "Get from file";
            this.fromFileBT.UseVisualStyleBackColor = false;
            this.fromFileBT.Click += new System.EventHandler(this.fromFileBT_Click);
            // 
            // clearNameBT
            // 
            this.clearNameBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearNameBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearNameBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearNameBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearNameBT.Location = new System.Drawing.Point(532, 78);
            this.clearNameBT.Name = "clearNameBT";
            this.clearNameBT.Size = new System.Drawing.Size(32, 29);
            this.clearNameBT.TabIndex = 14;
            this.clearNameBT.Text = " X";
            this.clearNameBT.UseVisualStyleBackColor = false;
            this.clearNameBT.Click += new System.EventHandler(this.clearNameBT_Click);
            // 
            // clearTitleBT
            // 
            this.clearTitleBT.BackColor = System.Drawing.Color.SeaGreen;
            this.clearTitleBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearTitleBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearTitleBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearTitleBT.Location = new System.Drawing.Point(532, 138);
            this.clearTitleBT.Name = "clearTitleBT";
            this.clearTitleBT.Size = new System.Drawing.Size(32, 29);
            this.clearTitleBT.TabIndex = 15;
            this.clearTitleBT.Text = " X";
            this.clearTitleBT.UseVisualStyleBackColor = false;
            this.clearTitleBT.Click += new System.EventHandler(this.clearTitleBT_Click);
            // 
            // fromFileDialog
            // 
            this.fromFileDialog.FileName = "openFileDialog1";
            this.fromFileDialog.Filter = "txt files (*.txt)|*.txt";
            // 
            // AddTemplateMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.clearTitleBT);
            this.Controls.Add(this.clearNameBT);
            this.Controls.Add(this.fromFileBT);
            this.Controls.Add(this.clearContentBT);
            this.Controls.Add(this.createBT);
            this.Controls.Add(this.messageContentRTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageTitleTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.templateNameTB);
            this.Name = "AddTemplateMT";
            this.Size = new System.Drawing.Size(709, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox templateNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageTitleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox messageContentRTB;
        private System.Windows.Forms.Button createBT;
        private System.Windows.Forms.Button clearContentBT;
        private System.Windows.Forms.Button fromFileBT;
        private System.Windows.Forms.Button clearNameBT;
        private System.Windows.Forms.Button clearTitleBT;
        private System.Windows.Forms.OpenFileDialog fromFileDialog;
    }
}
