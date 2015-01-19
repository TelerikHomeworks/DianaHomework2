//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;
class ComparingFloats
{
    static void Main(string[] args)
    {
        double eps = 0.000001d;
        Console.WriteLine("Enter a = ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter b = ");
        double b = double.Parse(Console.ReadLine());
        if (Math.Abs(a - b) < eps)
        {
            Console.WriteLine("True");
        }
        else
            Console.WriteLine("False");
    }
}

