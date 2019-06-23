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

namespace Email_Sender.GUI.UserPanels.AccountTemplatesUserPanel
{
    public partial class EditTemplateAT : UserControl
    {
        #region VARIABLES
        IAccountTemplatesControler templatesControler = new TemplatesControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when window open
        /// </summary>
        public EditTemplateAT()
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
            _templatesNames = templatesControler.GetAccountTemplatesNames();
            foreach (String _fileName in _templatesNames)
            {
                templateNameCB.Items.Add(_fileName);
            }
        }

        /// <summary>
        /// This method run when "X" button clicked
        /// </summary>
        private void clearLognBT_Click(object sender, EventArgs e)
        {
            accountLoginTB.Text = "";
        }

        /// <summary>
        /// This method run when "X" button clicked
        /// </summary>
        private void clearPasswordBT_Click(object sender, EventArgs e)
        {
            accountPasswordTB.Text = "";
        }

        /// <summary>
        /// This method run when "Edit template" button clicked
        /// </summary>
        private void editBT_Click(object sender, EventArgs e)
        {
            if (templateNameCB.Text == "" || templateNameCB.Text == "none" || accountLoginTB.Text == "" || accountPasswordTB.Text == "")
            {
                MessageBox.Show("Some template edit gap is empty !", "Some empty gap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                templatesControler.RemoveAccountTemplate(templateNameCB.Text);

                bool _operationResult = templatesControler.CreateAccountTemplate(templateNameCB.Text, accountLoginTB.Text, accountPasswordTB.Text, TemplatesControler.CreateOption.Edit);
                if (_operationResult)
                {
                    MessageBox.Show("Template edited properly !", "Editing went fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some error while editing template !", "Editing error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                templateNameCB.Text = "none";
                accountLoginTB.Text = "";
                accountPasswordTB.Text = "";
            }
        }

        /// <summary>
        /// This method run when template name index changed
        /// </summary>
        private void templateNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (templateNameCB.Text != "none")
            {
                string[] _templateData = new string[2];
                _templateData = templatesControler.GetAccountTemplate(templateNameCB.Text);

                accountLoginTB.Text = _templateData[0];
                accountPasswordTB.Text = _templateData[1];
            }
            else
            {
                accountLoginTB.Text = "";
                accountPasswordTB.Text = "";
            }
        }
        #endregion
    }
}
