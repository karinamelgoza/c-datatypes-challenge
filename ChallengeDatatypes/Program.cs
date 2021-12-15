using System;

namespace ChallengeDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte myByte = 200;
            Console.WriteLine(myByte);
            sbyte mySbyte = -120;
            Console.WriteLine(mySbyte);
            int myInt = 1235467;
            Console.WriteLine(myInt);
            uint myUint = 1245673;
            Console.WriteLine(myUint);
            short myShort = -32768;
            Console.WriteLine(myShort);
            ushort myUshort = 65535;
            Console.WriteLine(myUshort);
            float myFloat = 4.573672f;
            Console.WriteLine(myFloat);
            double myDouble = 4.2345324542456;
            Console.WriteLine(myDouble);
            char myChar = '@';
            Console.WriteLine(myChar);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myString = "i control text";
            Console.WriteLine(myString);
            decimal myDecimal = 5.537667m;
            Console.WriteLine(myDecimal);
            string numText = "8";

            int parsedInt = Int32.Parse(numText);
            //int parsedInt = int.Parse(numText);
            Console.WriteLine(parsedInt);



        }
    }
}
