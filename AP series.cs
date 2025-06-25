using System;
namespace Practise
{
    class AP_Series
    {

        static void Main()
        {
            Console.WriteLine("Enter the first term of AP Series:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the common term of AP Series:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of term of AP Series:");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=n;i++){
                int terms= a+(i-1)*d;
                Console.WriteLine("terms :"+terms);          // terms of AP series =  a+(n−1)×d
            }

            int sum = n * (2 * a + (n - 1) * d) / 2;       //   sum of AP series=  n/2(2a + (n-1) *d)
                                                                             
            Console.WriteLine("Sum of AP series is " + sum);
        }
    }
}
