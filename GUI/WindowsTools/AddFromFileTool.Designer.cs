namespace Email_Sender.GUI.WindowsTools
{
    partial class AddFromFileTool
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
            this.pathTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fetchAndAddBT = new System.Windows.Forms.Button();
            this.getPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // pathTB
            // 
            this.pathTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pathTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pathTB.Location = new System.Drawing.Point(17, 37);
            this.pathTB.Name = "pathTB";
            this.pathTB.Size = new System.Drawing.Size(302, 29);
            this.pathTB.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Path";
            // 
            // fetchAndAddBT
            // 
            this.fetchAndAddBT.BackColor = System.Drawing.Color.SeaGreen;
            this.fetchAndAddBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fetchAndAddBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fetchAndAddBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fetchAndAddBT.Location = new System.Drawing.Point(17, 72);
            this.fetchAndAddBT.Name = "fetchAndAddBT";
            this.fetchAndAddBT.Size = new System.Drawing.Size(302, 30);
            this.fetchAndAddBT.TabIndex = 22;
            this.fetchAndAddBT.Text = "Featch and add emails";
            this.fetchAndAddBT.UseVisualStyleBackColor = false;
            this.fetchAndAddBT.Click += new System.EventHandler(this.fetchAndAddBT_Click);
            // 
            // getPathDialog
            // 
            this.getPathDialog.FileName = "openFileDialog1";
            // 
            // AddFromFileTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(336, 120);
            this.Controls.Add(this.fetchAndAddBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFromFileTool";
            this.Text = "File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fetchAndAddBT;
        private System.Windows.Forms.OpenFileDialog getPathDialog;
    }
}