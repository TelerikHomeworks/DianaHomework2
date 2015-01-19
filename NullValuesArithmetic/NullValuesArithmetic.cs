//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;


class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? intNull = null;
        double? doubleNull = null;
        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull);
        intNull = intNull + 2;
        doubleNull = doubleNull + 3;
        Console.WriteLine();
        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull);
        intNull = intNull + null;
        doubleNull = doubleNull + null;
        Console.WriteLine();
        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull);
    }
}

