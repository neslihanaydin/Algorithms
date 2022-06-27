using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NeslihanTurpcu300359919
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bonusLab();
            ReadKey();
        }

        static void addPerson(Dictionary<string, int> telephoneBook)
        {
            string name;
            int telNumber;
            WriteLine("Enter the name of person:");
            name = (String)ReadLine();

            if (telephoneBook.ContainsKey(name))
            {
                WriteLine("The record is already exists.");
            }
            else
            {
                WriteLine("Enter the tel number:");
                telNumber = int.Parse(ReadLine());
                telephoneBook.Add(name, telNumber);
                WriteLine("One record added");

            }
        }
        static void deletePerson(Dictionary<string, int> telephoneBook)
        {
            string name;
            WriteLine("Enter the name you want to delete:");
            name = (String)ReadLine();
            if (telephoneBook.ContainsKey(name))
            {
                telephoneBook.Remove(name);
                WriteLine("One record deleted");

            }
            else
            {
                WriteLine("The record is not existing");
            }

        }
        static void displayTelNumber(Dictionary<string, int> telephoneBook)
        {
            string name;
            WriteLine("Enter the name of the person:");
            name = (String)ReadLine();
            if (telephoneBook.ContainsKey(name))
            {
                WriteLine("The telephone number is " + telephoneBook[name]);

            }
            else
            {
                WriteLine("The record is not existing");
            }
        }
        static void viewAll(Dictionary<string, int> telephoneBook)
        {
            //Sort and List

            if (telephoneBook.Count == 0) //if the telephoneBook dictinary size is 0 that means no record yet.
            {
                WriteLine("No record yet.");
            }
            else
            {
                foreach (KeyValuePair<string, int> person in telephoneBook.OrderBy(key => key.Key))
                {
                    WriteLine("Name   :" + person.Key);
                    WriteLine("Tel no :" + person.Value);

                }

            }


        }
        static void editTelNumber(Dictionary<string, int> telephoneBook)
        {
            string name;
            int telNumber;
            WriteLine("Enter the name of the person:");
            name = (String)ReadLine();
            if (telephoneBook.ContainsKey(name))
            {
                WriteLine("Enter the new telephone number:");
                telNumber = int.Parse(ReadLine());
                telephoneBook[name] = telNumber;
                WriteLine("One record added");

            }
            else
            {
                WriteLine("The record is not existing");
            }
        }

        static void bonusLab()
        {
            int input = 0;

            Dictionary<string, int> telephoneBook = new Dictionary<string, int>();


            while (input != 6) // if user enter 6 the program is going to exit
            {
                WriteLine();
                WriteLine("----------------------------------------------------------");
                WriteLine("Choose from the following options by entering the number \n" +
                "1: Add a person\n" +
                "2: Delete a person\n" +
                "3: Display a person tel no\n" +
                "4: View all\n" +
                "5: Edit a person tel number\n" +
                "6: Exit");
                while (int.TryParse(ReadLine(), out input) == false) //Make sure that true type entered
                {
                    WriteLine("Please enter true type of number.");

                }
                switch (input)
                {
                    case 1: //add a person
                        WriteLine("----------------------------------------------------------");
                        addPerson(telephoneBook);
                        break;
                    case 2: //delete a person
                        WriteLine("----------------------------------------------------------");
                        deletePerson(telephoneBook);
                        break;
                    case 3: // display a person tel no
                        WriteLine("----------------------------------------------------------");
                        displayTelNumber(telephoneBook);
                        break;
                    case 4: //view all
                        WriteLine("----------------------------------------------------------");
                        viewAll(telephoneBook);
                        break;
                    case 5: //edit a person tel number
                        WriteLine("----------------------------------------------------------");
                        editTelNumber(telephoneBook);
                        break;
                    case 6: // 6 means "exit" entered
                        break;
                    default: //is user enter differen value from 1,2,3,4,5,6 then program shoul be ask again
                        WriteLine("----------------------------------------------------------");
                        WriteLine("Please enter a number 1 to 6..");
                        break;
                }

            }



        }


    }
}
