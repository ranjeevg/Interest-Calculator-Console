using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest_Calculator_Console.Loan_Information
{
    public class LoanInformation
    {
        #region Principal
        private double principal;

        public double GetPrincipal()
        {
            return principal;
        }

        public void SetPrincipal(double value)
        {
            principal = value;
        }
        #endregion

        #region APR
        private double aPR;

        public double GetAPR()
        {
            return aPR;
        }

        public void SetAPR(double value)
        {
            aPR = value;
        }
        #endregion

        #region Compounding frequency

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

        #region Loan term in years
        private double loanTermInYears;

        public double GetLoanTermInYears()
        {
            return loanTermInYears;
        }

        public void SetLoanTermInYears(double value)
        {
            loanTermInYears = value;
        }
        #endregion

        #region Loan term represented as compounding periods
        private double loanTermInCompoundingPeriods;

        public double GetLoanTermInCompoundingPeriods()
        {
            return loanTermInCompoundingPeriods;
        }

        public void SetLoanTermInCompoundingPeriods(double value)
        {
            loanTermInCompoundingPeriods = value;
        }
        #endregion
    }
}
