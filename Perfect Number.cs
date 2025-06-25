using System;


namespace Practise
{
    class Perfect
    {
        internal static int Perf(int num)
        {
            
            int sum = 0;
            if (num <= 0)
            {
                return -1;
            }
            else
            {
                for(int i=1;i<num;i++)
                {
                    if ((num % i) == 0)
                    {
                        sum = sum + i;
                    }

                }
            }
                 return sum;
        }

        static void Main()
        {
            Console.WriteLine("Enter Number you want to check Perfect or not :");
            int num = Convert.ToInt32(Console.ReadLine());
            
               
                int result = Perf(num);
                if (result == num&& result!=-1)
                {
                    Console.WriteLine("Entered Number " + num + " is Perfect ");
                }
                else
                {
                    Console.WriteLine("Entered Number " + num + " is not Perfect ");
                }
            
        }
    }
}
