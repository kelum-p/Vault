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
            Banks = new BindableCollection<BankViewModel>();

        }

        #region Properties

        public ICollection<BankViewModel> Banks { get; private set; }

        #endregion

        #region Methods

        protected override void OnInitialize()
        {
            DisplayName = "Income";

            var bankViewModel = new BankViewModel()
                       {
                           Name = "Cock Muncher"
                       };

            bankViewModel.BankModel = new Bank
            {
                Name = "Cock Muncher",
                Balance = 10000000000
            };


            var account1 = new AccountViewModel
                           {
                               Name = "Account 1",
                               Balance = 1000,
                               Currency = "CAD",
                               MaturityDate = DateTime.Now
                           };

            account1.EntryStubs.Add(new EntryStubViewModel
                                    {
                                        Date = DateTime.Now,
                                        Amount = 500
                                    });

            bankViewModel.AccountStubs.Add(account1);


            var account2 = new AccountViewModel
                           {
                               Name = "Account 2",
                               Balance = 1500,
                               Currency = "US",
                               MaturityDate = DateTime.Now
                           };

            account2.EntryStubs.Add(new EntryStubViewModel
            {
                Date = DateTime.Now,
                Amount = 100000000
            });

            bankViewModel.AccountStubs.Add(account2);

            Banks.Add(bankViewModel);
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            ActivateItem(_incomeReportViewModel);
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