using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace NeslihanTurpcu300359919Quiz2
{
    internal class Program
    {

        public const int arrayRows = 5; //constant was used for the row dimensions of the Array.
        public const int arrayCols = 5; //constant was used for the column dimensions of the Array.
        static int[,] scoreArrays = new int[arrayRows, arrayCols]; //Create an array using dimension constant values , rows -> Students , columns -> Answers
        static Dictionary<int, int> answerKey = new Dictionary<int, int>();//correct answers to the questions will be kept in a dictionary.
        static int theHighestScore = 0;
        static int theLowestScore = 0;
        static List<int> scoreList = new List<int>();
        /* chooseRandomlyStudentAnswers() generates random number 1 to 5 for the student's answers
         * Two for loops are used. The first for loop represents the transactions for each student. 
         * In the second for loop, for each student, the answer to each question is chosen randomly.
         * It Writes in a matrix format then adds numbers to scoreArrays array.
         * Rows represents students
         * Columns represents answers of each student
         * 
         */
        static void chooseRandomlyStudentAnswers()
        {
            Random r = new Random(); 
            int num; 

            WriteLine("\t\t\t\t**********ANSWERS**********");
            for (int i = 0; i < arrayRows; i++) //loop for each student(rows)
            {
                Write("Student " + (i + 1) + "|");
                for (int j = 0; j < arrayCols; j++) //loop for each answers(columns)
                {
                    num = r.Next(1, 6);
                    Write("\t" + num);
                    scoreArrays[i, j] = num; // assigns the answer to the scoreArray
                }
                WriteLine();
            }
        }

        /*
         * getCorrectAnswerFromUser() gets correct answers for each question from user.
         * It checks conditions (the user inputs only a number and numbers from 1 to 5 only)
         * If there is an error then it throws an exception related to the exception type
         * (If user enters a number which is not 1 to 5 then program throws an IndexOutOfRangeException)
         * (If user enters a string input then program throws an FormatException)
         * After check processing if there is no any exception then it adds the answers to answerKey Dictionary.
         */
        static void getCorrectAnswerFromUser()
        {
            int answer = 0; //answer variable to be received from the user for the answer of each question
            bool checkLoopToGetAnswersValidation = false; /*The value of this variable is false 
                                                           * when the exception is thrown and at the beginning. 
                                                           * When the user enters a variable with the correct conditions,
                                                           * the value of this variable becomes true. 
                                                           * This means that the next question can be answered.
                                                           */
            for (int i = 0; i < arrayCols; i++) //Loop to get correct answers of each question
            {
                checkLoopToGetAnswersValidation = false;

                while (!checkLoopToGetAnswersValidation)
                {
                    checkLoopToGetAnswersValidation = true; // will be false if exception is thrown
                    Write("Enter the correct answer for question " + (i + 1) + ":   ");
                    try
                    {
                        answer = Convert.ToInt32(ReadLine()); //get answer, If the user enters string format then it throws a FormatException
                        if (((answer <= 0) || (answer > 5))) //check the conditions for answer in number format 
                        {
                            throw new IndexOutOfRangeException(); //If the user enters number which is not 1 to 5 then it throws an IndexOutOfRangeException
                        }
                        else //this means input conditions were provided
                        {
                            answerKey.Add(i+1, answer); //add question's answer to answerKey Dictionary
                        }


                    }
                    catch (IndexOutOfRangeException e1)
                    {
                        
                        WriteLine("You should only enter numbers 1 to 5");
                        checkLoopToGetAnswersValidation = false; //It will be false because there is an exception, the program must ask again

                    }
                    catch(FormatException e2)
                    {
                        WriteLine("You must enter a number");
                        checkLoopToGetAnswersValidation = false; //It will be false because there is an exception, the program must ask again

                    }
                    catch (Exception e3)
                    {
                        WriteLine(e3);
                        checkLoopToGetAnswersValidation = false; //It will be false because there is an exception, the program must ask again

                    }

                }
                
            }
        }

        static void displayStudentsScore()
        {
            int scoreForCurrentStudent = 0;
            for(int i = 0; i < arrayRows; i++)
            {
                scoreForCurrentStudent = 0;
                for (int j = 0; j < arrayCols; j++)
                {
                    if (scoreArrays[i, j] == answerKey[j+1])
                    {
                        scoreForCurrentStudent = scoreForCurrentStudent + 1;
                    }
                }
                WriteLine("Student " + (i + 1) + " score is " + scoreForCurrentStudent);
                scoreList.Add(scoreForCurrentStudent);

            }
        }
        
        static void displayHighestAndLowestScore()
        {
            var query = from obj in scoreList
                        orderby obj descending
                        select obj;
            theHighestScore = query.First();
            theLowestScore = query.Last();
            WriteLine("The highest score is " + theHighestScore);
            WriteLine("The lowest score is " + theLowestScore);


        }
        static void Main(string[] args)
        {


            char counter = 'Y';

            while (counter == 'Y' || counter == 'y')
            {
                checkScoresFile();
                chooseRandomlyStudentAnswers();
                getCorrectAnswerFromUser();
                displayStudentsScore();
                displayHighestAndLowestScore();
                using var sw = new StreamWriter("scoresFile.txt");
                sw.WriteLine(theHighestScore);
                sw.WriteLine(theLowestScore);
                sw.Flush();
                Write("Do you want to process another set of exams? (yes : Y , no : N)");
                counter = ReadLine()[0];

            }

            
            ReadKey();

        }



        /*
         * checkScoresFile method checks the file which stores the highest score and the lowest store.
         * If File is not exists then method displays a message ("No previous exams exist yet") to the user.
         * 
         */
        static void checkScoresFile()
        {
            if (!File.Exists("scoresFile.txt"))
            {
                WriteLine("No previous exams exist yet");
                using var fs = new FileStream("scoresFile.txt", FileMode.Create);
            }
            else
            {
                //I added <LangVersion>8.0</LangVersion> to .csproj file. Because this feature can be used with in C# 8.0 version.

                using var fs = new FileStream("scoresFile.txt", FileMode.Truncate);

            }

        }
    }
}
