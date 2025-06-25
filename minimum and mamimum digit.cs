using System;

namespace Practise
{
    class Digit             
    {
        public static int Max_Digit(int num)
        {

            int max_digit = 0;
            if (num <= 0)
            {
                return -1;
            }
            while (num !=0)
            {
                int digit = num % 10;
                if (digit > max_digit)
                {
                    max_digit = digit;
                }
                num = num / 10;
            }
            return max_digit;
        }

        public static int Min_Digit(int num)
        {

            int min_digit = 9;
            if (num <= 0)
            {
                return -1;
            }
            while (num !=0)
            {
                int digit = num % 10;
                if (digit < min_digit)
                {
                    min_digit = digit;
                }
                num = num / 10;
            }
            return min_digit;
        }

        static void Main()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = Max_Digit(num);

            if (result != -1)
            {
                Console.WriteLine("Maximum Digit of " + num + " is " + result);
            }
            else
            {
                Console.WriteLine("Please Enter positive number");
            }


            int resultant = Min_Digit(num);

            if (resultant != -1)
            {
                Console.WriteLine("Minimum Digit of " + num + " is " + resultant);
            }
            
        }
    }
}
