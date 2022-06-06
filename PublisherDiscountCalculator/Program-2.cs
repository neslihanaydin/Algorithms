using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuizPart2NeslihanTurpcu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char customerType; // Book store : B or b, Library : L or l
            int numberOfCopies;
            double unitPrice;
            int checkTransactionCycle = 1; // it will be 0, if the user does not want to enter another product
            char inputForTransaction; // it effects the checkTransactionCycle according to user's answer
            double discount; // It shows the sum of the discount amount
            double sumOfPricesWithDiscount = 0; // It shows the sum of prices - discount amount
            double sumOfPricesWithoutDiscount = 0; // It shows the sum of prices without any discount.
                                                   // I did not user this variable at anywhere. I still calculated

            WriteLine("Welcome.");
            getCustomerType(out customerType); // It changes the customerType variable

            while (checkTransactionCycle == 1) // Take the numberOfCopies and unitPrice cycle.
                                               // if the user does not want to enter another product,
                                               // it's going to be 0 according to user's answer (y or n)
            {
                getValues(out numberOfCopies, out unitPrice);
                discount = CalculateSumDiscount(customerType, numberOfCopies, unitPrice);
                var text = string.Format("{0:0.00}", discount);
                WriteLine("Total Discount amount is: "+ text);
                sumOfPricesWithoutDiscount = sumOfPricesWithoutDiscount + (unitPrice * numberOfCopies);
                sumOfPricesWithDiscount = sumOfPricesWithDiscount + ((unitPrice * numberOfCopies) - discount);
                text = string.Format("{0:0.00}", sumOfPricesWithDiscount);
                WriteLine("Total Bill amount is: " + text);

                WriteLine("Do you want to add some product (y/n) ?");
                if (char.TryParse(ReadLine(), out inputForTransaction))
                {
                    if (inputForTransaction == 'y' || inputForTransaction == 'Y' )
                    {
                        checkTransactionCycle = 1;
                    }
                    else if ( inputForTransaction == 'n' || inputForTransaction == 'N')
                    {
                        checkTransactionCycle = 0;
                    }
                    else
                    {
                        WriteLine("Invalid value.");
                    }
                }

            }

            ReadKey();

        }

        public static double CalculateSumDiscount(char customerType, int numberOfCopies, double unitPrice)
        {
            double discount = 0;
            if ((customerType == 'b') || (customerType == 'B'))
            {
                if( numberOfCopies <= 10)
                {
                    discount = unitPrice * 0.15;
                } else if (numberOfCopies > 10) {
                    discount = unitPrice * 0.25;
                }
            }
            if ((customerType == 'l') || (customerType == 'L'))
            {
                if (numberOfCopies <= 5)
                {
                    discount = unitPrice * 0.10;
                }
                else if (numberOfCopies > 5)
                {
                    discount = unitPrice * 0.20;
                }
            }
            return discount * numberOfCopies ;
        }

        public static void getCustomerType(out char customerType)
        {
            customerType = 'b';
            int checkCycle = 1;
            while(checkCycle == 1)
            {
                WriteLine("Please input your customer type.\nBook stores (B or b)\nLibrary (L or l) :");
                
                if (char.TryParse(ReadLine(), out customerType))
                {
                    if (customerType == 'B' || customerType == 'b' || customerType == 'L' || customerType == 'l')
                        checkCycle = 0;
                }
            }
            
        }

        public static void getValues(out int numberOfCopies, out double unitPrice)
        {
            numberOfCopies = 0;
            unitPrice = 0; 
            int checkCycle = 1; // check value for true inputs
            while (checkCycle == 1) 
            {
                WriteLine("Please input the number of copies :");
                if (int.TryParse(ReadLine(), out numberOfCopies))
                {
                   checkCycle = 0;
                }
                
            }
            checkCycle = 1;
            while (checkCycle == 1)
            {
                WriteLine("Please input the unit price :");

                if (double.TryParse(ReadLine(), out unitPrice))
                {
                    checkCycle = 0;
                }
            }

        }
    }
}
