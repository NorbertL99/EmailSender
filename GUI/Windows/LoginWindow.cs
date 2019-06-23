using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Email_Sender.Classes.Database;
using Email_Sender.Classes.Cryptography;
using Email_Sender.GUI.Windows;
using System.Threading;
using Email_Sender.Classes;

namespace Email_Sender
{
    public partial class LoginWindow : Form
    {
        #region VARIABLES
        DatabaseGetData getData = new DatabaseGetData();
        MD5Control md5Control = new MD5Control();
        MainWindow mainWindow = new MainWindow();
        UserControler userControler = new UserControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run when window open
        /// </summary>
        public LoginWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run after "Sign In" button clicked
        /// </summary>
        private async void signInBT_Click(object sender, EventArgs e)
        {
            if(emailTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Some login gap is empty !", "Some empty gap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DisableGUI();
                DatabaseGetData.OperationResult _loginStatus = await GetLoginStatus();
                switch (_loginStatus)
                {
                    case DatabaseGetData.OperationResult.NoInternet:
                        MessageBox.Show("There is no internet connection !", "Internet error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EnableGUI();
                        break;
                    case DatabaseGetData.OperationResult.ErrorWhileConnectingToDatabase:
                        MessageBox.Show("Some error found while connecting to database !", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EnableGUI();
                        break;
                    case DatabaseGetData.OperationResult.ErrorWhileGettingData:
                        MessageBox.Show("Some error found while getting data from database !", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EnableGUI();
                        break;
                    case DatabaseGetData.OperationResult.WrongLoginData:
                        MessageBox.Show("Given login data are wrong !", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        EnableGUI();
                        break;
                    case DatabaseGetData.OperationResult.Fine:
                        MessageBox.Show("Welcome ! You logged properly !", "Login went fine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EnableGUI();

                        userControler.SetUserConfig(emailTB.Text);

                        Close();
                        Thread _thread = new Thread(OpenNewForm);
                        _thread.SetApartmentState(ApartmentState.STA);
                        _thread.Start();
                        break;
                }
            }
        }

        /// <summary>
        /// This method is used to do login proces async
        /// </summary>
        /// <returns>Login proces status</returns>
        private async Task<DatabaseGetData.OperationResult> GetLoginStatus()                                                                                    
        {
            return await Task.Run(() =>                                                            
            {
                return getData.CheckLoginData(emailTB.Text, md5Control.MD5Hash(passwordTB.Text));                                       
            });
        }

        /// <summary>
        /// This method is used to disaple GUI
        /// </summary>
        private void DisableGUI()
        {
            signInBT.Enabled = false;
            passwordTB.Enabled = false;
            emailTB.Enabled = false;

            infoLB.Visible = true;
        }

        /// <summary>
        /// This method is used to enable GUI
        /// </summary>
        private void EnableGUI()
        {
            signInBT.Enabled = true;
            passwordTB.Enabled = true;
            emailTB.Enabled = true;

            infoLB.Visible = false;
        }

        /// <summary>
        /// This method is used to close current window and open MainWindow
        /// </summary>
        /// <param name="_toOpen">Object of method</param>
        private void OpenNewForm(object _obj)
        {
            Application.Run(new MainWindow());
        }
        #endregion

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            userControler.RemoveUserConfig();
        }
    }
}
