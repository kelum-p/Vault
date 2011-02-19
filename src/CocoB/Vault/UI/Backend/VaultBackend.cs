/*
 * VaultBackend.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/10/2011 11:40:01 PM
 *
 */

using System;
using CocoB.Vault.UI.Framework;

namespace CocoB.Vault.UI.Backend
{
    public class VaultBackend : IBackend
    {
        #region Member Variables

        #endregion

        #region Constructors

        #endregion

        #region Properties

        #endregion

        #region Methods

        #endregion

        #region Implementation of IBackend

        public void Send(ICommand command)
        {
            throw new NotImplementedException();
        }

        public void Send<TResponse>(IQuery<TResponse> query, Action<TResponse> reply)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}