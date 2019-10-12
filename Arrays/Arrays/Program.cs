
/*
Author:  Cody Martin
Date: 10/11/19
CTEC 135: Microsoft Software Development with C#
<Module 3, Programming Assignment 2 , Problem 1 >
 Arrays
*/






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 array of strings
            // initializing the string array then printing the elements out using a foreach loop

            string [] strArray = new string [] 
            { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"};
               

           foreach (string element in strArray)
            {
                Console.WriteLine(element);
            }


            #endregion

            #region 2 array using int
            // initializing the string array then printing the elements out using a foreach loop


            int[] myInt = new int[10];

            for (int i = 1; i < myInt.Length;i++ )
            {
                
                Console.WriteLine(i*10);
            }
            #endregion

            #region  3 2-d array
            // Creating multiplication table 12x12 using 2-d array

            int[,] my2d = new int[13, 13];

            for (int i=1; i<13; i++)
            {
                for (int j=1; j<13; j++)
                {
                    my2d[i, j] = i * j;
                }
            }



            for (int row = 1; row < 13; row++)
            {
                for (int col = 1; col < 13; col++)

                {
                    Console.Write("|{0}| " + "\t",my2d[row, col]);
                }
                Console.WriteLine();
                Console.WriteLine();



            }



            #endregion






        }
    }
}
