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
    public partial class EditTemplateMT : UserControl
    {
        #region VARIABLES
        IMessageTemplatesControler templatesControler = new TemplatesControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when panel run
        /// </summary>
        public EditTemplateMT()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run when "Refresh" button clicked
        /// </summary>
        private void refreshBT_Click(object sender, EventArgs e)
        {
            templateNameCB.Items.Clear();
            templateNameCB.Items.Add("none");
            List<string> _templatesNames = new List<string>();
            _templatesNames = templatesControler.GetMessageTemplatesNames();
            foreach(String _fileName in _templatesNames)
            {
                templateNameCB.Items.Add(_fileName);
            }
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
        /// This method run when "Save changes" button clicked
        /// </summary>
        private void saveBT_Click(object sender, EventArgs e)
        {
            if (templateNameCB.Text == "" || templateNameCB.Text == "none" || messageTitleTB.Text == "" || messageContentRTB.Text == "")
            {
                MessageBox.Show("Some template edit gap is empty !", "Some empty gap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                templatesControler.RemoveMessageTemplate(templateNameCB.Text);

                bool _operationResult = templatesControler.CreateMessageTemplate(templateNameCB.Text, messageTitleTB.Text, messageContentRTB.Text, TemplatesControler.CreateOption.Edit);
                if (_operationResult)
                {
                    MessageBox.Show("Template edited properly !", "Editing went fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some error while editing template !", "Editing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                templateNameCB.Text = "none";
                messageTitleTB.Text = "";
                messageContentRTB.Text = "";
            }
        }

        /// <summary>
        /// This method run when index in template name changed
        /// </summary>
        private void templateNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(templateNameCB.Text != "none")
            {
                string[] _templateData = new string[2];
                _templateData = templatesControler.GetMessageTemplate(templateNameCB.Text);

                messageTitleTB.Text = _templateData[0];
                messageContentRTB.Text = _templateData[1];
            }
            else
            {
                messageTitleTB.Text = "";
                messageContentRTB.Text = "";
            }
        }
        #endregion
    }
}
