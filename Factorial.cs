using System;

    class Factorial
    {
    public static int Fact(int num)
    {
        if (num <= 0)
        {
            Console.WriteLine("please Enter valid number");
            return -1;
        }
        int factorial = 1;
        for (int i = num; i >= 1; i--)
        {
            factorial = factorial * i;
        }
        return factorial;
        }
    public static void Main(string[] a)
    {
        Console.WriteLine("Enter the number");
        int num = Convert.ToInt32(Console.ReadLine());
        int result= Fact(num);
        if (result != -1)
        {
            Console.WriteLine("Factorial of " + num + " is : " + result);
        }
    }
    }
