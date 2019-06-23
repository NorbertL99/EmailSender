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
    public partial class AccountTemplatesUP : UserControl
    {
        #region METHODS
        /// <summary>
        /// This method run when panel open
        /// </summary>
        public AccountTemplatesUP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run "Add Template" button clicked
        /// </summary>
        private void addTemplateBT_Click(object sender, EventArgs e)
        {
            addTemplateAT.BringToFront();
        }

        /// <summary>
        /// This method run "Edit Template" button clicked
        /// </summary>
        private void editTemplateBT_Click(object sender, EventArgs e)
        {
            editTemplateAT.BringToFront();
        }

        /// <summary>
        /// This method run "Remove Template" button clicked
        /// </summary>
        private void removeTemplateBT_Click(object sender, EventArgs e)
        {
            removeTemplateAT.BringToFront();
        }
        #endregion
    }
}
