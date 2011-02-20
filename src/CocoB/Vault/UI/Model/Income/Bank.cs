/*
 * Bank.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/13/2011 9:27:41 PM
 *
 */

using System.Collections.Generic;
using System.Collections.ObjectModel;
using CocoB.Vault.UI.Income.BankReport;

namespace CocoB.Vault.UI.Model.Income
{
    public class Bank
    {
        #region Member Variables

        #endregion

        #region Constructors

        public Bank()
        {
            Accounts = new ObservableCollection<Account>();
        }

        #endregion

        #region Properties

        public ICollection<Account> Accounts { get; private set; }

        public string Name { get; set; }

        public long Balance { get; set; }

        #endregion

        #region Methods

        #endregion


    }
}