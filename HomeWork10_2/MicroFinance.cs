using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_2
{
    public class MicroFinance : FinanceOperations
    {
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            double maxAmount = AmountPerMonth * month;
            double commission = maxAmount * 0.1;
            double totalFee = commission + (4 * month);
            return maxAmount - totalFee;
        }

        public bool CheckUserHistory()
        {
            return true;
        }
    }
}
