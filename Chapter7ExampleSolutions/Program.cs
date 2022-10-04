// Chapter 7 Example Solutions

using System;
using System.Threading;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Chapter7ExampleSolutions
{

    class Program
    {

        public static void Main(string[] args)
        {
            // Reading Matrices from the Console page 250
            /*
            Console.Write("Enter the number of rows: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, column];

            Console.WriteLine("Enter the cells of matrix:");

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    Console.Write("matrix[{0}, {1}] = ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 9)
                    {
                        Console.Write(" " + matrix[i, j]);
                    }
                    else if (matrix[i, j] <= 9)
                    {
                        Console.Write("  " + matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
            */

            // Printing Matrices page249
            /*
            int[,] matrix =
            {
                {1,2,3,4 },
                {5,6,7,8 }
            };

            for(int i = 0; i<matrix.GetLength(0); i++)
            {
                for(int j = 0; j<matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            */

            // Two - Dimensional Array Initialization
            /*
            int[,] matrix =
            {
                {1,2,3,4},
                {5,6,7,8 },
                {5,6,7,8 }
            };

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            */

            // Iteration with "foreach" Loop
            /*
            string[] capitals = { "Sofia", "Washington", "London", "Paris" };

            foreach(string capital in capitals)
            {
                Console.WriteLine(capital);
            }
            */

            // Iteration through the array in a reverse order
            /*
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("Reversed: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            */

            // Iteration through Elements of an Array
            // Example 2
            /*
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("Output: ");
            for(int i = 0; i< array.Length; i+=2)
            {
                array[i] = array[i] * array[i];
                Console.Write(array[i] + " ");
            }
            */

            // Example 1
            /*
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Console.Write("Output: ");

            for(int i = 0; i < array.Length; i++)
            {
                // Declaring the number
                array[i] = 2 * array[i];
                // Print the number
                Console.Write(array[i] + " ");
            }
            */

            // Printing an Array to the Console
            /*
            string[] array = { "one", "two", "three", "four" };

            for(int i = 0; i< array.Length; i++)
            {
                Console.WriteLine("Element[{0}] = {1}", i, array[i]);
            }
            */

            // Check for Symmetric Array
            /*
            Console.WriteLine("Enter a positive integer: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] array = new int[numberOfElements];

            Console.WriteLine("Enter the values of the array: ");
            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;
            for(int i = 0; i < array.Length/2; i++)
            {
                if (array[i] != array[numberOfElements - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }

            Console.WriteLine("Is symmetric? {0}", symmetric);
            */

            // Reading an Array from the Console
            /*
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] array = new int[numberOfElements];

            for(int i = 0; i < numberOfElements; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Element {0} is {1}", i+1, array[i]);
            }
            */

            // ArrayReverse
            // Solution 2
            /*
            int[] array = { 1, 2, 3, 4, 5 };
            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[array.Length - i - 1] = array[i];
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }
            */

            // Solution 1
            /*
            int[] array = { 1, 2, 3, 4, 5 };
            int[] reversedArray = new int[array.Length];

            for(int i = array.Length-1, j = 0; i >= 0; i--, j++)
            {
                reversedArray[i] = array[j];
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" array : " + array[i] + "reversedArray : " + reversedArray[i]);
            }
            */



            /*
            int[] arr = new int[5];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            */

            /*
            int[] mySecondArray = new int[6];
            mySecondArray[1] = 1;
            mySecondArray[5] = 5;
            */

            /*
            In this case we allocate an array of seven elements of type string.
            The type string is a reference type (object) and its values are
            stored in the dynamic memory. The variable daysOfWeek is allocated
            in the stack memory, and points to a section of the dynamic memory
            containing the elements of the array. The type of each of these
            seven elements is string, which itself points to a different
            section of the dynamic memory, where the real value is stored. 
            */
            /*
            string[] dayOfWeek =
                { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday",
                "Saturday", "Sunday"};
            */

            /*
            int[] myFirstArray = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(myFirstArray[3]);
            */

            /*
            int[] array = new int[6];
            Console.WriteLine(array[4]);
            */

            Console.Read();

        }
    }
}