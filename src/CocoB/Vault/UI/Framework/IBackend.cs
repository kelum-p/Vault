/*
 * IBackend.cs
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
using CocoB.Vault.UI.Backend;

namespace CocoB.Vault.UI.Framework
{
    public interface IBackend
    {
        void Send(ICommand command);
        void Send<TResponse>(IQuery<TResponse> query, Action<TResponse> reply);
    }
}