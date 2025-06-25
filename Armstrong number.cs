using System;


namespace Practise
{
    class Armstrong
    {
        internal static int Arm(int num)
        {
            int length = Convert.ToString(num).Length;
            int sum = 0;
            if (num <= 0)
            {
                return -1;
            }
            else
            {
                while (num > 0)
                {
                    int digit = num % 10;
                    sum = sum + (int)Math.Pow(digit, length);
                    num = num / 10;

                }
            }
                 return sum;
        }

        static void Main()
        {
            Console.WriteLine("Enter Number you want to check Armstrong or not :");
            int num = Convert.ToInt32(Console.ReadLine());
            
                int initial_num=num;
                int result = Arm(num);
                if (result == initial_num&& result!=-1)
                {
                    Console.WriteLine("Entered Number " + num + " is Armstrong ");
                }
                else
                {
                    Console.WriteLine("Entered Number " + num + " is not Armstrong ");
                }
            
        }
    }
}
