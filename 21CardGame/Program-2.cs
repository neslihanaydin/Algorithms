using System;
using static System.Console;

namespace CardGame21
{
    class MainClass
    {


        public static void Main(string[] args)
        {
            startGame();
            showThanksForPlaying();
            ReadKey();

        }

        public static void startGame()
        {
            int computerScore = 0; // It holds the computer's move
            int userScore; // sum of the randomUsersMove
            char answerForGame = 'Y'; // control for the user decides to play again (Y:yes)

            Random random = new Random(); //Numbers will be selected with a single random object.
            while (answerForGame == 'y' || answerForGame == 'Y') // loop for game
            {
                userScore = 0;

                if (userGameCycle(ref userScore, random)) //  It's(userScore) going to be as a reference, because I want to change the value(userScore) permanently.
                {
                    computerScore = drawCartForComputer(random); // After the user has finished playing, a card between 1 and 21 is selected for the computer.
                    WriteLine("The Computers Score is " + computerScore);
                }

                calculateScores(computerScore, userScore); // It calculates according to the score of the user and the computer.
                WriteLine("Do you want to play again, Y or N ?");
                answerForGame = ReadLine()[0];
            }
            


        }

        public static void showThanksForPlaying()
        {
            string star = "";
            for(int i=0; i<12; i++)
            {
          
                WriteLine(star + "Thank you for playing");
                if(i < 6)
                {
                    star = star + "*";
                } else
                {
                    star = star.Remove(star.Length-1);
                }

            }
        }

        public static Boolean userGameCycle(ref int userScore, Random random)
        {
            int randomUsersMove = 0;// It holds the user's move. It changes in every step.
            char answerForCard = 'y';// control for the user decides to have another card

            while (answerForCard == 'y' || answerForCard == 'Y') // loop for choose cards
            {
                randomUsersMove = chooseOneCartForUser(random); // selects a card from 1 to 11 for the user.
                WriteLine("The card is " + randomUsersMove);
                userScore = sumCardsForUserScore(userScore, randomUsersMove); //add user's cards(userScore += randomUsersMove)
                WriteLine("Your total is " + userScore);
                if (userScore > 21) // The user can add more cards as he wants but if he goes over than 21, he will automatically lose. Therefor,the cycle return false for the previous if cycle.
                {
                    return false;
                }
                WriteLine("Do you want another card, (y/n) ?");
                answerForCard = ReadLine()[0];
            }
            return true;
            
        }

        //selects a card from 1 to 11 for the user
        public static int chooseOneCartForUser(Random rn)
        {
            int cardNumber = rn.Next(1, 12);
            return cardNumber;
        }

        //selects a card from 1 to 21 for the computer
        public static int drawCartForComputer(Random rn)
        {
            int cardNumber = rn.Next(1, 22);
            return cardNumber;
        }

        public static int sumCardsForUserScore(int userScore, int randomUsersMove)
        {
            userScore = userScore + randomUsersMove;
            return userScore;
        }

        // It calculates according to the score of the user and the computer.
        public static void calculateScores(int computerScore, int userScore)
        {

            if (userScore <= 21 && (computerScore < userScore)) 
            {
                WriteLine("You Win.");
            }
            else if (userScore > 21 || (computerScore > userScore))
            {
                WriteLine("You Lost.");
            }
            else
            {
                WriteLine("It is a tie!");
            }
        }
    }
}
