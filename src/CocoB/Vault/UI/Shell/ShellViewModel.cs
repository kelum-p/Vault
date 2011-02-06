/*
 * ShellViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/5/2011 9:36:00 PM
 *
 */

using System.ComponentModel.Composition;
using Caliburn.Micro;
using CocoB.Vault.UI.ExchangeRates;
using CocoB.Vault.UI.Framework;
using CocoB.Vault.UI.Income;

namespace CocoB.Vault.UI.Shell
{
    [Export(typeof (IShell))]
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IShell
    {
        protected override void OnInitialize()
        {
            var incomeTab = new IncomeViewModel();
            var exchangeRateTab = new ExchangeRatesViewModel();

            incomeTab.DisplayName = "Income";
            exchangeRateTab.DisplayName = "Exchange Rates";

            Items.Add(incomeTab);
            Items.Add(exchangeRateTab);
        }
    }
}