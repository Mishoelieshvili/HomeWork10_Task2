using HomeWork10_2;
using System;

namespace HomeWork10_2
{
    public interface FinanceOperations
    {
        double CalculateLoanPercent(int month, double AmountPerMonth);
        bool CheckUserHistory();
    }
}
class Program
{
    static void Main(string[] args)
    {
        FinanceOperations bank = new Bank();
        if (bank.CheckUserHistory())
        {
            double loanAmount = bank.CalculateLoanPercent(12, 1000);
            Console.WriteLine("Bank loan amount: " + loanAmount);
        }
        else
        {
            Console.WriteLine("Bank loan application rejected.");
        }

        FinanceOperations microFinance = new MicroFinance();
        double maxLoanAmount = microFinance.CalculateLoanPercent(12, 1000);
        Console.WriteLine("Microfinance maximum loan amount: " + maxLoanAmount);

        Console.ReadLine();
    }
}