using Email_Sender.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_Sender.GUI.Windows
{
    public partial class MainWindow : Form
    {
        #region VARIABLES
        UserControler userControler = new UserControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when window open
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run after "Sender" button clicked
        /// </summary>
        private void senderBT_Click(object sender, EventArgs e)
        {
            sendersys.BringToFront();
        }

        /// <summary>
        /// This method run after "Email Templates" button clicked
        /// </summary>
        private void emailTemplatesBT_Click(object sender, EventArgs e)
        {
            emailTemplate.BringToFront();
        }

        /// <summary>
        /// This method run after "Message Templates" button clicked
        /// </summary>
        private void messageTemplatesBT_Click(object sender, EventArgs e)
        {
            messageTemplate.BringToFront();
        }

        /// <summary>
        /// This method run after "History" button clicked
        /// </summary>
        private void historyBT_Click(object sender, EventArgs e)
        {
            history.BringToFront();
        }

        /// <summary>
        /// This method run after "Configuration" button clicked
        /// </summary>
        private void configurationBT_Click(object sender, EventArgs e)
        {
            configuration.BringToFront();
        }

        /// <summary>
        /// This method run after "Account Templates" button clicked
        /// </summary>
        private void accountTemplatesBT_Click(object sender, EventArgs e)
        {
            accountTemplates.BringToFront();
        }

        /// <summary>
        /// This method run after "Help" button clicked
        /// </summary>
        private void helpBT_Click(object sender, EventArgs e)
        {
            // TODO
        }

        /// <summary>
        /// This method run after "Informations" button clicked
        /// </summary>
        private void informationsBT_Click(object sender, EventArgs e)
        {
            // TODO
        }

        /// <summary>
        /// This method run when program closeing
        /// </summary>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            userControler.RemoveUserConfig();
        }
        #endregion
    }
}
