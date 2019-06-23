using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sender.Interfaces
{
    interface IRefreshAndGetTemplates
    {
        /// <summary>
        /// This method is used to get all templates names
        /// </summary>
        /// <returns>All templates names</returns>
        List<string> GetEmailsTemplatesNames();

        /// <summary>
        /// This method is used to get all templates names
        /// </summary>
        /// <returns>All templates names</returns>
        List<string> GetMessageTemplatesNames();

        /// <summary>
        /// This method is used to get all templates names
        /// </summary>
        /// <returns>All templates names</returns>
        List<string> GetAccountTemplatesNames();

        /// <summary>
        /// This method is used to get message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>Template. [0] - account login, [1] - account password</returns>
        string[] GetAccountTemplate(string _templateName);

        /// <summary>
        /// This method is used to get message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>Template. [0] - message title, [1] - message content</returns>
        string[] GetMessageTemplate(string _templateName);

        /// <summary>
        /// This method is used to get email template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>Template data ( all emails )</returns>
        List<string> GetEmailsTemplate(string _templateName);
    }
}
