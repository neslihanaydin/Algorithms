using static System.Console;
using System;

namespace NeslihanTurpcuWeek2n
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int voteForC1;
            int voteForC2;
            int abstainPeople;
            int totalPopulation;
            double percentageForC1;
            double percentageForC2;

            WriteLine("Please input total votes for Candidate 1:");

            if ((int.TryParse(ReadLine(), out voteForC1)))
            {
                WriteLine("Please input total votes for Candidate 2:");
                if ((int.TryParse(ReadLine(), out voteForC2)))
                {
                    WriteLine("Please input total votes for Abstain People:");
                    if ((int.TryParse(ReadLine(), out abstainPeople)))
                    {
                        totalPopulation = voteForC1 + voteForC2 + abstainPeople;
                        WriteLine("Total Voting Population is : " + totalPopulation);

                        //Compute
                        //Determine the percentage each candidate got based from the total voting population.
                        //Include the abstainee votes. Display the results
                        percentageForC1 = ((double)voteForC1 / (double)totalPopulation) * 100.0;
                        percentageForC2 = ((double)voteForC2 / (double)totalPopulation) * 100.0;
                        WriteLine("Candidate 1, Percentage is : %{0}", percentageForC1);
                        WriteLine("Candidate 2, Percentage is : %{0}", percentageForC2);

                        //percentageForC1 = (double)voteForC1 * ((double)totalPopulation / 100.0);
                        //percentageForC2 = (double)voteForC2 * ((double)totalPopulation / 100.0);

                        if (percentageForC1 > percentageForC2)
                        {
                            WriteLine("Congratulations : Candidate 1, Percentage is : %{0}", percentageForC1);
                        }
                        else if (percentageForC2 > percentageForC1)
                        {
                            WriteLine("Congratulations : Candidate 2, Percentage is : %{0}", percentageForC2);
                        }
                        else
                            WriteLine("There is an equality  !!!!");


                    }

                }

            }
            else
            {
                WriteLine("Please input true type value..");

            }



            ReadKey();


        }
    }
}
