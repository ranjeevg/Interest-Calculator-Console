using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interest_Calculator_Console.Models
{
    public class LoanInformation
    {
        #region Principal
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

        #region APR
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

        #region Loan term represented as compounding periods
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

        #region Is this loan compounded? (Assuming yes by default)
        private bool? isCompounded;

        public bool? getIsCompounded()
        {
            return isCompounded;
        }

        public void SetIsCompounded(bool? Boole)
        {
            if (Boole is null)
            {
                isCompounded = true;
                return;
            }
            isCompounded = Boole;
        }
        #endregion
    }
}
