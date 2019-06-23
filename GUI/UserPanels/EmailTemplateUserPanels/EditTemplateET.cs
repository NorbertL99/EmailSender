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
    public partial class EditTemplateET : UserControl
    {
        #region VARIABLES
        IEmailTemplatesControler templatesControler = new TemplatesControler();
        EmailsControler emailsControler = new EmailsControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when panel open
        /// </summary>
        public EditTemplateET()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run when template name index changed
        /// </summary>
        private void templateNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(templateNameCB.Text != "none")
            {
                emailsControler.ClearEmails();
                List<string> _emails = new List<string>();
                _emails = templatesControler.GetEmailsTemplate(templateNameCB.Text);
                foreach (string _email in _emails)
                {
                    emailsControler.AddEmail(_email);
                }
                RefreeshEmailsView();
            }
            else
            {
                emailsRTB.Text = "";
            }
        }

        /// <summary>
        /// This method run when "Refresh" button clicked
        /// </summary>
        private void refreshBT_Click(object sender, EventArgs e)
        {
            templateNameCB.Items.Clear();
            templateNameCB.Items.Add("none");
            List<string> _templatesNames = new List<string>();
            _templatesNames = templatesControler.GetEmailsTemplatesNames();
            foreach (String _fileName in _templatesNames)
            {
                templateNameCB.Items.Add(_fileName);
            }
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
        /// This method run when "Create template" button clicked
        /// </summary>
        private void editBT_Click(object sender, EventArgs e)
        {
            if (templateNameCB.Text == "" || emailsRTB.Text == "")
            {
                MessageBox.Show("Some template edi gap is empty !", "Some empty gap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                templatesControler.RemoveEmailTemplate(templateNameCB.Text);

                bool _operationResult = templatesControler.CreateEmailTemplate(templateNameCB.Text, ConvertItemsToList(), TemplatesControler.CreateOption.Edit);
                if (_operationResult)
                {
                    MessageBox.Show("Template edited properly !", "Creating went fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some error while editing template !", "Creating error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                templateNameCB.Text = "none";
                emailsRTB.Text = "";
                emailsControler.ClearEmails();
            }
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

        /// <summary>
        /// This method is used to get all items from emils to list
        /// </summary>
        /// <returns>List</returns>
        private List<string> ConvertItemsToList()
        {
            List<string> _emailsList = new List<string>();
            foreach (String _line in emailsRTB.Lines)
            {
                _emailsList.Add(_line);
            }
            return _emailsList;
        }

        /// <summary>
        /// This method run when "Refresh" button clicked
        /// </summary>
        private void refreshEmailsBT_Click(object sender, EventArgs e)
        {
            RefreeshEmailsView();
        }
        #endregion
    }
}
