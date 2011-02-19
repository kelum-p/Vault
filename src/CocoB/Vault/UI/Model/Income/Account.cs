/*
 * Account.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/13/2011 9:27:55 PM
 *
 */

using System;

namespace CocoB.Vault.UI.Model.Income
{
    public class Account : IVaultEntity
    {
        #region Member Variables

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public string Name { get; set; }

        #endregion

        #region Methods

        #endregion

        #region Implementation of IVaultEntity

        public object CreateViewModel()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}