using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    /*Create a class named TaxPayer. 
         * Data fileds; social security number, yearly gross income, and the tax owed.
         * include a prop with get and set acessors for the first two data fields
         *tax owed should be read only. tax should be calculated whenever the income is set.
         *Assume the tax is 15% of income for incomes under 30.000, and 28% for 30.000 or higher.
         *Write a program that declares an array of ten taxpayer objects. promt the user for data for each object and display
         *10 objects.
         */
    internal class TaxPayer
    {
        public int socialNumber;
        public double yearlyGross;
        public double taxOwed;

        public int SocialNumber
        {
            get
            {
                return socialNumber;
            }
            set
            {
                socialNumber = value;
            }
        }


        public double YearlyGross
        {
            get
            {
                return yearlyGross;
            }
            set
            {
                yearlyGross = value;
                TaxCalculator();
            }

        }
        public double Taxowed 
        { get
            {
                return taxOwed;
            } 
        }
        private void TaxCalculator()
        {
            if (yearlyGross < 30000)
            {
                taxOwed = yearlyGross * .15;
            }
            else 
            {
                taxOwed = yearlyGross * .28;
            }
        }
    }
}
