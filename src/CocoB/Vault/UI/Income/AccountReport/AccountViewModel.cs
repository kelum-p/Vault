/*
 * AccountViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/19/2011 12:06:00 PM
 *
 */

using System;
using System.Collections.Generic;
using Caliburn.Micro;

namespace CocoB.Vault.UI.Income.AccountReport
{
    public class AccountViewModel : FinancialViewModel
    {
        #region Member Variables

        #endregion

        #region Constructors

        public AccountViewModel()
        {
            EntryStubs = new BindableCollection<EntryStubViewModel>();
        }

        #endregion

        #region Properties

        public DateTime MaturityDate { get; set; }

        public ICollection<EntryStubViewModel> EntryStubs { get; private set; }

        #endregion

        #region Methods

        #endregion
    }
}