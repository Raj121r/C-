using System;

namespace Practise
{
    class GP_Series             //Geomatric progrssion
    {

        static void Main()
        {
            Console.WriteLine("Enter the first term of GP Series:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the common ratio of GP Series:");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of term of GP Series:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double terms = a * Math.Pow(r, i-1);                   //   terms of series= (a*r^n-1)
                Console.WriteLine("term " + i + " :" + terms);
            }

            if (r == 1)
            {
                int sum = a * n;
                Console.WriteLine("Sum of GP series is " + sum);
            }
            if (r != 1)
            {
                double sum = a * (Math.Pow(r, n) - 1) / (r - 1);
                Console.WriteLine("Sum of GP series is " + sum);     // sum of series= a*(r^n-1/r-1)
            }

           
        }
    }
}
