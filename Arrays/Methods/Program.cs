/*
Author:  Cody Martin
Date: 10/11/19
CTEC 135: Microsoft Software Development with C#
<Module 3, Programming Assignment 2 , Problem 2 >
 Methods
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        #region calling by value and reference
        {
            string[] strArray = new string[] { "hi"};
            int myInt = 15;

            //before values


            Console.WriteLine("Before method calls:");
            Console.WriteLine(strArray[0]);
            Console.WriteLine(myInt);

            //method is called to show value change

            change(myInt, strArray);


            Console.WriteLine("After method calls:");
            Console.WriteLine(strArray[0]);
            Console.WriteLine(myInt);

            //overload value shown
            

            change(strArray);
            Console.WriteLine("After overload method calls:");
            Console.WriteLine(strArray[0]);
        }
   
        static void change(int arg1, string[] arg2)
        {
            arg1 = 25;
            arg2[0] = "bye";

        }

        static void change(string[] arg2)
        {
            
            arg2[0] = "overload";

        }




        #endregion

































    }
}
