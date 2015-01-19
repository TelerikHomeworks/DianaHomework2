// Declare five variables choosing for each of them the most appropriate of the types 
// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code

using System;
    
class DeclareVariable
{
    static void Main(string[] args)
    {
            byte numByte = 97;
            ushort numUshort = 52130;
            int numInt = 4825932;
            sbyte numSbyte = -115;
            short numShort = -10000;
            Console.WriteLine(numByte + "    " + numUshort + "    " + numInt + "    " + numSbyte + "    " + numShort);
    }
}

