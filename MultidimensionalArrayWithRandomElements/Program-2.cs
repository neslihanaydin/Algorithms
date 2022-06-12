using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace July10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            MultiplicExercise();
            //MultiplicExercise2();

            ReadKey();

        }


        public static void MultiplicExercise() //First method for exercise
        {
            int[] ar1Dimension = new int[25];

            int[,] arr1 = new int[5, 5]; 
            int temp;
            Random r = new Random();
            for (int i = 0; i < 25; i++) //Initialize the one dimension array with 1..to..25 so, art1Dimension is going to be like this : [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25]
            {
                ar1Dimension[i] = i + 1;
            }

            /*
            { [ [0,0] , [0,1] , [0,2] ,[0,3] ,[0,4] ],  0. row
              [ [1,0] , [1,1] , [1,2] ,[1,3] ,[1,4] ],  1. row
              [ [2,0] , [2,1] , [2,2] ,[2,3] ,[2,4] ],  2. row
              [ [3,0] , [3,1] , [3,2] ,[3,3] ,[3,4] ],  3. row
              [ [4,0] , [4,1] , [4,2] ,[4,3] ,[4,4] ]   4. row
            }
             */

            //Purpose : Generate a random number and use this number as an index to assign arr1 
            for (int i = 0; i < 5; i++) // 0.row to 4.row
            {
                for (int j = 0; j < 5; j++) // 0.columns to 4.columns
                {
                    while (true)
                    {
                        temp = r.Next(0, 25); // random number 0 to 25 for index
                        if (!(ar1Dimension[temp] == 0)) //if ar1Dimension[temp] is equal to 0, that means this value has added to arr1 before. Because when we add a value to arr1 we have to assign 0 in ar1Dimension array.
                        {
                            break;
                        }
                    }

                    arr1[i, j] = ar1Dimension[temp];
                    ar1Dimension[temp] = 0;
                    Write("\t" + arr1[i, j]);
                }
                WriteLine();

            }

        }


        /************* Another Solution for Lab Exercise************************/

        public static bool checkElementInArray(int[,] tempArray, int value)
        {
            for (int i = 0; i < tempArray.GetLength(0); i++)
            {
                for (int j = 0; j < tempArray.GetLength(1); j++)
                {
                    if (tempArray[i, j] == value)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public static void MultiplicExercise2()
        {
            int[,] arr1 = new int[5, 5];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = 0;
                }
            }
            int temp = 0;
            Random r = new Random();


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    while (true)
                    {
                        temp = r.Next(1, 26);
                        if (checkElementInArray(arr1, temp) == false)
                        {
                            break;
                        }
                    }

                    arr1[i, j] = temp;
                    Write("\t" + arr1[i, j]);
                }
                WriteLine();

            }

        }

    }
}

