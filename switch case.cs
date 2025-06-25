
using System;
class HelloWorld {
  static void Main() {
   
   Console.WriteLine("Enter any letter from a to f");
         char ch=Convert.ToChar(Console.ReadLine());
         int digit=ch-'a'+1;
         
         switch(digit){
             case 1:
             Console.WriteLine("It's Monday");
             break;
             
             case 2:
             Console.WriteLine("It's Tuesday");
             break;
             
             case 3:
             Console.WriteLine("It's Wednesday");
             break;
            
             case 4:
             Console.WriteLine("It's Thursday");
             break;
             
             case 5:
             Console.WriteLine("It's Friday");
             break;
             
             case 6:
             Console.WriteLine("It's Saturday");
             break;
         
            default:
            Console.WriteLine("It's Sunday");
            break;
         }
         
  }
  }
