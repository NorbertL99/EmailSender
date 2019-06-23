using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Email_Sender.Classes;

namespace Email_Sender.Interfaces
{
    interface IEmailTemplatesControler
    {
        /// <summary>
        /// This method is used to create email template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <param name="_emails">List of emails</param>
        /// <param name="_createOption">Create option</param>
        /// <returns>If return TRUE, template created properly. If returned FALSE, something went wrong while creating template</returns>
        bool CreateEmailTemplate(string _templateName, List<string> _emails, TemplatesControler.CreateOption _createOption);

        /// <summary>
        /// This method is used to remove email template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>If return TRUE, template removed properly. If returned FALSE, something went wrong while removeing template</returns>
        bool RemoveEmailTemplate(string _templateName);

        /// <summary>
        /// This method is used to get email template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>Template data ( all emails )</returns>
        List<string> GetEmailsTemplate(string _templateName);

        /// <summary>
        /// This method is used to get all templates names
        /// </summary>
        /// <returns>All templates names</returns>
        List<string> GetEmailsTemplatesNames();
    }
}
