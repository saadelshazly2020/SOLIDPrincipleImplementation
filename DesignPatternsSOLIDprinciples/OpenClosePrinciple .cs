using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSOLIDprinciples
{
    /// <summary>
    /// Software entities (classes, modules, functions, etc.) should be open for extension,
    /// but closed for modification.
    /// implementation of bank account savings like regular saving and salary saving, etc...
    /// there are different rules for each customer
    /// </summary>


    //wrong implementation, add many savings types in the same function implementation so if there 
    // new customer rule this function will be modified

    public class Account
    {
        public decimal Interest { get; set; } // فوائد
        public decimal Balance { get; set; }
        // members and function declaration
        public decimal CalcInterest(string accType)
        {
            if (accType == "Regular")
            {
                Interest = (Balance * 4) / 100;
                if (Balance < 1000) Interest -= (Balance * 2) / 100;
                if (Balance < 50000) Interest += (Balance * 4) / 100;
            }
            else if (accType == "Salary") // salary savings
            {
                Interest = (Balance * 5) / 100;
            }
            else if (accType == "Corporate") // Corporate
            {
                Interest = (Balance * 3) / 100;
            }
            return Interest;

        }

    }

    //correct implementation by create new class with each saving type 
    public interface IRightAccount
    {
        decimal Balance { get; set; }
        decimal CalcInterest();

    }
    public class RegularRightAccount : IRightAccount
    {
        public decimal Balance { get; set; }

        public decimal CalcInterest()
        {
            decimal Interest = (Balance * 4) / 100;
            if (Balance < 1000) Interest -= (Balance * 2) / 100;
            if (Balance < 50000) Interest += (Balance * 4) / 100;
            return Interest;
        }
    }
    public class SalaryRightAccount : IRightAccount
    {
        public decimal Balance { get; set; }
        public decimal CalcInterest()
        {
          
            decimal Interest = (Balance * 5) / 100;
            return Interest;
        }
    }
    public class CorporateRightAccount : IRightAccount
    {
        public decimal Balance { get; set; }

        public decimal CalcInterest()
        {

            decimal Interest = (Balance * 3) / 100;
            return Interest;
        }
    }



}
