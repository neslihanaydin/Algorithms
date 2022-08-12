using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeslihanTurpcu300359919
{
    public class Regular:Seats
    {
        public int row, column;
        public string[,] regularArray = new string[4, 6];
        public Regular() //All the other seats besides the matinee are considered regular.
        {
            base.price = 10;//The ticket price for regular is 10 dollars per seat
            for (int i = 0; i < regularArray.GetLength(0); i++)
            {
                for (int j = 0; j < regularArray.GetLength(1); j++)
                {
                    regularArray[i, j] = "E";
                }
            }

        }

        public void reservedSeat(int row, int column)
        {
            regularArray[row - 1, column] = "X";
        }

        public int getReservedSeatCount() //The regular class should be able to count the number of regular seats 
        {
            int counter = 0;
            for (int i = 0; i < regularArray.GetLength(0); i++)
            {
                for (int j = 0; j < regularArray.GetLength(1); j++)
                {
                    if (regularArray[i, j] == "X")
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public int calculatePrice() //compute the total regular seats purchased.
        {
            int countReservedSeat = getReservedSeatCount();
            return countReservedSeat * price;
        }
    }
}
