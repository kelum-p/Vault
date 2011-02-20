/*
 * IncomeViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/6/2011 12:13:25 AM
 *
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using CocoB.Vault.UI.Income.AccountReport;
using CocoB.Vault.UI.Income.BankReport;
using CocoB.Vault.UI.Model.Income;

namespace CocoB.Vault.UI.Income.IncomeReport
{
    [Export(typeof(IncomeViewModel))]
    public class IncomeViewModel : Conductor<object>, IHandle<AccountViewModel>
    {
        #region Variables

        private readonly IncomeReportViewModel _incomeReportViewModel;

        #endregion

        [ImportingConstructor]
        public IncomeViewModel(IncomeReportViewModel incomeReportViewModel)
        {
            _incomeReportViewModel = incomeReportViewModel;
            Banks = new ObservableCollection<BankViewModel>();

        }

        #region Properties

        public ICollection<BankViewModel> Banks { get; private set; }

        #endregion

        #region Methods

        protected override void OnInitialize()
        {
            DisplayName = "Income";
            ActivateItem(_incomeReportViewModel);

            var bankViewModel = new BankViewModel()
                       {
                           Name = "Cock Muncher"
                       };

            bankViewModel.BankModel = new Bank
            {
                Name = "Cock Muncher",
                Balance = 10000000000
            };

            bankViewModel.AccountStubs.Add(new AccountViewModel
            {
                Name = "Account 1",
                Balance = 1000,
                Currency = "CAD",
                MaturityDate = DateTime.Now
            });

            bankViewModel.AccountStubs.Add(new AccountViewModel
            {
                Name = "Account 2",
                Balance = 1500,
                Currency = "US",
                MaturityDate = DateTime.Now
                
            });

            Banks.Add(bankViewModel);
        }

        public void ViewDetails(object item)
        {
            ActivateItem(item);
        }

        #endregion

        #region Implementation of IHandle<in AccountViewModel>

        /// <summary>
        /// Handles the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Handle(AccountViewModel message)
        {
            ActivateItem(message);
        }

        #endregion
    }
}