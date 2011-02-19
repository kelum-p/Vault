/*
 * IncomeReportViewModel.cs
 * 
 * Author: Kelum Peiris (kelum.peiris@polarmobile.com)
 * Date: 2/13/2011 8:25:27 PM
 *
 */

using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace CocoB.Vault.UI.Income.IncomeReport
{
    [Export(typeof(IncomeReportViewModel))]
    public class IncomeReportViewModel : Screen
    {
        #region Member Variables

        #endregion

        #region Constructors

        #endregion

        #region Properties

        public string Total { get; set; }

        #endregion

        #region Methods

        protected override void OnInitialize()
        {
            base.OnInitialize();
            Total = "1,000,000";
        }

        #endregion
    }
}