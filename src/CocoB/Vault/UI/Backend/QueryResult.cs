/*
 * QueryResult.cs
 *
 * Code from the Build Your Own MVVM talk by Rob Eisenberg at MIX10 conference.
 * Ref: http://devlicio.us/blogs/rob_eisenberg/archive/2010/03/16/build-your-own-mvvm-framework-is-online.aspx
 * 
 * Adopted to Sphinx platform:
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
    public class QueryResult<TResponse> : IResult
    {
        #region Member Variables

        private readonly IQuery<TResponse> _query;

        [Import(typeof(IBackend))]
        private IBackend _backend;

        #endregion

        #region Constructors

        public QueryResult(IQuery<TResponse> query)
        {
            _query = query;
        }

        #endregion

        #region Properties

        public TResponse Response { get; set; }

        #endregion

        #region Implementation of IResult

        public void Execute(ActionExecutionContext context)
        {
            _backend.Send(_query, response =>
                                                 {
                                                     Response = response;
                                                     Completed(this, new ResultCompletionEventArgs());
                                                 });
        }

        public event EventHandler<ResultCompletionEventArgs> Completed = delegate { };

        #endregion
    }
}