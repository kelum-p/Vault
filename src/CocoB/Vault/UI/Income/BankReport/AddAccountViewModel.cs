/*
 * AddAccountViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/21/2011 8:24:33 PM
 *
 */

using System;
using System.ComponentModel.Composition;
using System.Windows;
using Caliburn.Micro;

namespace CocoB.Vault.UI.Income.BankReport
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Export(typeof(AddAccountViewModel))]
    public class AddAccountViewModel : Screen
    {
        #region Member Variables

        private string _name;

        private bool _isInvestment;

        #endregion

        #region Constructors

        public AddAccountViewModel()
        {
            IsCalVisible = Visibility.Hidden;
        }

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }

            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanAddAccount);
            }
        }

        public bool IsInvestment
        {
            get { return _isInvestment; }

            set
            {
                _isInvestment = value;
                NotifyOfPropertyChange(() => IsInvestment);
                NotifyOfPropertyChange(() => CanShowCalendar);

            }
        }

        public Visibility IsCalVisible { get; set; }

        public DateTime MaturityDate { get; set; }

        public string MaturityDateStr { get; set; }

        public bool CanShowCalendar
        {
            get { return IsInvestment; }
        }

        public bool CanAddAccount
        {
            get { return true; }

        }

        #endregion

        #region Methods

        public void AddAccount()
        {

        }

        public void ShowCalendar()
        {
            IsCalVisible = Visibility.Visible;
            NotifyOfPropertyChange(() => IsCalVisible);
        }

        public void MaturityDateSelected()
        {
            if (DateTime.Compare(MaturityDate, DateTime.MinValue) != 0)
            {
                IsCalVisible = Visibility.Hidden;
                NotifyOfPropertyChange(() => IsCalVisible);
                MaturityDateStr = MaturityDate.ToShortDateString();
                NotifyOfPropertyChange(() => MaturityDateStr);
                MaturityDate = DateTime.MinValue;
                NotifyOfPropertyChange(() => MaturityDate);
            }
        }


        #endregion
    }
}