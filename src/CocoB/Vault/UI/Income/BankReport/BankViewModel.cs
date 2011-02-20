/*
 * BankViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/17/2011 12:30:32 AM
 *
 */

using System.Collections.Generic;
using System.Collections.ObjectModel;
using CocoB.Vault.UI.Income.AccountReport;
using CocoB.Vault.UI.Model.Income;

namespace CocoB.Vault.UI.Income.BankReport
{
    public class BankViewModel : FinancialViewModel
    {
        #region Constructors

        public BankViewModel()
        {
            AccountStubs = new ObservableCollection<AccountViewModel>();

            Currencies = new[] { "CAD", "US" };
        }

        #endregion

        #region Properties

        public Bank BankModel { get; set; }

        public ICollection<AccountViewModel> AccountStubs { get; private set; }

        public string[] Currencies { get; set; }

        #endregion

        #region Methods

        protected override void OnInitialize()
        {
            base.OnInitialize();

            Name = BankModel.Name;
            Balance = BankModel.Balance;
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            foreach (var accountViewModel in AccountStubs)
            {
                Balance += accountViewModel.Balance;
            }
        }

        #endregion
    }
}