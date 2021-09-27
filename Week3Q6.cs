using System;

namespace Week3Q6
{
//    A class which has an array of 10 elements and you can access the element by calling a method GetElement(int i) where i is the index of the elements.
//if T is outside the bounds the program handles it and show a user - friendly message that the index you provided does not exist.
//Similarly, the above class must contain a method called division which divides two numbers and show you answer.Any division by 0 must be handled and shown an appropriate message.
//Finally, the same class has a third method takes two parameter an input string and an index which does calculate the string length and returns the character at index i.This method should give different error
//messages if a string object is null and if an index is out of bounds.
//All the functionalities must be implemented using exception handling.

    class Week3Q6
    {
        public static void GetElement(int i)
        {
            int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            try
            {
                a[i] = i;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index is out of bounds: " + ex.Message);
            }

            try
            {
                Console.WriteLine("Division: " + DivException(i, 0));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Number cannot be divided by 0: " + ex.Message);
            }

            try
            {
                Console.WriteLine("Input a string with less than 10 alphabets");
                string inputString = Console.ReadLine();              
                StringException(inputString, a[i]);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Input is null: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index is out of bounds: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
        private static int DivException(int a, int b)
        {           
            return a / b;
        }
        private static int StringException(string inputString, int stringLength)
        {
            stringLength = inputString.Length;
            return stringLength;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number from 1 to 10: ");
            int i = Int32.Parse(Console.ReadLine());
            GetElement(i-1);
        }
    }
}
