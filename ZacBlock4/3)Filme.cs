////
//Project Name : Filme
//File Type : C# OOP
//Author : Zaccaria El Kacimi
//Created On : 15/04/2024
//Copy Rights : Zaccaria El Kacimi
////

using System;

namespace Filme
{
    class Film
    {
        private string Title;
        private int Erscheinungsjahr;
        private string Genre;
        private double Laufzeit;
        private string[] Cast;
        private string Sprache;
        private int FSK;

        public Film()
        {
            Title = "";
            Erscheinungsjahr = 0;
            Genre = "";
            Laufzeit = 0;
            Cast = [];
            Sprache = "";
            FSK = 0;
        }

        public Film(string title, int erscheinungsjahr)
        {
            Title = title;
            Erscheinungsjahr = erscheinungsjahr;
            Genre = "";
            Laufzeit = 0;
            Cast = [];
            Sprache = "";
            FSK = 0;
        }

        public Film(string title, int erscheinungsjahr, string genre, double laufzeit)
        {
            Title = title;
            Erscheinungsjahr = erscheinungsjahr;
            Genre = genre;
            Laufzeit = laufzeit;
            Cast = [];
            Sprache = "";
            FSK = 0;
        }

        public Film(string title, int erscheinungsjahr, string genre, double laufzeit, string cast, string sprache, int fsk)
        {
            Title = title;
            Erscheinungsjahr = erscheinungsjahr;
            Genre = genre;
            Laufzeit = laufzeit;
            Cast = cast.Split(',');
            Sprache = sprache;
            FSK = fsk;

        }

        //get , set Title
        public string get_Title() { return Title; }
        public void set_Title(string title) { Title = title; }

        //get , set Erscheinungsjahr
        public int get_Erscheinungsjahr() { return Erscheinungsjahr; }
        public void set_Erscheinungsjahr(int erscheinungsjahr) { Erscheinungsjahr = erscheinungsjahr; }

        //get , set Genre
        public string get_Genre() { return Genre; }
        public void set_Genre(string genre) { Genre = genre; }

        //get , set Laufzeit
        public double get_Laufzeit() { return Laufzeit; }
        public void set_Laufzeit(int laufzeit) 
        {
            double hours = Convert.ToDouble($"{laufzeit / 60},{laufzeit % 60}");
            Laufzeit = (laufzeit > 60) ? hours : laufzeit;
        }

        //get , set Cast
        public string get_Cast()
        {
            string castlist = "";
            if (Cast.Length > 0)
            {
                for (int i = 0; i < Cast.Length; i++)
                {
                    castlist += $"\n{Cast[i].ToString()}";
                }
            }
            return castlist;
        }
        public void set_Cast(string cast) { Cast = cast.Split(','); }

        //get , set Sprache
        public string get_Sprache() { return Sprache; }
        public void set_Spracher(string sprache) { Sprache = sprache; }

        //get , set FSK
        public int get_FSK() { return FSK; }
        public void set_FSK(int fsk) { FSK = fsk; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //test example
            Film f = new Film();
            f.set_Title("Bube Dame König grAS");
            f.set_Erscheinungsjahr(1998);
            f.set_Genre("Crime");
            f.set_Laufzeit(107);
            f.set_Cast("Jason Flemyng,Jason Statham,Nick Moran,Dexter Fletcher,Steven Mackintosh,Vinnie Jones");

            Console.WriteLine($"{f.get_Title()}");
            Console.WriteLine($"{f.get_Erscheinungsjahr()}");
            Console.WriteLine($"{f.get_Genre()}");
            Console.WriteLine($"{f.get_Laufzeit()}");
            Console.WriteLine($"{f.get_Cast()}");

        }
    }
}
