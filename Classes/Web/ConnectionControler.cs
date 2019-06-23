using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sender.Classes.Web
{
    class ConnectionControler
    {
        #region CONSTRUCTORS
        /// <summary>
        /// Basic class constructor, empty
        /// </summary>
        public ConnectionControler()
        {

        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to check of proper internet connection
        /// </summary>
        /// <returns>Return TRUE is there is connection and FALSE if there is no connection</returns>
        public bool CheckInternetConnection()                                        
        {
            try                                                                    
            {
                using (var _client = new WebClient())                             
                {
                    using (var _stream = _client.OpenRead("http://www.google.com"))   
                    {
                        return true;                                                   
                    }
                }
            }
            catch (Exception)                                                   
            {
                return false;                                                        
            }
        }
        #endregion
    }
}
