using System;

namespace PIWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give a number as 1st variable: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please give a number as 2nd variable: ");
            int b = Convert.ToInt32(Console.ReadLine());
                        
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("The value of the 1st variable: " + a);
            Console.WriteLine("The value of the 2nd variable: " + b);

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey(true);
        }

    }
}
