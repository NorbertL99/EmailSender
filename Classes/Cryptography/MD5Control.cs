using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sender.Classes.Cryptography
{
    class MD5Control
    {
        #region CONSTRUCTORS
        /// <summary>
        /// Basic class constructor, empty
        /// </summary>
        public MD5Control()
        {

        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to hash given text
        /// </summary>
        /// <param name="_text">Text to hash</param>
        /// <returns>Hashed text</returns>
        public string MD5Hash(string _text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(_text));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
        #endregion
    }
}
