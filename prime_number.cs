using System;

namespace Practise
{
    class PrimeNumber
    {
        internal static bool Prime(int num)
        {
            if (num <= 1)
            {
                 return false;
            }

            if (num == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if ((num % i) == 0)
                    {
                        return false;
                    }
                }
            }
                 return true;
        }

        static void Main()
        {
            Console.WriteLine("Enter Number of terms you want to check Prime or not :");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= num; i++)
            {

                bool result = Prime(i);
                if (result == true)
                {
                    Console.WriteLine("Entered Number " + i + " is Prime ");
                }
                else
                {
                    Console.WriteLine("Entered Number " + i + " is not Prime ");
                }
            }
            
        }
    }
}
