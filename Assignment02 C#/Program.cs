
using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment02_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Write a program that allows the user to enter a number then print it

            //Console.WriteLine("Please Enter Number: ");
            //int inputNumber ;

            //bool flag = int.TryParse(Console.ReadLine(), out inputNumber);
            //if(!flag )
            //{
            //    Console.WriteLine("Invalid input");
            //}
            //else
            //{

            //    Console.WriteLine($"Your Number is {inputNumber}");
            //}



            #endregion

            #region Q2
            //Write C# program that converts a string to an integer,
            //but the string contains non-numeric characters.
            //And mention what will happen

            //Console.WriteLine("Please Enter Number: ");
            //int inputNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(inputNumber);






            #endregion

            #region Q3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers
            //And mention what will happen

            //double a = 0.1;
            //double b = 0.2;

            //double sum = a + b;

            //Console.WriteLine(sum);



            #endregion

            #region Q4
            //Write C# program that Extract a substring from a given string.

            //string Word = "Hello World";

            //string subString = Word.Substring(0, 5);

            //Console.WriteLine($"the sub string = {subString}");

            #endregion

            #region Q5
            //Write C# program that Assigning one value type variable to another
            //and modifying the value of one variable and mention what will happen

            //int x, y;

            //x = 10;
            //y = x;
            //Console.WriteLine($"X ={x}, Y={y}");

            //x = 20;

            //Console.WriteLine($"X ={x}, Y={y}");



            #endregion

            #region Q6
            //Write C# program that Assigning one reference type variable to another
            //and modifying the object through one variable and mention what will happen

            //int[] arr1 = {1,2,3};
            //int[] arr2 = arr1;

            //Console.WriteLine($"First Array = {string.Join(", ", arr1)}");
            //Console.WriteLine($"Second Array = {string.Join(", ", arr2)}");

            //arr1[0] = 10000;
            //Console.WriteLine($"First Array HashCode = {arr1.GetHashCode()}");
            //Console.WriteLine($"Second Array HashCode = {arr2.GetHashCode()}");



            //Console.WriteLine($"First Array = {string.Join(", ", arr1)}");
            //Console.WriteLine($"Second Array = {string.Join(", ", arr2)}");

            #endregion

            #region Q7
            //Write C# program that take two string variables and print them as one variable

            //string word1 = "Hello";

            //string word2 = "World";

            //string sum = $"{word1} {word2}";

            //Console.WriteLine(sum);


            #endregion

            #region Q8
            //Which of the following statements is correct about the C#.NET code snippet given below?


            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d);

            //a) A value 0 will be assigned to d.
            //b) value 1 will be assigned to d.
            //c) value -1 will be assigned to d.
            //d) The code reports an error.
            //e) The code snippet will work correctly if ! is replaced by Not.

            #endregion

            #region Q9
            //Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            //a) 6.5 1
            //b) 6.5 0
            //c) 6 0
            //d) 6 1
            //e) 6.5 6.5

            #endregion

            #region Q10
            //What will be the output of the C# code given below?

            //int num = 1, z = 5;
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //                  //    2   +   5           7
            //                  //        7               7
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);


            //a)5 6
            //b)6 5
            //c)6 6
            //d)7 7

            #endregion
        }
    }
}
