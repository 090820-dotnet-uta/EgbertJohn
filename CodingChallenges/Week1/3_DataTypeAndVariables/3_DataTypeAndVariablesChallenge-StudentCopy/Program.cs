using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
            byte newByte = 2;
            System.Console.WriteLine(newByte);

            sbyte newSbyte = -2;
            System.Console.WriteLine(newSbyte);

            int newInt = 4;
            System.Console.WriteLine(newInt);

            uint newUint = 400;
            System.Console.WriteLine(newUint);

            short newShort = -400;
            System.Console.WriteLine(newShort);

            ushort newUshort = 800;
            System.Console.WriteLine(newUshort);

            long newLong = 8000;
            System.Console.WriteLine(newLong);

            ulong newUlong = 80000;
            System.Console.WriteLine(newUlong);

            float newFloat = 1.1f;
            System.Console.WriteLine(newFloat);

            double newDouble = 2.2;
            System.Console.WriteLine(newDouble);

            char newChar = 'X';
            System.Console.WriteLine(newChar);

            bool newBool = true;
            System.Console.WriteLine(newBool);

            string newString = "I control text";
            System.Console.WriteLine(newString);

            string numText = "6543";
            System.Console.WriteLine(Text2Num(numText));


            //public static bool TryParse (string s, out int result);

            decimal newDecimal = 3.3M;
            System.Console.WriteLine(newDecimal);


        }

        public static int Text2Num(string numText)
        {
            int secondInt;
            int.TryParse(numText, out secondInt);
            return secondInt;
        }
    }
}
