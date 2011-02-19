/*
 * ShellViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/5/2011 9:36:00 PM
 *
 */

using System.ComponentModel.Composition;
using System.Linq;
using Caliburn.Micro;
using CocoB.Vault.UI.ExchangeRates;
using CocoB.Vault.UI.Framework;
using CocoB.Vault.UI.Income;
using CocoB.Vault.UI.Income.IncomeReport;

namespace CocoB.Vault.UI.Shell
{
    [Export(typeof (IShell))]
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive, IShell
    {

        #region Constructor

        [ImportingConstructor]
        public ShellViewModel(IncomeViewModel incomeViewModel, ExchangeRatesViewModel exchangeRatesViewModel)
        {
            incomeViewModel.DisplayName = "Income";
            exchangeRatesViewModel.DisplayName = "Exchange Rates";

            Items.Add(incomeViewModel);
            Items.Add(exchangeRatesViewModel);
        }

        #endregion

        protected override void OnInitialize()
        {
            DisplayName = "Vault";
            ActivateItem(Items.FirstOrDefault());
            
        }
    }
}