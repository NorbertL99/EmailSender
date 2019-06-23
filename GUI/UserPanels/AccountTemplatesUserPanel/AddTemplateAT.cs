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
    public partial class AddTemplateAT : UserControl
    {
        #region VARIABLES
        IAccountTemplatesControler templatesControler = new TemplatesControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when window open
        /// </summary>
        public AddTemplateAT()
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
        /// This method run when "X" button clicked
        /// </summary>
        private void clearLoginBT_Click(object sender, EventArgs e)
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
        /// This method run when "Create template" button clicked
        /// </summary>
        private void createBT_Click(object sender, EventArgs e)
        {
            if (templateNameTB.Text == "" || accountLoginTB.Text == "" || accountPasswordTB.Text == "")
            {
                MessageBox.Show("Some template create gap is empty !", "Some empty gap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool _operationResult = templatesControler.CreateAccountTemplate(templateNameTB.Text, accountLoginTB.Text, accountPasswordTB.Text, TemplatesControler.CreateOption.New);
                if (_operationResult)
                {
                    MessageBox.Show("Template created properly !", "Creating went fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some error while creating template !", "Creating error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                templateNameTB.Text = "";
                accountLoginTB.Text = "";
                accountPasswordTB.Text = "";
            }
        }
        #endregion
    }
}
