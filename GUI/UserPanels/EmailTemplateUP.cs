using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Sender.GUI.UserPanels
{
    public partial class EmailTemplateUP : UserControl
    {
        #region METHODS
        /// <summary>
        /// This method run when UP open
        /// </summary>
        public EmailTemplateUP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run after "Add Template" button clicked
        /// </summary>
        private void addTemplateBT_Click(object sender, EventArgs e)
        {
            addTemplate.BringToFront();
        }

        /// <summary>
        /// This method run after "Edit Template" button clicked
        /// </summary>
        private void editTemplateBT_Click(object sender, EventArgs e)
        {
            editTemplate.BringToFront();
        }

        /// <summary>
        /// This method run after "Remove Template" button clicked
        /// </summary>
        private void removeTemplateBT_Click(object sender, EventArgs e)
        {
            removeTemplate.BringToFront();
        }
        #endregion
    }
}
