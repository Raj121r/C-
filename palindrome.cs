using System;
using System.Globalization;
namespace Practise
{
    class Palindrome
    {
        internal static int Palin(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum * 10 + digit;
                num = num / 10;
            }
            return sum;
        }

        static void Main()
        {
            Console.WriteLine("Enter Number you want to get palindrome for :");
            int num = Convert.ToInt32(Console.ReadLine());
            int initial_num = num;
            int result = Palin(num);
            if (result == initial_num)
            {
                Console.WriteLine("Entered Number "+num+" is Palindrome ");
            }
            else
            {
                Console.WriteLine("Entered Number "+num+ " is not Palindrome " );
            }
        }
    }
}
