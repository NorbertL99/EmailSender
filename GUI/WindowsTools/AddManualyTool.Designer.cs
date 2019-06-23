namespace Email_Sender.GUI.WindowsTools
{
    partial class AddManualyTool
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
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailTB.Location = new System.Drawing.Point(17, 37);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(302, 29);
            this.emailTB.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Email";
            // 
            // addBT
            // 
            this.addBT.BackColor = System.Drawing.Color.SeaGreen;
            this.addBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addBT.Location = new System.Drawing.Point(17, 72);
            this.addBT.Name = "addBT";
            this.addBT.Size = new System.Drawing.Size(302, 30);
            this.addBT.TabIndex = 21;
            this.addBT.Text = "Add email";
            this.addBT.UseVisualStyleBackColor = false;
            this.addBT.Click += new System.EventHandler(this.addBT_Click);
            // 
            // AddManualyTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(345, 122);
            this.Controls.Add(this.addBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddManualyTool";
            this.Text = "Manualy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBT;
    }
}