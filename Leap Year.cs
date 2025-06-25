using System;

namespace Practise
{
    class Leap_Year             
    {
        public static bool Leap(int year)
        {
            if (year <= 0)
            {
                Console.WriteLine("Year can't contain zero or minus digit");
                return false;
            }
            else if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        static void Main()
        {
            Console.WriteLine("Enter any year to check whether it is Leap Year");
            int year = Convert.ToInt32(Console.ReadLine());

            bool result = Leap(year);
            if (year > 0)
            {
               if (result == true)
            {
                Console.WriteLine(" Entered Year " + year + " is a Leap Year");
            }
            else
            {
                Console.WriteLine(" Entered Year " + year + " is not a Leap Year");
            }
            }
            
        }
    }
}
