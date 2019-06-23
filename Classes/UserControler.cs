using Email_Sender.Classes.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Email_Sender.Classes
{
    class UserControler : DESControler 
    {
        #region VARIABLES
        const string USER_CONFIG_PATH = "../../user_data.txt";
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Basic constructor, empty
        /// </summary>
        public UserControler()
        {

        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to create user configuration
        /// </summary>
        /// <param name="_email"></param>
        public void SetUserConfig(string _email)
        {
            StreamWriter streamWriter = File.CreateText(USER_CONFIG_PATH);
            streamWriter.WriteLine(DESEncryption(_email));
            streamWriter.Close();
        }

        /// <summary>
        /// This method is used to remove user configuration
        /// </summary>
        public void RemoveUserConfig()
        {
            File.Delete(USER_CONFIG_PATH);
        }

        /// <summary>
        /// This method is used to get email from user config
        /// </summary>
        /// <returns>Currently logged user</returns>
        public string GetUserConfig()
        {
            string _email;
            StreamReader streamReader = new StreamReader(USER_CONFIG_PATH);
            _email = DESDecryption(streamReader.ReadLine());
            streamReader.Close();
            return _email;
        }
        #endregion
    }
}
