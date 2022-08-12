using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NeslihanTurpcu300359919
{

    public class Mainapp:thank_you
    {
        Matinee matinee = new Matinee();
        Regular regular = new Regular();
        Seats seats = new Seats();

        int row, column;

        public int getRowFromUser()
        {
            bool loopCheck = true;
            while (loopCheck)
            {
                WriteLine("Enter the row number using numbers from 1 to 5");
                try
                {
                    row = int.Parse(Console.ReadLine()) - 1; // -1 because it's related to the array index, so we need to decrease 
                    if (row < 0 || row > 4)
                    {
                        throw new IndexOutOfRangeException(); //If the user enters number which is not 1 to 5 then it throws an IndexOutOfRangeException
                    }
                    else
                    {
                        loopCheck = false;
                    }
                }
                catch (IndexOutOfRangeException e1)
                {

                    WriteLine("You should only enter numbers 1 to 5");
                    loopCheck = true; //It will be true because there is an exception, the program must ask again

                }
                catch (FormatException e2)
                {
                    WriteLine("You must enter a number");
                    loopCheck = true; //It will be true because there is an exception, the program must ask again

                }
                catch (Exception e3)
                {
                    WriteLine(e3);
                    loopCheck = true; //It will be true because there is an exception, the program must ask again

                }

            }
            return row;
        }


        public int getColumnFromUser()
        {
            bool loopCheck = true;
            while (loopCheck)
            {
                WriteLine("Enter the column letter using numbers from A to F");
                try
                {
                    column = convertColumnToInt(Console.ReadLine());
                    if (column == 6)
                    {
                        WriteLine("Please enter an invalid value.");
                    }
                    else
                    {
                        loopCheck = false;

                    }
                }
                catch (Exception e3)
                {
                    WriteLine(e3.Message);
                    loopCheck = true; //It will be true because there is an exception, the program must ask again

                }

            }
            return column;
        }

        public void startForReservation()
        {
            seats.displaySeatArray();
            seats.matinee = matinee;
            seats.regular = regular;    
            char answerForReserveCycle = 'Y';
            //Accept entry of row and column form the user and pass these values to the respective classes.
            while (answerForReserveCycle == 'Y')
            {
                row = getRowFromUser();
                column = getColumnFromUser();
                
                try
                {
                    seats.updateSeatArray(row, column);
                }
                catch (MyException e)
                {
                    WriteLine(e.Message);
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                    break;
                }

                answerForReserveCycle = checkReserveCycle(answerForReserveCycle); //Ask the user for reserving more seats.

            }

        }

        public char checkReserveCycle(char answerForReserveCycle)
        {
            while (true)
            {
                Write("Do you want to reserve more seats [Y/N] ?");
                if (char.TryParse(ReadLine(), out answerForReserveCycle))
                {
                    if (answerForReserveCycle == 'N' || answerForReserveCycle == 'n')
                    {
                        answerForReserveCycle = 'N';
                        break;
                        
                    }
                    else if ((answerForReserveCycle == 'Y' || answerForReserveCycle == 'y'))
                    {
                        answerForReserveCycle = 'Y';
                        break;
                        
                    }
                    else 
                    {
                        WriteLine("Invalid entry.");
                    }
                }
            }
            return answerForReserveCycle;


        }
        public int convertColumnToInt(string column)
        {
            int positionColumn = 6;
            switch (column)
            {
                case "A":
                    positionColumn = 0;
                    break;
                case "B":
                    positionColumn = 1;
                    break;
                case "C":
                    positionColumn = 2;
                    break;
                case "D":
                    positionColumn = 3;
                    break;
                case "E":
                    positionColumn = 4;
                    break;
                case "F":
                    positionColumn = 5;
                    break;
                case "a":
                    positionColumn = 0;
                    break;
                case "b":
                    positionColumn = 1;
                    break;
                case "c":
                    positionColumn = 2;
                    break;
                case "d":
                    positionColumn = 3;
                    break;
                case "e":
                    positionColumn = 4;
                    break;
                case "f":
                    positionColumn = 5;
                    break;
                default:
                    positionColumn = 6;
                    break;

            }
            
            return positionColumn;
        }

        public void display() //Implement the thank you class.
        {
            WriteLine("\n\n");
            string text = "";
            for (int i = 0; i < 9; i++)
            {

                WriteLine(text + "Thank you");
                if (i < 4)
                {
                    text = text + "Thank you";
                }
                else if (i < 8 )
                {
                    text = text.Remove(text.Length - 9);
                }

            }
        }
    }
}
