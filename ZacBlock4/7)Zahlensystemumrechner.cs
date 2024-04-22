////
//Project Name : Zahlensystemumrechner
//File Type : C# OOP
//Author : Zaccaria El Kacimi
//Created On : 16/04/2024
//Copy Rights : Zaccaria El Kacimi
////


using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Mathe
{
    class Zahlensystemumrechner
    {
        public int Decimal_Convert<Thing>(Thing value, int num_base) //base -> decimal
        {
            return Convert.ToInt32($"{value}", num_base);
        }

        // Binaer (base 2)
        public int Bin_Convert(int value) { return Convert.ToInt32(Convert.ToString(value, 2)); } // decimal -> binary 

        //Oktal (base 8)
        public string Okt_Convert(int value) { return Convert.ToString(value, 8); } // decimal -> hexadezimal

        //Hexadezimal (base 16)
        public string Hex_Convert(int value) { return Convert.ToString(value, 16); } // decimal -> hexadezimal

        public string[] Dec_to_All(int value)
        {
            int dec = value;
            int bin = Bin_Convert(value);
            string oct = Okt_Convert(value);
            string hex = Hex_Convert(value);
            return [$"{dec}", $"{bin}", oct, hex];
        }
    }


    class Dezimal : Zahlensystemumrechner
    {
        public int Addition(int x, int y) { return x + y; } // +
        public int Subtraction(int x, int y) { return x - y; } // -
        public int Multiplikation(int x, int y) { return x * y; } // *
        public int Division(int x, int y) { return x / y; } // /
    }

    class Binaer : Zahlensystemumrechner
    {
        const int num_base = 2;

        public int Addition(int x, int y) // +
        {
            int value = Decimal_Convert(x, num_base) + Decimal_Convert(y, num_base); return Bin_Convert(value);
        }

        public int Subtraction(int x, int y) // -
        {
            int value = Decimal_Convert(x, num_base) - Decimal_Convert(y, num_base); return Bin_Convert(value);
        }

        public int Multiplikation(int x, int y) // *
        {
            int value = Decimal_Convert(x, num_base) * Decimal_Convert(y, num_base); return Bin_Convert(value);
        }

        public int Division(int x, int y) // /
        {
            int value = Decimal_Convert(x, num_base) / Decimal_Convert(y, num_base); return Bin_Convert(value);
        }

    }

    class Oktal : Zahlensystemumrechner
    {
        const int num_base = 8;
        public string Addition(int x, int y) // +
        {
            int value = Decimal_Convert(x, num_base) + Decimal_Convert(y, num_base); return Okt_Convert(value);
        }

        public string Subtraction(int x, int y) // -
        {
            int value = Decimal_Convert(x, num_base) - Decimal_Convert(y, num_base); return Okt_Convert(value);
        }

        public string Multiplikation(int x, int y) // *
        {
            int value = Decimal_Convert(x, num_base) * Decimal_Convert(y, num_base); return Okt_Convert(value);
        }

        public string Division(int x, int y) // /
        {
            int value = Decimal_Convert(x, num_base) / Decimal_Convert(y, num_base); return Okt_Convert(value);
        }

    }

    class Hexadezimal : Zahlensystemumrechner
    {
        const int num_base = 16;
        public string Addition(int x, int y) // +
        {
            int value = Decimal_Convert(x, num_base) + Decimal_Convert(y, num_base); return Hex_Convert(value);
        }

        public string Subtraction(int x, int y) // -
        {
            int value = Decimal_Convert(x, num_base) - Decimal_Convert(y, num_base); return Hex_Convert(value);
        }

        public string Multiplikation(int x, int y) // *
        {
            int value = Decimal_Convert(x, num_base) * Decimal_Convert(y, num_base); return Hex_Convert(value);
        }

        public string Division(int x, int y) // /
        {
            int value = Decimal_Convert(x, num_base) / Decimal_Convert(y, num_base); return Hex_Convert(value);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {



            //call out classes
            Zahlensystemumrechner conv = new Zahlensystemumrechner();

            Dezimal dec = new Dezimal();
            Binaer bin = new Binaer();
            Hexadezimal hex = new Hexadezimal();
            Oktal oct = new Oktal();



            int number = 500; //test number

            //Conversion examples
            Console.WriteLine("CONVERSION TEST");
            Console.WriteLine("\ndecimal to binary:"); //display our test number
            Console.WriteLine(number);
            Console.WriteLine(conv.Bin_Convert(number)); //convert decimal to binary

            string hex_number = conv.Hex_Convert(number);
            Console.WriteLine("\nhex to octal:");
            Console.WriteLine(hex_number);
            Console.WriteLine(conv.Okt_Convert(conv.Decimal_Convert(hex_number, 16)));


            //OR

            Console.WriteLine("\ndecimal to all");
            foreach (string num in conv.Dec_to_All(number)) //access to all results with a loop (they are all strings)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();
            Console.WriteLine("CALCULATOR TEST");

            //Calculator examples

            int binany_number = conv.Bin_Convert(number); //we convert our decimal number to binary.
            Console.WriteLine(binany_number); //display it into the console.

            Console.WriteLine("111110100 + 111110100 = " + bin.Addition(binany_number, binany_number)); //using the Binaer class we added the first value to the other one.



        }
    }
}
