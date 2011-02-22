/*
 * AccountViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/19/2011 12:06:00 PM
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace CocoB.Vault.UI.Income.AccountReport
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Export(typeof (AccountViewModel))]
    [Export(typeof (FinancialViewModel))]
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

        public bool CanRemoveEntry
        {
            get { return false; }
        }

        public bool CanEditEntry
        {
            get { return false; }
        }

        #endregion

        #region Methods

        public void AddEntry()
        {
        }

        public void RemoveEntry()
        {
        }

        public void EditEntry()
        {
        }

        #endregion
    }
}