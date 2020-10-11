using System;

namespace Interest_Calculator_Console.Models
{
    public class LoanCalculations
    {
        public decimal CalculateMonthlyPayments
            (decimal Principal, decimal Rate, int NumberOfCompoundingPeriods)
        {
            decimal MonthlyPayment;

            // source for the formula: https://www.wallstreetmojo.com/mortgage-formula/
            decimal ExponentiatedBit = (decimal) Math.Pow((double)(1 + Rate), NumberOfCompoundingPeriods);
            MonthlyPayment = Principal * Rate * ExponentiatedBit / (ExponentiatedBit - 1);

            return MonthlyPayment;
        }

        public decimal CalculateOutstandingBalance
            (decimal Principal, decimal Rate, int NumberOfCompoundingPeriods, int NumberOfMonthsPaid)
        {
            decimal OutstandingBalance;

            // these variables will be used in the formula, defining them here to make the formula easier
            // to read
            decimal ExponentiatedWithN = (decimal)(Math.Pow((double)(1 + Rate), NumberOfCompoundingPeriods));
            decimal ExponentiatedWithM = (decimal)(Math.Pow((double)(1 + Rate), NumberOfMonthsPaid));

            // the actual formula
            // source for the formula: https://www.wallstreetmojo.com/mortgage-formula/
            OutstandingBalance =
                Principal * (ExponentiatedWithN - ExponentiatedWithM) / (ExponentiatedWithN - 1);

            // ... eventually
            return OutstandingBalance;
        }
    }
}
