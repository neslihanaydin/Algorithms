using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeslihanTurpcu300359919
{
    public class Matinee:Seats
    {
        public int row, column;
        public string[,] matineeArray = new string[1, 6];
        
        public Matinee() //The first row of the seat plan (row 1, Columns A to F) are considered matinee
        {
            base.price = 20; //Their ticket price is 20 dollars per seat.
            for (int i = 0; i < matineeArray.GetLength(0); i++)
            {
                for(int j=0; j < matineeArray.GetLength(1); j++)
                {
                    matineeArray[i, j] = "E";
                }
            }
        }
        
        public void reservedSeat(int row, int column)
        {
            matineeArray[row, column] = "X"; //
        }

        public int getReservedSeatCount() //The matinee class should be able to count the number of matinee seats
        {
            int counter = 0;
            for (int i = 0; i < matineeArray.GetLength(0); i++)
            {
                for (int j = 0; j < matineeArray.GetLength(1); j++)
                {
                    if(matineeArray[i, j] == "X")
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        public int calculatePrice() // compute the total matinee seats purchased
        {
            int countReservedSeat = getReservedSeatCount();
            return countReservedSeat * price;
        }
    }
}
