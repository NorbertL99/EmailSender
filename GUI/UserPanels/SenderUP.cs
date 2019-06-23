using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Email_Sender.Classes;
using Email_Sender.Interfaces;
using Email_Sender.Classes.Database;

namespace Email_Sender.GUI.UserPanels
{
    public partial class SenderUP : UserControl
    {
        #region VARIABLES
        IRefreshAndGetTemplates refreshAndGetTemplates = new TemplatesControler();
        SMPTControler smptControler = new SMPTControler();
        DatabaseSetData databaseSetData = new DatabaseSetData();
        UserControler userControler = new UserControler(); 
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when window open
        /// </summary>
        public SenderUP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run when "Get data to config" button clicked
        /// </summary>
        private void toConfigBT_Click(object sender, EventArgs e)
        {
            if(accountCB.Text != "none" && emailsCB.Text != "none" && messageCB.Text != "none")
            {
                string[] _loginData = new string[2];
                string[] _messageData = new string[2];
                List<string> _emails = new List<string>();

                _loginData = refreshAndGetTemplates.GetAccountTemplate(accountCB.Text);
                _messageData = refreshAndGetTemplates.GetMessageTemplate(messageCB.Text);
                _emails = refreshAndGetTemplates.GetEmailsTemplate(emailsCB.Text);

                loginTB.Text = _loginData[0];
                passwordTB.Text = _loginData[1];

                titleTB.Text = _messageData[0];
                textRTB.Text = _messageData[1];

                emailsRTB.Text = "";
                foreach(string _email in _emails)
                {
                    emailsRTB.Text = emailsRTB.Text + _email + "\n";
                }
            }
            else
            {
                MessageBox.Show("Some template was not choosen !", "Template error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method run when "Refresh data sources" button clicked
        /// </summary>
        private void refreshBT_Click(object sender, EventArgs e)
        {
            messageCB.Items.Clear();
            messageCB.Items.Add("none");
            List<string> _templatesNames = new List<string>();
            _templatesNames = refreshAndGetTemplates.GetMessageTemplatesNames();
            foreach (String _fileName in _templatesNames)
            {
                messageCB.Items.Add(_fileName);
            }

            accountCB.Items.Clear();
            accountCB.Items.Add("none");
            _templatesNames = refreshAndGetTemplates.GetAccountTemplatesNames();
            foreach (String _fileName in _templatesNames)
            {
                accountCB.Items.Add(_fileName);
            }

            emailsCB.Items.Clear();
            emailsCB.Items.Add("none");
            _templatesNames = refreshAndGetTemplates.GetEmailsTemplatesNames();
            foreach (String _fileName in _templatesNames)
            {
                emailsCB.Items.Add(_fileName);
            }
        }

        /// <summary>
        /// This method run when "Clear" button clicked
        /// </summary>
        private void clearSourceBT_Click(object sender, EventArgs e)
        {
            accountCB.Text = "none";
            messageCB.Text = "none";
            emailsCB.Text = "none";
        }

        /// <summary>
        /// This method run when "Clear" button clicked
        /// </summary>
        private void clearConfigBT_Click(object sender, EventArgs e)
        {
            loginTB.Text = "";
            passwordTB.Text = "";
            titleTB.Text = "";
            textRTB.Text = "";
            emailsRTB.Text = "";
        }

        /// <summary>
        /// This method run when "Send" button clicked
        /// </summary>
        private async void sendBT_Click(object sender, EventArgs e)
        {
            int _properSendes = 0;
            int _sendsErrored = 0;
            int _wholeToSend = 0;
            int _toSend = emailsRTB.Lines.Count();
            foreach(string _email in emailsRTB.Lines)
            {
                DisableGUI();
                bool _operationStatus = await GetSendingStatus(_email, textRTB.Text);
                if (_operationStatus)
                {
                    _properSendes = _properSendes + 1;
                }
                else
                {
                    _sendsErrored = _sendsErrored + 1;
                }
                _wholeToSend = _properSendes + _sendsErrored;
                infoLB.Text = "Sending " + _wholeToSend.ToString() + "/" + _toSend.ToString();              
            }
            MessageBox.Show("Sended completed properly ! \n" +
                            "Proper sends: " + _properSendes.ToString() + "\n" +
                            "Errored sends: " + _sendsErrored.ToString(), "Send raport", MessageBoxButtons.OK, MessageBoxIcon.Information);
            databaseSetData.InsertSendToHistory(emailsCB.Text, accountCB.Text, emailsCB.Text, _wholeToSend, _properSendes, _sendsErrored, userControler.GetUserConfig());
            EnableGUI();
        }

        /// <summary>
        /// This method is used to get sending status
        /// </summary>
        /// <param name="_email">Email to send</param>
        /// <param name="_text">Text of message</param>
        /// <returns>Sending status</returns>
        private async Task<bool> GetSendingStatus(string _email, string _text)
        {
            return await Task.Run(() =>
            {
                return smptControler.SendEmail(loginTB.Text, passwordTB.Text, loginTB.Text, _email, titleTB.Text, _text);
            });
        }

        /// <summary>
        /// This method is used to disable gui
        /// </summary>
        private void DisableGUI()
        {
            infoLB.Visible = true;

            accountCB.Enabled = false;
            messageCB.Enabled = false;
            emailsCB.Enabled = false;
            refreshBT.Enabled = false;
            toConfigBT.Enabled = false;
            clearSourceBT.Enabled = false;

            loginTB.Enabled = false;
            passwordTB.Enabled = false;
            titleTB.Enabled = false;
            textRTB.Enabled = false;
            emailsRTB.Enabled = false;
            clearConfigBT.Enabled = false;
            sendBT.Enabled = false;
        }

        /// <summary>
        /// This method is used to enable gui
        /// </summary>
        private void EnableGUI()
        {
            infoLB.Visible = false;

            accountCB.Enabled = true;
            messageCB.Enabled = true;
            emailsCB.Enabled = true;
            refreshBT.Enabled = true;
            toConfigBT.Enabled = true;
            clearSourceBT.Enabled = true;

            loginTB.Enabled = true;
            passwordTB.Enabled = true;
            titleTB.Enabled = true;
            textRTB.Enabled = true;
            emailsRTB.Enabled = true;
            clearConfigBT.Enabled = true;
            sendBT.Enabled = true;
        }
        #endregion
    }
}
