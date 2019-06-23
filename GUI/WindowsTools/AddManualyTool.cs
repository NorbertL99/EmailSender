using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Email_Sender.Classes;
using Email_Sender.GUI.UserPanels.EmailTemplateUserPanels;

namespace Email_Sender.GUI.WindowsTools
{
    public partial class AddManualyTool : Form
    {
        #region VARIABLES
        EmailsControler emailsControler = new EmailsControler();
        AddTemplateET templateET = new AddTemplateET();
        #endregion 

        #region METHODS
        /// <summary>
        /// This method run when window open
        /// </summary>
        public AddManualyTool()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run when "Add email" clicked
        /// </summary>
        private void addBT_Click(object sender, EventArgs e)
        {
            if(emailTB.Text == "")
            {
                MessageBox.Show("You need to give some email !", "Empty gap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                emailsControler.AddEmail(emailTB.Text);
                emailTB.Text = "";
            }
        }
        #endregion
    }
}
