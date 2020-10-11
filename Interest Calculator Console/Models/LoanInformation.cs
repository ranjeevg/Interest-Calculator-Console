using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest_Calculator_Console.Models
{
    public class LoanInformation
    {
        #region 01. Principal
        private decimal principal;

        public decimal GetPrincipal()
        {
            return principal;
        }

        public void SetPrincipal(decimal value)
        {
            principal = value;
        }
        #endregion

        #region 02. APR
        private decimal aPR;

        public decimal GetAPR()
        {
            return aPR;
        }

        public void SetAPR(decimal value)
        {
            aPR = value;
        }
        #endregion

        #region 03. Compounding frequency

        private int annualCompoundingFrequency;

        public int GetAnnualCompoundingFrequency()
        {
            return annualCompoundingFrequency;
        }

        public void SetAnnualCompoundingFrequency(int value)
        {
            annualCompoundingFrequency = value;
        }
        #endregion

        #region 04. Loan term in years
        private decimal loanTermInYears;

        public decimal GetLoanTermInYears()
        {
            return loanTermInYears;
        }

        public void SetLoanTermInYears(decimal value)
        {
            loanTermInYears = value;
        }
        #endregion

        #region 05. Loan term represented as compounding periods
        private decimal loanTermInCompoundingPeriods;

        public decimal GetLoanTermInCompoundingPeriods()
        {
            return loanTermInCompoundingPeriods;
        }

        public void SetLoanTermInCompoundingPeriods(decimal value)
        {
            loanTermInCompoundingPeriods = value;
        }
        #endregion

        #region 06. Number of months paid
        private int numberOfMonthsPaid;

        public int GetNumberOfMonthsPaid()
        {
            return numberOfMonthsPaid;
        }

        public void SetNumberOfMonthsPaid (int value)
        {
            numberOfMonthsPaid = value;
        }
        #endregion

        #region 07. Outstanding balance
        private decimal outstandingBalance;

        public decimal GetOutstandingBalance()
        {
            return outstandingBalance;
        }

        public void SetOutstandingBalance(decimal value)
        {
            outstandingBalance = value;
        }
        #endregion
    }
}
