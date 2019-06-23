using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Email_Sender.Classes.Database;
using Email_Sender.Classes.Web;
using MySql.Data.MySqlClient;

namespace Email_Sender.Classes.Database
{
    class DatabaseGetData : DatabaseConnect
    {
        #region VARIABLES
        ConnectionControler connectionControler = new ConnectionControler();
        #endregion

        #region ENUMS
        public enum OperationResult
        {
            NoInternet,
            ErrorWhileConnectingToDatabase,
            ErrorWhileGettingData,
            WrongLoginData,
            Fine
        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to check about properly given login data
        /// </summary>
        /// <param name="_email">User email</param>
        /// <param name="_password">User password</param>
        /// <returns>WrongLoginData: user gives wrong login data
        ///          LoginFine: user gives good login data
        ///          ErrorWhileGettingData: some error become while getting data from database
        ///          ErrorWhileConnectingToDatabase: some error become while connecting to database
        ///          NoInternet: there is no internet connection</returns>
        public OperationResult CheckLoginData(string _email, string _password)
        {
            string _connectionString = getConnectionString();
            bool _internetState = connectionControler.CheckInternetConnection();

            if(_internetState)
            {
                MySqlConnection mySqlConnection = new MySqlConnection(_connectionString);
                string _commandString = "SELECT * FROM users WHERE `email` = '" + _email + "' AND `password` = '" + _password + "';";

                try
                {
                    if(mySqlConnection.State == System.Data.ConnectionState.Closed)
                    {
                        mySqlConnection.Open();
                    }
                    MySqlCommand mySqlCommand = new MySqlCommand(_commandString, mySqlConnection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataSet dataSet = new DataSet();
                    mySqlDataAdapter.Fill(dataSet);
                    mySqlConnection.Close();
                    int _count = dataSet.Tables[0].Rows.Count;

                    if(_count == 0)
                    {
                        return OperationResult.WrongLoginData;
                    }
                    else if(_count > 0)
                    {
                        return OperationResult.Fine;
                    }
                    else
                    {
                        return OperationResult.ErrorWhileGettingData;
                    }
                }
                catch (Exception)
                {
                    return OperationResult.ErrorWhileConnectingToDatabase;
                }
            }
            else
            {
                return OperationResult.NoInternet;
            }

        }

        /// <summary>
        /// This method is used to get history for specific user
        /// </summary>
        /// <param name="_email">User email</param>
        /// <returns>History from database, if something went wrong NULL</returns>
        public DataTable GetHistory(string _email)
        {
            string _connectionString = getConnectionString();
            bool _internetState = connectionControler.CheckInternetConnection();
            if (_internetState)
            {
                MySqlConnection mySqlConnection = new MySqlConnection(_connectionString);
                string _commandString = "SELECT `message_template`,`account_template`,`email_template`,`total_sended`,`properly_sended`," +
                    "`error_sended`,`date_of_send` FROM `history_of_sends` WHERE `principal` = '" + _email + "';";

                try
                {
                    if (mySqlConnection.State == System.Data.ConnectionState.Closed)
                    {
                        mySqlConnection.Open();
                    }
                    MySqlCommand mySqlCommand = new MySqlCommand(_commandString, mySqlConnection);
                    MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
                    DataTable dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);
                    mySqlConnection.Close();
                    return dataTable;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
