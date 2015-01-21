// A bank account has a holder name (first name, middle name and last name), 
// available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountDate
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter middle name: ");
        string middleName = Console.ReadLine();
        Console.WriteLine("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter bank's name: ");
        string bankName = Console.ReadLine();
        Console.WriteLine("Enter IBAN: ");
        string IBAN = Console.ReadLine();
        Console.WriteLine("Enter first credit card number: ");
        ulong creditCardNumber1 = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter second credit card number: ");
        ulong creditCardNumber2 = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter third credit card number: ");
        ulong creditCardNumber3 = ulong.Parse(Console.ReadLine());

    }
}

