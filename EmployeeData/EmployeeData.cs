//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;


class EmployeeData
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter gerder (m ot f): ");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter personal ID number: ");
        ulong personalIDNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter employee number: ");
        uint employeeNumber = uint.Parse(Console.ReadLine());
        Console.WriteLine("First name:            " + firstName);
        Console.WriteLine("Last name:             " + lastName);
        Console.WriteLine("Age:                   " + age);
        Console.WriteLine("Gender:                " + gender);
        Console.WriteLine("Personal ID number:    " + personalIDNumber);
        Console.WriteLine("Employee number:       " + employeeNumber);


    }
}

