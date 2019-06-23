using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Email_Sender.Classes.Database;
using Email_Sender.Classes;

namespace Email_Sender.GUI.UserPanels
{
    public partial class HistoryUP : UserControl
    {
        #region VARIABLES
        DatabaseGetData databaseGetData = new DatabaseGetData();
        UserControler userControler = new UserControler();
        #endregion

        #region METHODS
        /// <summary>
        /// This method run, when panel open
        /// </summary>
        public HistoryUP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method run after "Refresh" button clicked
        /// </summary>
        private async void refreshBT_Click(object sender, EventArgs e)
        {
            historyDGV.DataSource = await GetHistory();
        }

        /// <summary>
        /// This method is used to get history of sends
        /// </summary>
        /// <returns>History</returns>
        private async Task<DataTable> GetHistory()
        {
            return await Task.Run(() =>
            {
                return databaseGetData.GetHistory(userControler.GetUserConfig());
            });
        }
        #endregion
    }
}
