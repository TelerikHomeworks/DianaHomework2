//Which of the following values can be assigned to a variable of type float and which to 
//a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;


class FloatOrDouble
{
    static void Main(string[] args)
    {
        float num1Float = 12.345F;
        double num1Double = 8923.1234857;
        float num2Float = 3456.091F;
        double num2Double = 34.567839023;
        Console.WriteLine("num1Float = " + num1Float);
        Console.WriteLine("num1Double = " + num1Double);
        Console.WriteLine("num2Float = " + num2Float);
        Console.WriteLine("num2Double = " + num2Double);
    }
}

