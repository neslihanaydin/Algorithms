using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NeslihanTurpcuWeek3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            guessGameChallenge();
        }

        public static void guessGameChallenge()
        {
            int guess;
            int num;
            Boolean flag = true;
            string inp;
            int guessTime = 0;
            int playAgain = 1;

            //generate the random numbers
            
            while(playAgain == 1)
            {
                Random r = new Random();
                num = r.Next(1, 10);
                guessTime = 0;
                while (flag && guessTime < 3)
                {
                        
                    guessTime++;
                    WriteLine("Enter your guess: ");

                    inp = ReadLine();

                    while (!int.TryParse(inp, out guess))
                    {
                        WriteLine("Invalid entry try again :");
                        inp = ReadLine();
                    }
                    if (guess > num)
                    {
                        WriteLine("Your guess is so high, aim lower");
                    }
                    else if (guess < num)
                    {
                        WriteLine("Your guess is so low, aim higher");
                    }
                    else
                    {
                        WriteLine("Congratulations! You win!");
                        WriteLine("The number is generated " + num);
                        flag = false;
                    }
                    

                }
                if(guessTime == 3)
                    {
                        WriteLine("You failed. The number was : {0}. If you would you like to play again press 1.", num);
                        while (int.TryParse(ReadLine(), out playAgain) == false)
                        {
                            WriteLine("Invalid value.");
                            WriteLine("If you would you like to play again press 1.", num);
                        }
                    }
                               
            }
            ReadKey();
        }

        public static void guessGame()
        {
            int guess;
            int num;
            Boolean flag = true;
            string inp;

            //generate the random numbers
            Random r = new Random();
            num = r.Next(1, 10);

            while (flag)
            {
                WriteLine("Enter your guess: ");

                inp = ReadLine();

                while (!int.TryParse(inp, out guess))
                {
                    WriteLine("Invalid entry' try again :");
                    inp = ReadLine();
                }

                if (guess > num)
                {
                    WriteLine("Your guess is so high, aim lower");
                } else if (guess < num)
                {
                    WriteLine("Your guess is so low, aim higher");

                } else
                {
                    WriteLine("Congratulations! You win!");
                    WriteLine("The number is generated {0}", num);
                    flag = false;
                }

            }

            ReadKey();

            
        }

        
    }
}
