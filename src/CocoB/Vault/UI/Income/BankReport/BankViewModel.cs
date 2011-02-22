/*
 * BankViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/17/2011 12:30:32 AM
 *
 */

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using CocoB.Vault.UI.Income.AccountReport;
using CocoB.Vault.UI.Model.Income;

namespace CocoB.Vault.UI.Income.BankReport
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Export(typeof(BankViewModel))]
    [Export(typeof(FinancialViewModel))]
    public class BankViewModel : FinancialViewModel
    {
        

        #region Variables

        private readonly IWindowManager _windowManager;
        private AccountViewModel _currentAccountViewModel;

        #endregion

        #region Constructors

        [ImportingConstructor]
        public BankViewModel(IWindowManager windowManager)
        {
            _windowManager = windowManager;
            AccountStubs = new BindableCollection<AccountViewModel>();

            Currencies = new[] { "CAD", "US" };
        }

        #endregion

        #region Properties

        public Bank BankModel { get; set; }

        public ICollection<AccountViewModel> AccountStubs { get; private set; }

        public string[] Currencies { get; set; }

        public AccountViewModel CurrentAccounStub
        {
            get { return _currentAccountViewModel; }

            set
            {
                _currentAccountViewModel = value;
                NotifyOfPropertyChange(()=>CanRemoveAccount);
                NotifyOfPropertyChange(() => CanEditAccount);
            }
        }

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

        public void AddAccount()
        {
           _windowManager.ShowWindow(IoC.Get<AddAccountViewModel>());
        }

        public bool CanRemoveAccount
        {
            get { return CurrentAccounStub != null; }
        }

        public void RemoveAccount()
        {
            AccountStubs.Remove(CurrentAccounStub);
        }

        public bool CanEditAccount
        {
            get { return CurrentAccounStub != null; }
        }

        public void EditAccount()
        {
            
        }

        #endregion
    }
}