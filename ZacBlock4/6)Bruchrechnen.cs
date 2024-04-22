////
//Project Name : Bruchrechnen
//File Type : C# OOP
//Author : Zaccaria El Kacimi
//Created On : 16/04/2024
//Copy Rights : Zaccaria El Kacimi
////


using System;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Mathe
{
    class Bruchrechner
    {
        public string Addition(int a1, int a2, int b1, int b2) // a1/a2 + b1/b2
        {
            int numerator = (a1 * b2 + a2 * b1);
            int denominator = (a2 * b2);

            string result = "";

            if (numerator > denominator || numerator < denominator)
            {
                if (numerator % denominator != 0)
                {
                    result = $"{numerator / denominator} {numerator % denominator}/{denominator}";
                }
                else
                {
                    result = $"{numerator / denominator}";
                }

            }
            else if (denominator == numerator)
            {
                result = "1";
            }

            return result;
        }


        public string Subtraction(int a1, int a2, int b1, int b2) // a1/a2 - b1/b2
        {

            int numerator = (a1 * b2 - a2 * b1);
            int denominator = (a2 * b2);

            string result = "";

            if (numerator > denominator || numerator < denominator)
            {
                if (numerator % denominator != 0)
                {
                    result = $"{numerator / denominator} {numerator % denominator}/{denominator}";
                }
                else
                {
                    result = $"{numerator / denominator}";
                }

            }
            else if (denominator == numerator)
            {
                result = "1";
            }

            return result;
        }

        public string Multiplikation(int a1, int a2, int b1, int b2) // a1/a2 * b1/b2
        {

            int numerator = (a1 * b1);
            int denominator = (a2 * b2);

            string result = "";

            if (numerator > denominator || numerator < denominator)
            {
                if (numerator % denominator != 0)
                {
                    result = $"{numerator / denominator} {numerator % denominator}/{denominator}";
                }
                else
                {
                    result = $"{numerator / denominator}";
                }

            }
            else if (denominator == numerator)
            {
                result = "1";
            }


            return result;
        }
        public string Division(int a1, int a2, int b1, int b2) // a1/a2 : b1/b2
        {
            int numerator = (a1 * b2);
            int denominator = (a2 * b1);

            string result = "";

            if (numerator > denominator || numerator < denominator)
            {
                if (numerator % denominator != 0)
                {
                    result = $"{numerator / denominator} {numerator % denominator}/{denominator}";
                }
                else
                {
                    result = $"{numerator / denominator}";
                }

            }
            else if (denominator == numerator)
            {
                result = "1";
            }


            return result;
        }

        public string Potenzieren(int a, int b, int x) // a/b ^ 2
        {
            double numerator = Math.Pow(a, x);
            double denominator = Math.Pow(b, x);

            string result = "";

            if (denominator == numerator)
            {
                result = "1";
            }
            else
            {
                result = $"{numerator}/{denominator}";
            }

            return result;
        }


        public string WurzelZiehen(int a, int b) // √a/b
        {
            double numerator = Math.Sqrt(a);
            double denominator = Math.Sqrt(b);

            string result = "";

            if (denominator == numerator)
            {
                result = "1";
            }
            else
            {
                result = $"{numerator}/{denominator}";
            }

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //test example
            Bruchrechner t = new Bruchrechner();

            int a1 = 12, a2 = 6; // 12/6  
            int b1 = 10, b2 = 2; // 10/2

            Console.WriteLine("12/6 + 10/2 = " + t.Addition(a1, a2, b1, b2));
            Console.WriteLine("12/6 - 10/2 = " + t.Subtraction(a1, a2, b1, b2));
            Console.WriteLine("12/6 x 10/2 = " + t.Multiplikation(a1, a2, b1, b2)); 
            Console.WriteLine("12/6 : 10/2 = " + t.Division(a1, a2, b1, b2)); 
            Console.WriteLine("12/6 ^ 2 = " + t.Potenzieren(a1, a2, 2)); 
            Console.WriteLine("√12/6 = " + t.WurzelZiehen(a1, a2)); 
        }
    }
}
