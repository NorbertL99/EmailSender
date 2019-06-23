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
using Email_Sender.GUI.WindowsTools;

namespace Email_Sender.GUI.UserPanels.EmailTemplateUserPanels
{
    public partial class AddTemplateET : UserControl
    {
        #region VARIABLES
        IEmailTemplatesControler templatesControler = new TemplatesControler();
        EmailsControler emailsControler = new EmailsControler();       
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when panel open
        /// </summary>
        public AddTemplateET()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run when "X" button clicked
        /// </summary>
        private void clearNameBT_Click(object sender, EventArgs e)
        {
            templateNameTB.Text = "";
        }

        /// <summary>
        /// This method run when "Remove duplicats" button clicked
        /// </summary>
        private void removeDuplicatsBT_Click(object sender, EventArgs e)
        {
            emailsControler.RemoveDuplicats();
            RefreeshEmailsView();
        }

        /// <summary>
        /// This method run when "Quantity" button clicked
        /// </summary>
        private void quantityBT_Click(object sender, EventArgs e)
        {
            int _countEmails = emailsRTB.Lines.Count() - 1;
            MessageBox.Show("Your template contain " + _countEmails.ToString() + " emails", "Quantity information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// This method run when "Clear" button clicked
        /// </summary>
        private void clearBT_Click(object sender, EventArgs e)
        {
            emailsRTB.Text = "";
            emailsControler.ClearEmails();
        }

        /// <summary>
        /// This method run when "Manual" button clicked
        /// </summary>
        private void manualBT_Click(object sender, EventArgs e)
        {
            AddManualyTool addManualyTool = new AddManualyTool();
            addManualyTool.Show();
        }

        /// <summary>
        /// This method run when "Text file" button clicked
        /// </summary>
        private void textFileBT_Click(object sender, EventArgs e)
        {
            AddFromFileTool addFromFileTool = new AddFromFileTool();
            addFromFileTool.Show();
        }

        /// <summary>
        /// This method run when "Refresh" button clicked
        /// </summary>
        private void refreshBT_Click(object sender, EventArgs e)
        {
            RefreeshEmailsView();
        }

        /// <summary>
        /// This method run when "Create template" button clicked
        /// </summary>
        private void createBT_Click(object sender, EventArgs e)
        {
            if(templateNameTB.Text == "" || emailsRTB.Text == "")
            {
                MessageBox.Show("Some template create gap is empty !", "Some empty gap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool _operationResult = templatesControler.CreateEmailTemplate(templateNameTB.Text, ConvertItemsToList(), TemplatesControler.CreateOption.New);
                if (_operationResult)
                {
                    MessageBox.Show("Template created properly !", "Creating went fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some error while creating template !", "Creating error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                templateNameTB.Text = "";
                emailsRTB.Text = "";
                emailsControler.ClearEmails();
            }
        }

        /// <summary>
        /// This method is used to get all items from emils to list
        /// </summary>
        /// <returns>List</returns>
        private List<string> ConvertItemsToList()
        {
            List<string> _emailsList = new List<string>();
            foreach(String _line in emailsRTB.Lines)
            {
                _emailsList.Add(_line);
            }
            return _emailsList;
        }

        /// <summary>
        /// This method is used to refresh emails view
        /// </summary>
        public void RefreeshEmailsView()
        {
            emailsRTB.Text = "";
            List<string> _emails = new List<string>();
            _emails = emailsControler.GetEmails();
            foreach (string _email in _emails)
            {
                emailsRTB.Text = emailsRTB.Text + _email + "\n";
            }
        }
        #endregion
    }
}
