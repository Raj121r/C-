using System;

namespace Practise
{
    class Greatest             
    {

        static void Main()
        {
            Console.WriteLine("Enter three numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a + " is greatest");
                }
                else
                {
                    Console.WriteLine(c + " is greatest");
                }
            }
            else if (b > c)
            {

                Console.WriteLine(b + " is greatest");
            }
            else
            {
                Console.WriteLine(c + " is greatest");
            }
            
       }
    }
}
