/*
 * ExchangeRatesViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/6/2011 12:28:26 AM
 *
 */

using Caliburn.Micro;

namespace CocoB.Vault.UI.ExchangeRates
{
    public class ExchangeRatesViewModel : Screen
    {
        protected override void OnInitialize()
        {
            DisplayName = "Exchange rates";
        }
    }
}