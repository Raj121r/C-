using System;
namespace Practise
{
    class Natural
    {
        private static int Get_Sum(int num)
        {
            
            int sum = 0;
            if (num <= 0)
            {
                return -1;
            }
            else
            {
                for(int i=1;i<=num;i++)
                {                
                        sum = sum + i;
               }
            }
                 return sum;
        }

        static void Main()
        {
            Console.WriteLine("Enter the Natural number you want to get  sum for:");
            int num = Convert.ToInt32(Console.ReadLine());


            int result = Get_Sum(num);
            if (result != -1)
            {
                Console.WriteLine("Sum of First "+num+" Natural number is " + result);
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }

        }
    }
}
