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

namespace Email_Sender.GUI.UserPanels.EmailTemplateUserPanels
{
    public partial class RemoveTemplateET : UserControl
    {
        #region VARIABLES
        IEmailTemplatesControler templatesControler = new TemplatesControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when panel open
        /// </summary>
        public RemoveTemplateET()
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
            _templatesNames = templatesControler.GetEmailsTemplatesNames();
            foreach (String _fileName in _templatesNames)
            {
                templateNameCB.Items.Add(_fileName);
            }
        }

        /// <summary>
        /// This method run when "Remove template" button clicked
        /// </summary>
        private void removeTemplateBT_Click(object sender, EventArgs e)
        {
            templatesControler.RemoveEmailTemplate(templateNameCB.Text);
            MessageBox.Show("Template removed properly !", "Removed properly", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshBT_Click(null, null);
            templateNameCB.Text = "none";
        }
        #endregion
    }
}
