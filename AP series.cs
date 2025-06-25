using System;
namespace Practise
{
    class AP_Series
    {

        static void Main()
        {
            Console.WriteLine("Enter the first term of AP Series:");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the common term of AP Series:");
            int common = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of term of AP Series:");
            int total = Convert.ToInt32(Console.ReadLine());

            int sum = total * (2 * first + (total - 1) * common) / 2;       //   n/2[2a + (n-1) *d]

            Console.WriteLine("Sum of AP series is " + sum);
        }
    }
}
