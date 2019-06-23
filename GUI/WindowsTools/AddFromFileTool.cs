using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Email_Sender.Classes;

namespace Email_Sender.GUI.WindowsTools
{
    public partial class AddFromFileTool : Form
    {
        #region VARIABLES 
        EmailsControler emailsControler = new EmailsControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when window open
        /// </summary>
        public AddFromFileTool()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run when "Fetch and add emails" button clicked
        /// </summary>
        private void fetchAndAddBT_Click(object sender, EventArgs e)
        {
            List<string> _emails = new List<string>();

            StreamReader streamReader = new StreamReader(pathTB.Text);
            while(streamReader.Peek() >= 0)
            {
                _emails.Add(streamReader.ReadLine());
            }

            foreach(string _email in _emails)
            {
                emailsControler.AddEmail(_email);
            }

            pathTB.Text = "";
        }
        #endregion
    }
}
