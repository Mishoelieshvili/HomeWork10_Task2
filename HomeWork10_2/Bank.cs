using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_2
{
    public class Bank : FinanceOperations
    {
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            double maxAmount = AmountPerMonth * month;
            double interest = maxAmount * 0.05;
            return maxAmount + interest;
        }

        public bool CheckUserHistory()
        {
            Random random = new Random();
            return random.Next(2) == 1;
        }
    }
}
