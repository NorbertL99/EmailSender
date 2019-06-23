using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Email_Sender.Classes;

namespace Email_Sender.Interfaces
{
    interface IAccountTemplatesControler
    {
        /// <summary>
        /// This method is used to create account template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <param name="_accountLogin">Account login</param>
        /// <param name="_accountPassword">Account password</param>
        /// <param name="createOption">Create option</param>
        /// <returns>If return TRUE, template created properly. If returned FALSE, something went wrong while creating template</returns>
        bool CreateAccountTemplate(string _templateName, string _accountLogin, string _accountPassword, TemplatesControler.CreateOption _createOption);

        /// <summary>
        /// This method is used to remove account template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>If return TRUE, template removed properly. If returned FALSE, something went wrong while removeing template</returns>
        bool RemoveAccountTemplate(string _templateName);

        /// <summary>
        /// This method is used to get message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>Template. [0] - account login, [1] - account password</returns>
        string[] GetAccountTemplate(string _templateName);

        /// <summary>
        /// This method is used to get all templates names
        /// </summary>
        /// <returns>All templates names</returns>
        List<string> GetAccountTemplatesNames();
    }
}
