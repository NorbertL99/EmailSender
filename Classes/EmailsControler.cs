using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sender.Classes
{
    class EmailsControler
    {
        #region VARIABLES
        static List<string> _emailsList = new List<string>();
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Basic constructor, empty
        /// </summary>
        public EmailsControler()
        {

        }
        #endregion

        #region METHODS
        /// <summary>
        /// This method is used to add email to emails list
        /// </summary>
        /// <param name="_email">Email to add</param>
        public void AddEmail(string _email)
        {
            _emailsList.Add(_email);
        }

        /// <summary>
        /// This method is used to get emails list
        /// </summary>
        /// <returns>Emails list</returns>
        public List<string> GetEmails()
        {
            return _emailsList;
        }

        /// <summary>
        /// This method is used to clear emails list
        /// </summary>
        public void ClearEmails()
        {
            _emailsList.Clear();
        }

        /// <summary>
        /// This method is used to remove duplicats from emial list
        /// </summary>
        public void RemoveDuplicats()
        {
            for(int i=0; i<_emailsList.Count; i++)
            {
                string _current = _emailsList[i];
                for(int j=0; j<_emailsList.Count;j++)
                {
                    if(j != i)
                    {
                        if(_current == _emailsList[j])
                        {
                            _emailsList.RemoveAt(j);
                        }
                    }
                }
            }
            foreach (string _email in _emailsList)
            {
                if (_email == "")
                {
                    _emailsList.Remove(_email);
                }
            }
        }
        #endregion
    }
}
