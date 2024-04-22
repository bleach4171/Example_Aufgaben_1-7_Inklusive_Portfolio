////
//Project Name : Taschenrechner
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
    class Taschenrechner
    {
        public int Addition(int x, int y) { return x + y; }
        public int Subtraction(int x, int y) { return x - y; }
        public int Multiplikation(int x, int y) { return x * y; }
        public int Division(int x, int y) { return x / y; }


        public double Potenzieren(int x, int y) { return Math.Pow(x, y); }
        public double WurzelZiehen(int x) { return Math.Sqrt(x); }
        public double Logarithmus(int x) { return Math.Log(x); }

        public int Fakultaet(int x) 
        {
            int result = 1;
            for (int i = x; i > 0; i--) { result *= i; }
            return result; 
        }

        public double Sinus(int x) { return Math.Sin(x); }
        public double Cosinus(int x) { return Math.Cos(x); }
        public double Tangens(int x) { return Math.Tan(x); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //test example
            Taschenrechner t = new Taschenrechner();

            Console.WriteLine(t.Addition(2,3)); //5
            Console.WriteLine(t.Subtraction(10, 3)); //7
            Console.WriteLine(t.Multiplikation(3, 5)); //15
            Console.WriteLine(t.Division(6, 2)); //3
            Console.WriteLine(t.Potenzieren(5, 2)); //25
            Console.WriteLine(t.WurzelZiehen(25)); //5
            Console.WriteLine(t.Logarithmus(123)); //4.812184355...
            Console.WriteLine(t.Fakultaet(4)); //24
            Console.WriteLine(t.Sinus(90)); //0.89399666...
            Console.WriteLine(t.Cosinus(90)); //-0.44807361...
            Console.WriteLine(t.Tangens(90)); //-1.99530041...
        }
    }
}
