using System;
using static System.Console;

namespace NeslihanTurpcuTaxCalculator
{
    class MainClass
    {
        static float sumTax = 0.0F; // The amount of the total taxes

        public static void Main(string[] args)
        {
            int maritalStatus; // Single : 1, Married : 2
            float income; // User's annual income
            float incomeAfterTaxes; // When taxes calculated, money to be received by the user

            Write("Please choose your marital status\n" +
                "1 - Single\n" +
                "2 - Married\n" +
                "             : ");

            /* There is a sequence between single person and married person. If the user is married, each transaction is twice the value of the single user. */

            // Check the marital status is an Integer value. If it is Integer, check the marital Status is equal 1 or 2.
            // If the user is not enter 1 or 2 or an Integer value, then program is going to else statement.
            if (int.TryParse(ReadLine(), out maritalStatus) && ((maritalStatus == 1 || maritalStatus == 2)))
            {
                // When the user entered a valid value, then the program ask income to user,
                // If the income type is not float, or income is less than equal than zero, program is going to else statement.
                Write("Please enter your income value : ");
                if(float.TryParse(ReadLine(), out income) && income > 0)
                {
                    WriteLine("Income before taxes :{0:c}", income);
                    sumTax = calculateTax(income, maritalStatus); // Jump to calculateTax() method
                    WriteLine("The total taxes :{0:c}", sumTax);
                    incomeAfterTaxes = income - sumTax;
                    WriteLine("Income after taxes :{0:c}", incomeAfterTaxes);
                }
                else
                {
                    WriteLine("Invalid value. Program is terminated.");
                }

            }
            else
            {
                WriteLine("Invalid value. Program is terminated.");
            }

            ReadKey();


        }

        /* CalculateTax method()
         * input parameters are; float income, int maritalStatus
         * output return parameter is : float sumTax
          

           As seen there is an order between the two situations.
           I made a transaction according to marital status.

        if statement :
            //For single : If income is less than or equal to 8000, the tax is 10% of the income
            //For married : If the income is less than or equal to 16000, the tax is 10% of the income.

        else if stament :
            //For single : Within range of more than 8000 up to 32000 the tax is 800 plus 15% of the income over than 8000.
            //Within the range of more than 16000 up to 64000 the tax is 1600 plus 15 % of the amount greater than 16000.

        else statement :
            //Single : If it is more than 32000 the tax is 4400 plus 25% of the income over than 32000
            //Married : If it is more than 64000, the tax is 8800 plus 25% of the amount over than 64000

         */

        public static float calculateTax(float income, int maritalStatus)
        {
           
            if (income <= (8000 * maritalStatus)) 
            {
                sumTax = (float)(income * 0.1);
            }
            else if (income > (8000 * maritalStatus) && income <= (32000 * maritalStatus))
            {
                sumTax = (float)((800 * maritalStatus) + ((income - (8000 * maritalStatus)) * 0.15));
            }
            else
            {
                sumTax = (float)((4400 * maritalStatus) + ((income - (32000 * maritalStatus)) * 0.25));
            }

            return sumTax;
        }

        
    }

}
