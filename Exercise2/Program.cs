namespace Exercise2
{
    internal class Program
    {
        /*Create a class named TaxPayer. 
         * Data fileds; social security number, yearly gross income, and the tax owed.
         * include a prop with get and set acessors for the first two data fields
         *tax owed should be read only. tax should be calculated whenever the income is set.
         *Assume the tax is 15% of income for incomes under 30.000, and 28% for 30.000 or higher.
         *Write a program that declares an array of ten taxpayer objects. promt the user for data for each object and display
         *10 objects.
         */
        static void Main(string[] args)
        {
            TaxPayer[] payers = new TaxPayer[3];
            for (int i = 0; i < payers.Length; i++)
            {
                payers[i] = new TaxPayer();
                Console.WriteLine($"Enter payer #{i + 1} Social security number");
                payers[i].socialNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter payer #{i + 1} Yearly income");
                payers[i].YearlyGross = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < payers.Length; i++)
            {
                Console.WriteLine($"Tax Payer #{i+1} SSN: {payers[i].SocialNumber} , Income: {payers[i].YearlyGross}, Tax Owed:{payers[i].Taxowed}");
            }
        }
    }
}