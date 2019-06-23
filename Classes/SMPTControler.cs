using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Email_Sender.Classes
{
    class SMPTControler
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Basic constructor, empty
        /// </summary>
        public SMPTControler()
        {

        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to send emails
        /// </summary>
        /// <param name="_login">Email login</param>
        /// <param name="_password">Email password</param>
        /// <param name="_from">From who</param>
        /// <param name="_recipient">Recipient of message</param>
        /// <param name="_title">Message title</param>
        /// <param name="_text">Message text</param>
        /// <returns></returns>
        public bool SendEmail(string _login, string _password, string _from, string _recipient, string _title, string _text)
        {
            try
            {
                var _client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(_login, _password),
                    EnableSsl = true
                };
                _client.Send(_from, _recipient, _title, _text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
