using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Email_Sender.Classes;

namespace Email_Sender.Interfaces
{
    interface IMessageTemplatesControler
    {
        /// <summary>
        /// This method is used to create message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <param name="_messageTitle">Message title</param>
        /// <param name="_messageContent">Message content</param>
        /// <param name="_createOption">Create option</param>
        /// <returns>If return TRUE, template created properly. If returned FALSE, something went wrong while creating template</returns>
        bool CreateMessageTemplate(string _templateName, string _messageTitle, string _messageContent, TemplatesControler.CreateOption _createOption);

        /// <summary>
        /// This method is used to remove message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>If return TRUE, template removed properly. If returned FALSE, something went wrong while removeing template</returns>
        bool RemoveMessageTemplate(string _templateName);

        /// <summary>
        /// This method is used to get message template
        /// </summary>
        /// <param name="_templateName">Template name</param>
        /// <returns>Template. [0] - message title, [1] - message content</returns>
        string[] GetMessageTemplate(string _templateName);
        
        /// <summary>
        /// This method is used to get all templates names
        /// </summary>
        /// <returns>All templates names</returns>
        List<string> GetMessageTemplatesNames();
    }
}
