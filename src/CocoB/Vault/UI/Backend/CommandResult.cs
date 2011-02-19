/*
 * CommandResult.cs
 *
 * Code from the Build Your Own MVVM talk by Rob Eisenberg at MIX10 conference.
 * Ref: http://devlicio.us/blogs/rob_eisenberg/archive/2010/03/16/build-your-own-mvvm-framework-is-online.aspx
 * 
 * Adopted to Sphinx platform by
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 12/11/2010 6:57:10 PM
 *
 */

using System;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using CocoB.Vault.UI.Framework;

namespace CocoB.Vault.UI.Backend
{
    public class CommandResult : IResult
    {
        #region Member Variables

        private readonly ICommand _command;

        [Import(typeof(IBackend))]
        private IBackend _backend;

        #endregion

        #region Constructors

        public CommandResult(ICommand command)
        {
            _command = command;
        }

        #endregion

        #region Implementation of IResult

        public void Execute(ActionExecutionContext context)
        {
           _backend.Send(_command);
            Completed(this, new ResultCompletionEventArgs());
        }

        public event EventHandler<ResultCompletionEventArgs> Completed = delegate { };

        #endregion
    }
}