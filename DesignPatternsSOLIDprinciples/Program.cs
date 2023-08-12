using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSOLIDprinciples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(new CorporateRightAccount());
           decimal interest= bankAccount.CreateAccount(50000);
            Console.WriteLine(interest);
            Triangle triangle = new Circle();
            Console.WriteLine(triangle.GetShape());

            Console.ReadLine();
        }
       
    }
    public class BankAccount
    {
        IRightAccount _account;
        public decimal Balance { get; set; }
        public BankAccount(IRightAccount account)
        {
            _account = account;

        }
        public decimal CreateAccount(decimal balance)
        {
            _account.Balance = balance;
           return _account.CalcInterest();
        }
    }
}
