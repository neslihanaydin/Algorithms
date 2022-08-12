using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _300359919NeslihanTurpcu
{
    internal class Program
    {
        static int[,] availableSeats = new int[5, 6] { { 30, 30, 30, 30, 30, 30},
                                                       { 10, 10, 10, 10, 10, 10 },
                                                       { 10, 10, 10, 10, 10, 10 },
                                                       { 10, 10, 20, 20, 20, 20 },
                                                       { 10, 10, 20, 20, 20, 20 },
                                                     }; // This is a two-dimensional array which holds the available seats.

        static int total = 0; //amount the user has to pay

        static Dictionary<char, int> columnsConvertDictionary = new Dictionary<char, int>()
        {
            {'A',0 }, {'B',1 }, {'C',2 }, {'D',3 }, {'E',4 }, {'F',5 }, {'a',0 }, {'b',1 }, {'c',2 }, {'d',3 }, {'e',4 }, {'f',5 },
        }; // I used a dictionary to hold A,B,C,D,E,F columns to get column corresponding



        static char getInputFromUser()
        {
            char answer;
            while (true)
            {
                Write("Type (S)eat to reserve, P to input a (P)rice, Q to (Q)uit :");    
                answer = ReadLine()[0]; //It takes just first letter of input and then checks conditions
                if (answer == 'q' || answer == 'Q') // if the user enter q or Q that means user wants to stop.
                {
                    return 'q';
                    //choose to quit
                }
                else if(answer == 's' || answer == 'S')
                {
                    return 's';
                    //choose a Seat
                }
                else if(answer == 'p' || answer == 'P')
                {
                    return 'p';
                    //choose a Seat by price
                }
                else
                {
                    WriteLine("********************\nPlease enter a valid value\n********************\n");

                }

            }
        }

        
        static void reserveSeat() //that means user entered S to reserve a seat.
        {
            int answerForRow; // it holds the row value from user
            char answerForColumn; // it holds the column value from user as a char
            int holdSumPrice = 0; // it is a temproray variable for to keep the value in the cell, then it is used to add to the total variable which amount the user has to pay
            while (true)
            {
                Write("Enter the row : (1 to 5) :");
                if (int.TryParse(ReadLine(), out answerForRow) == false)
                {
                    WriteLine("********************\nPlease enter a valid value\n********************\n");
                }
                else if (answerForRow < 1 || answerForRow > 5)
                {
                    WriteLine("********************\nPlease enter a valid range\n********************\n");
                }
                else
                {
                    while (true)
                    {
                        Write("Enter the columnn : (A to F) :");
                        answerForColumn = ReadLine()[0]; //It takes just first letter of input and then checks conditions
                        
                        if(!(columnsConvertDictionary.ContainsKey(answerForColumn))) // if the entered value does not exist as the dictionary value defined above. That means, user entered a lette but it is not in A,B,C,D,E,F,a,b,c,d,e,f
                        {
                            WriteLine("********************\nPlease enter a valid value\n********************\n");
                        }
                        else
                        { // the user entered valid row and column
                            //answerForRow -1, because displayed to the user, starting with 1
                            if (availableSeats[answerForRow -1, columnsConvertDictionary[answerForColumn]] != 0) // If cell in availableSeats array is not 0
                            { //that means, This seat has not been purchased before
                                holdSumPrice = availableSeats[answerForRow - 1, columnsConvertDictionary[answerForColumn]]; // to keep the value in the cell
                                WriteLine("The seat is sold for " + holdSumPrice + " dollars");
                                availableSeats[answerForRow - 1, columnsConvertDictionary[answerForColumn]] = 0; //set related cell to 0
                                total += holdSumPrice; //increase the total
                            }
                            else
                            {//if the cell value is zero, that means the seat is taken before.
                                WriteLine("The seat is taken");
                            }
                            break;
                        }
                    }
                    break ;
                }
            }
        }

       

        static void priceSeat()
        {
            int ticketPriceFromUser; //it holds the amount whic the user has
            int holdSumPrice; // it is a temproray variable for to keep the value in the cell, then it is used to add to the total variable which amount the user has to pay
            bool isThereAvailableSeat = false; // it checks the availability of any seat whic has that price
            while (true)
            {
                Write("Enter the price of the ticket :");
                if (int.TryParse(ReadLine(), out ticketPriceFromUser) == false)
                {
                    WriteLine("********************\nPlease enter a valid value\n********************\n");
                }
                else if (ticketPriceFromUser <= 0)
                {
                    WriteLine("********************\nPlease enter a valid range\n********************\n");
                }
                else
                {
                    for (int i = 0; i < availableSeats.GetLength(0); i++)
                    {
                        for (int j = 0; j < availableSeats.GetLength(1); j++)
                        {
                            if (availableSeats[i,j] == ticketPriceFromUser ) // The first time it sees the equal value, it goes inside the if.
                            {
                                //I used a GetKey() method to check key by value in a dictionary.
                                Write("Your in luck, there is an available seat with that price, the seat is " + (i + 1) +""+ GetKey(columnsConvertDictionary, j));
                                
                                holdSumPrice = availableSeats[i, j]; 
                                availableSeats[i, j] = 0; // it assign 0 because this seat has taken now
                                total += holdSumPrice; // add holdSumPrice to total
                                isThereAvailableSeat = true; // it could find an available seat

                                i = availableSeats.GetLength(0); //to finish the loop
                                j = availableSeats.GetLength(1); //to finish the loop
                            }
                            

                        }
                        
                    }
                    if (!isThereAvailableSeat) // that means it never got inside the above if loop
                    {
                        WriteLine("No more seat with that price");

                    }
                    break;
                }
            }
        }

        static TKey GetKey<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TValue Value)
        {
            List<TKey> KeyList = new List<TKey>(dictionary.Keys);
            foreach (TKey key in KeyList)
                if (dictionary[key].Equals(Value))
                    return key;
            throw new KeyNotFoundException();
        }

        static void showAvailableSeats()
        {
            Write("\n\t\t\tAvailable Seats\n");
            Write(" \tA\tB\tC\tD\tE\tF\n");
            for (int i = 0; i < availableSeats.GetLength(0); i++)
            {
                Write(i + 1);
                for (int j = 0; j < availableSeats.GetLength(1); j++)
                {
                    Write("\t" + availableSeats[i, j]);

                }
                Write("\n");
            }
            WriteLine("Your total is :" + total);
        }

        static void Main(string[] args)
        {
            int cycleCheck = 1; // if the user enter Q or q, then program cycle stops
            char inputForProcess; // it takes input from user such as Reserve : S or s, Price : P or p, Quit : Q or q by getInputFromUser() method.
            while (cycleCheck == 1)
            {
                showAvailableSeats(); // This method shows available seats to user
                inputForProcess = getInputFromUser(); //getInputFromUser() method returns valid inputs in small letter format
                switch (inputForProcess)
                {
                    case 's': // Seat to reserve
                        reserveSeat();
                        break;
                    case 'p': // to input a Price 
                        priceSeat();
                        break;
                    case 'q': // to quit
                        cycleCheck = 0;
                        WriteLine("Thank you for using the app");
                        break;

                }
            }
            
            
            ReadKey();
        }
    }
}
