using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sender.Classes.Database
{
    class DatabaseConnect
    {
        #region VARIABLES
        /// 
        /// Those variables store info about database connect
        /// 
        static readonly string _datasource = "datasource=127.0.0.1;";
        static readonly string _port = "port=3306;";
        static readonly string _username = "username=root;";
        static readonly string _password = "password=;";
        static readonly string _database = "database=email_sender_test_db;";
        static readonly string _sslmode = "sslmode=none;";

        ///
        /// This variable store completed database connection string
        ///
        static readonly string _connectionString = _datasource + _port + _username + _password + _database + _sslmode;
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Basic class constructor, empty
        /// </summary>
        public DatabaseConnect()
        {

        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to get database connection string
        /// </summary>
        /// <returns>Connection string</returns>
        protected string getConnectionString()
        {
            return _connectionString;
        }
        #endregion
    }
}
