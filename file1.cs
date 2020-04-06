using System;

namespace _20200406.A
{
    // recipe:
    // 1. Create the worker class
    // 2. INVOKE the class - make an object with new
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Orange.ReverseString(input);

        }
    }

    class Orange
    {
        public static void ReverseString(String a)
        {
            // walk over the string
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            
        }
    }
}
