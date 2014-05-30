using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EasyRate
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetMetaInfo();

            SetControl();
        }

        private void SetControl()
        {
            int maxCount = 10;
            this.TodaysInterestRates.CreditCardsTodayInterestRateInfoList = FinanceCommon.BusinessLogic.CreditCardController.GetTodayInterestRate(maxCount);
            this.TodaysInterestRates.SavingsAccountsTodayInterestRateInfoList = FinanceCommon.BusinessLogic.SavingsAccountController.GetTodayInterestRate(maxCount);
            this.TodaysInterestRates.TermDepositsTodayInterestRateInfoList = FinanceCommon.BusinessLogic.TermDepositController.GetTodayInterestRate(maxCount); 
            this.TodaysInterestRates.HomeLoansTodayInterestRateInfoList = FinanceCommon.BusinessLogic.HomeLoanController.GetTodayInterestRate(maxCount);
        }

        private void SetMetaInfo()
        {
            string metaKeywords = "Home Loans, Mortgages, Credit Cards, Savings Accounts, Term Deposits, rate, fee, compare, save";
            string metaDescription = "Compare credit cards, home loans, savings accounts, term deposits and insurance rates, fees and plans in NZ";
            Master.SetMetaKeywordsAndMetaDescription(metaKeywords, metaDescription);
        }
    }
}