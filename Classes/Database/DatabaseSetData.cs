using Email_Sender.Classes.Web;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sender.Classes.Database
{
    class DatabaseSetData : DatabaseConnect
    {
        #region VARIABLES
        ConnectionControler connectionControler = new ConnectionControler();
        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Basic constructor, empty
        /// </summary>
        public DatabaseSetData()
        {

        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to insert new send to history
        /// </summary>
        public void InsertSendToHistory(string _messageTemplate, string _accountTemplate, string _emailTemplate, int _totalSended, 
            int _properlySended, int _errorSended, string _principal)
        {
            string _date = DateTime.Now.ToString();
            string _connectionString = getConnectionString();
            bool _internetState = connectionControler.CheckInternetConnection();

            if (_internetState)
            {
                MySqlConnection mySqlConnection = new MySqlConnection(_connectionString);
                string _commandString = "INSERT INTO `history_of_sends`(`message_template`, `account_template`, `email_template`, " +
                    "`total_sended`, `properly_sended`, `error_sended`, `date_of_send`, `principal`) VALUES('"+ _messageTemplate + "', '"+ _accountTemplate + "', '"+ _emailTemplate + "', " +
                    ""+ _totalSended + ", "+ _properlySended + ", "+ _errorSended + ", '"+ _date + "', '"+ _principal + "')";

                try                                                                                  
                {
                    if (mySqlConnection.State == ConnectionState.Closed)                              
                    {
                        mySqlConnection.Open();                                                       
                    }
                    MySqlCommand sqlCommand = new MySqlCommand(_commandString, mySqlConnection);                              
                    MySqlDataReader myReader;                                                        
                    myReader = sqlCommand.ExecuteReader();
                    mySqlConnection.Close();                                                           
                    return;                                                                       
                }
                catch (Exception)                                                                    
                {
                    return;                                                                        
                }
            }
        }
        #endregion
    }
}
