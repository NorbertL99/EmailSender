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

namespace Email_Sender.GUI.UserPanels.MessageTemplateUserPanels
{
    public partial class RemoveTemplateMT : UserControl
    {
        #region VARIABLES
        IMessageTemplatesControler templatesControler = new TemplatesControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when panel run
        /// </summary>
        public RemoveTemplateMT()
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
            templatesControler.RemoveMessageTemplate(templateNameCB.Text);
            MessageBox.Show("Template removed properly !", "Removed properly", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshBT_Click(null, null);
            templateNameCB.Text = "none";
        }
        #endregion
    }
}
