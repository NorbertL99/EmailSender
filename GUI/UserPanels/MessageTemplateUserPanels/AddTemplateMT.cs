using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Email_Sender.Interfaces;
using Email_Sender.Classes;
using System.IO;

namespace Email_Sender.GUI.UserPanels.MessageTemplateUserPanels
{
    public partial class AddTemplateMT : UserControl
    {
        #region VARIABLES
        IMessageTemplatesControler templatesControler = new TemplatesControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when panel run
        /// </summary>
        public AddTemplateMT()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run when "X" near "Template name" clicked
        /// </summary>
        private void clearNameBT_Click(object sender, EventArgs e)
        {
            templateNameTB.Text = "";
        }

        /// <summary>
        /// This method run when "X" near "Message title" clicked
        /// </summary>
        private void clearTitleBT_Click(object sender, EventArgs e)
        {
            messageTitleTB.Text = "";
        }

        /// <summary>
        /// This method run when "Get from file" button clicked
        /// </summary>
        private void fromFileBT_Click(object sender, EventArgs e)
        {
            if (fromFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(fromFileDialog.FileName);
                messageContentRTB.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        /// <summary>
        /// This method run when "Clear" button clicked
        /// </summary>
        private void clearContentBT_Click(object sender, EventArgs e)
        {
            messageContentRTB.Text = "";
        }

        /// <summary>
        /// This method run when "Create template" button clicked
        /// </summary>
        private void createBT_Click(object sender, EventArgs e)
        {
            if(templateNameTB.Text == "" || messageTitleTB.Text == "" || messageContentRTB.Text == "")
            {
                MessageBox.Show("Some template create gap is empty !", "Some empty gap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool _operationResult = templatesControler.CreateMessageTemplate(templateNameTB.Text, messageTitleTB.Text, messageContentRTB.Text, TemplatesControler.CreateOption.New);
                if(_operationResult)
                {
                    MessageBox.Show("Template created properly !", "Creating went fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some error while creating template !", "Creating error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                templateNameTB.Text = "";
                messageTitleTB.Text = "";
                messageContentRTB.Text = "";
            }
        }
        #endregion
    }
}
