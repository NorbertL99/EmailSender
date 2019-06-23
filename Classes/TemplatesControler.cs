using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Email_Sender.Interfaces;
using System.IO;
using Email_Sender.Classes.Cryptography;

namespace Email_Sender.Classes
{
    class TemplatesControler : DESControler, IEmailTemplatesControler, IMessageTemplatesControler, IAccountTemplatesControler, IRefreshAndGetTemplates
    {
        #region VARIABLES
        const string MESSAGE_TEMPLATE_PATH = "../../Templates/Messages";
        const string EMAIL_TEMPLATE_PATH = "../../Templates/Email";
        const string ACCOUNT_TEMPLATE_PATH = "../../Templates/Account";
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Basic constructor, empty
        /// </summary>
        public TemplatesControler()
        {

        }
        #endregion

        #region ENUM
        public enum CreateOption
        {
            New,
            Edit
        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to create message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <param name="_messageTitle">Message title</param>
        /// <param name="_messageContent">Message content</param>
        /// <param name="_createOption">Create option</param>
        /// <returns>If return TRUE, template created properly. If returned FALSE, something went wrong while creating template</returns>
        public bool CreateMessageTemplate(string _templateName, string _messageTitle, string _messageContent, CreateOption _createOption)
        {
            try
            {
                string _path = "";
                switch(_createOption)
                {
                    case CreateOption.New:
                        _path = MESSAGE_TEMPLATE_PATH + "/" + _templateName + ".txt";
                        break;
                    case CreateOption.Edit:
                        _path = MESSAGE_TEMPLATE_PATH + "/" + _templateName;
                        break;
                }
                if (!File.Exists(MESSAGE_TEMPLATE_PATH + "/" + _templateName + ".txt"))
                {                   
                    StreamWriter streamWriter = File.CreateText(_path);
                    streamWriter.WriteLine(DESEncryption(_messageTitle));
                    streamWriter.WriteLine(DESEncryption(_messageContent));
                    streamWriter.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This method is used to get message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>Template. [0] - message title, [1] - message content</returns>
        public string[] GetMessageTemplate(string _templateName)
        {
            string[] _templateData = new string[2];

            StreamReader streamReader = new StreamReader(MESSAGE_TEMPLATE_PATH + "/" + _templateName);
            _templateData[0] = DESDecryption(streamReader.ReadLine());
            _templateData[1] = DESDecryption(streamReader.ReadLine());
            streamReader.Close();

            return _templateData;
        }

        /// <summary>
        /// This method is used to get all templates names
        /// </summary>
        /// <returns>All templates names</returns>
        public List<string> GetMessageTemplatesNames()
        {
            List<string> _templatesNames = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(MESSAGE_TEMPLATE_PATH);
            FileInfo[] fileInfo = directoryInfo.GetFiles("*.txt");
            foreach(FileInfo file in fileInfo)
            {
                _templatesNames.Add(file.Name);
            }
            return _templatesNames;
        }

        /// <summary>
        /// This method is used to remove message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>If return TRUE, template removed properly. If returned FALSE, something went wrong while removeing template</returns>
        public bool RemoveMessageTemplate(string _templateName)
        {
            try
            {
                File.Delete(MESSAGE_TEMPLATE_PATH + "/" + _templateName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This method is used to create email template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <param name="_emails">List of emails</param>
        /// <param name="_createOption">Create option</param>
        /// <returns>If return TRUE, template created properly. If returned FALSE, something went wrong while creating template</returns>
        public bool CreateEmailTemplate(string _templateName, List<string> _emails, CreateOption _createOption)
        {
            try
            {
                string _path = "";
                switch (_createOption)
                {
                    case CreateOption.New:
                        _path = EMAIL_TEMPLATE_PATH + "/" + _templateName + ".txt";
                        break;
                    case CreateOption.Edit:
                        _path = EMAIL_TEMPLATE_PATH + "/" + _templateName;
                        break;
                }
                if (!File.Exists(EMAIL_TEMPLATE_PATH + "/" + _templateName + ".txt"))
                {
                    StreamWriter streamWriter = File.CreateText(_path);
                    foreach(String _email in _emails)
                    {
                        streamWriter.WriteLine(DESEncryption(_email));
                    }
                    streamWriter.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This method is used to remove email template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>If return TRUE, template removed properly. If returned FALSE, something went wrong while removeing template</returns>
        public bool RemoveEmailTemplate(string _templateName)
        {
            try
            {
                File.Delete(EMAIL_TEMPLATE_PATH + "/" + _templateName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This method is used to get email template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>Template data ( all emails )</returns>
        public List<string> GetEmailsTemplate(string _templateName)
        {
            List<string> _emailsList = new List<string>();

            StreamReader streamReader = new StreamReader(EMAIL_TEMPLATE_PATH + "/" + _templateName);
            while(streamReader.Peek() >= 0)
            {
                _emailsList.Add(DESDecryption(streamReader.ReadLine()));
            }
            streamReader.Close();

            return _emailsList;
        }

        /// <summary>
        /// This method is used to get all templates names
        /// </summary>
        /// <returns>All templates names</returns>
        public List<string> GetEmailsTemplatesNames()
        {
            List<string> _templatesNames = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(EMAIL_TEMPLATE_PATH);
            FileInfo[] fileInfo = directoryInfo.GetFiles("*.txt");
            foreach (FileInfo file in fileInfo)
            {
                _templatesNames.Add(file.Name);
            }
            return _templatesNames;
        }

        /// <summary>
        /// This method is used to create account template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <param name="_accountLogin">Account login</param>
        /// <param name="_accountPassword">Account password</param>
        /// <param name="createOption">Create option</param>
        /// <returns>If return TRUE, template created properly. If returned FALSE, something went wrong while creating template</returns>
        public bool CreateAccountTemplate(string _templateName, string _accountLogin, string _accountPassword, CreateOption _createOption)
        {
            try
            {
                string _path = "";
                switch (_createOption)
                {
                    case CreateOption.New:
                        _path = ACCOUNT_TEMPLATE_PATH + "/" + _templateName + ".txt";
                        break;
                    case CreateOption.Edit:
                        _path = ACCOUNT_TEMPLATE_PATH + "/" + _templateName;
                        break;
                }
                if (!File.Exists(ACCOUNT_TEMPLATE_PATH + "/" + _templateName + ".txt"))
                {
                    StreamWriter streamWriter = File.CreateText(_path);
                    streamWriter.WriteLine(DESEncryption(_accountLogin));
                    streamWriter.WriteLine(DESEncryption(_accountPassword));
                    streamWriter.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This method is used to remove account template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>If return TRUE, template removed properly. If returned FALSE, something went wrong while removeing template</returns>
        public bool RemoveAccountTemplate(string _templateName)
        {
            try
            {
                File.Delete(ACCOUNT_TEMPLATE_PATH + "/" + _templateName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// This method is used to get message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>Template. [0] - account login, [1] - account password</returns>
        public string[] GetAccountTemplate(string _templateName)
        {
            string[] _templateData = new string[2];

            StreamReader streamReader = new StreamReader(ACCOUNT_TEMPLATE_PATH + "/" + _templateName);
            _templateData[0] = DESDecryption(streamReader.ReadLine());
            _templateData[1] = DESDecryption(streamReader.ReadLine());
            streamReader.Close();

            return _templateData;
        }

        /// <summary>
        /// This method is used to get all templates names
        /// </summary>
        /// <returns>All templates names</returns>
        public List<string> GetAccountTemplatesNames()
        {
            List<string> _templatesNames = new List<string>();
            DirectoryInfo directoryInfo = new DirectoryInfo(ACCOUNT_TEMPLATE_PATH);
            FileInfo[] fileInfo = directoryInfo.GetFiles("*.txt");
            foreach (FileInfo file in fileInfo)
            {
                _templatesNames.Add(file.Name);
            }
            return _templatesNames;
        }
        #endregion
    }
}
