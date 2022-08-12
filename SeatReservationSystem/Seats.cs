using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NeslihanTurpcu300359919
{
    public class Seats
    {
        public string[,] seatArray = new string[5, 6];

        public Matinee matinee; 
        public Regular regular;
        protected int price;
        public Seats() //It initializes the seatArray with E values, in the constructor.
        {
            for(int i=0; i<seatArray.GetLength(0); i++)
            {
                for(int j=0; j<seatArray.GetLength(1); j++)
                {
                    this.seatArray[i, j] = "E";
                }
            }
            
        }

        
        
        public void displaySeatArray() //Display the initial array.
        {
            WriteLine("\t*****Seat Reservation System*****");
            WriteLine("*******************************************************\n");

            Write("\tA\tB\tC\tD\tE\tF\n");
            for (int i = 0; i < seatArray.GetLength(0); i++)
            {
                
                Write(i+1);
                for (int j = 0; j < seatArray.GetLength(1); j++)
                {
                    Write("\t"+this.seatArray[i, j]);
                }
                WriteLine();
            }
            WriteLine();
            

        }

        public void updateSeatArray(int row, int column) //Marks the X for seats reserved by type. If row == 0 this means matinee seat is chosen.
        {
            if (this.seatArray[row, column] == "E")
            {
                if (row == 0)
                {
                    matinee.reservedSeat(row, column);
                    
                } else
                {
                    regular.reservedSeat(row, column);
                }

                this.seatArray[row, column] = "X";

                displaySeatArray();
                WriteLine("The number of matinee seat\\s purchased is " + matinee.getReservedSeatCount());
                WriteLine("The number of regular seat\\s purchased is " + regular.getReservedSeatCount());

                WriteLine("The total price of the seat\\s are " + (matinee.calculatePrice() + regular.calculatePrice()));

                if (!isAvailableSeat())
                {
                    throw new Exception("All seats are taken. Thank you for your interest.");
                }
            }
            else
            {
                throw new MyException();

            }



        }
        private bool isAvailableSeat() //Check seat statu, if all of the seats are solded thank thankyou to user.
        {
            return (matinee.getReservedSeatCount() + regular.getReservedSeatCount()) < 30;
        }
        
    }
}
