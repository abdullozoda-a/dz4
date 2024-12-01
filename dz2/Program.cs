using System;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number: ");int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");int num2 = int.Parse(Console.ReadLine());
            int count = 0;
            while (num1 >= num2)
            {
                num1 -= num2;
                count++; 
            }
            Console.WriteLine(count);
        }
    }
}