////
//Project Name : Clash_of_Clans
//File Type : C# OOP
//Author : Zaccaria El Kacimi
//Created On : 15/04/2024 - 16/04/2024
//Copy Rights : Zaccaria El Kacimi
////


using System;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Clash_of_Clans
{
    class Held
    {
        private string Name;
        private int Level;
        private int Kosten;
        private int Trefferpunkte;
        private int Regenerationszeit;
        private int Schaden;
        private string Spezialfähigkeit;

        public Held()
        {
            Name = "";
            Level = 0;
            Kosten = 0;
            Trefferpunkte = 0;
            Regenerationszeit = 0;
            Schaden = 0;
            Spezialfähigkeit = "";
        }

        public Held(string name, int level)
        {
            Name = name;
            Level = level;
            Kosten = 0;
            Trefferpunkte = 0;
            Regenerationszeit = 0;
            Schaden = 0;
            Spezialfähigkeit = "";
        }

        public Held(string name, int level, int kosten, int trefferpunkte)
        {
            Name = name;
            Level = level;
            Kosten = kosten;
            Trefferpunkte = trefferpunkte;
            Regenerationszeit = 0;
            Schaden = 0;
            Spezialfähigkeit = "";
        }

        public Held(string name, int level, int kosten, int trefferpunkte, int regenerationszeit, int schaden, string spezialfähigkeit)
        {
            Name = name;
            Level = level;
            Kosten = kosten;
            Trefferpunkte = trefferpunkte;
            Regenerationszeit = regenerationszeit;
            Schaden = schaden;
            Spezialfähigkeit = spezialfähigkeit;

        }



        //get , set Name
        public string get_Name() { return Name; }
        public void set_Name(string name) { Name = name; }

        //get , set Level
        public int get_Level() { return Level; }
        public void set_Level(int level) { Level = level; }

        //get , set Kosten
        public int get_Kosten() { return Kosten; }
        public void set_Kosten(int kosten) { Kosten = kosten; }

        //get , set Trefferpunkte
        public int get_Trefferpunkte() { return Trefferpunkte; }
        public void set_Trefferpunkte(int trefferpunkte) { Trefferpunkte = trefferpunkte; }

        //get , set Regenerationszeit
        public int get_Regenerationszeit() { return Regenerationszeit; }
        public void set_Regenerationszeit(int regenerationszeit) { Regenerationszeit = regenerationszeit; }

        //get , set Schaden
        public int get_Schaden() { return Schaden; }
        public void set_Schaden(int schaden) { Schaden = schaden; }

        //get , set Level
        public string get_Spezialfähigkeit() { return Spezialfähigkeit; }
        public void set_Spezialfähigkeit(string spezialfähigkeit) { Spezialfähigkeit = spezialfähigkeit; }
    }

    class Trupp
    {
        private string Name;
        private int Level;
        private int Entwicklungskosten;
        private int Baukosten;
        private int Elixier;
        private int Trefferpunkte;
        private int Schaden;
        private int Bewegungsgeschwindigkeit;
        private int Angriffsgeschwindigkeit;
        private int Reichweite;
        private int Wohnraum;
        private int Einzel;

        public Trupp()
        {
            Name = "";
            Level = 0;
            Entwicklungskosten = 0;
            Baukosten = 0;
            Elixier = 0;
            Trefferpunkte = 0;
            Schaden = 0;
            Bewegungsgeschwindigkeit = 0;
            Angriffsgeschwindigkeit = 0;
            Reichweite = 0;
            Wohnraum = 0;
            Einzel = 0;
        }

        public Trupp(string name, int level, int entwicklungskosten, int baukosten)
        {
            Name = name;
            Level = level;
            Entwicklungskosten = entwicklungskosten;
            Baukosten = baukosten;
            Elixier = 0;
            Trefferpunkte = 0;
            Schaden = 0;
            Bewegungsgeschwindigkeit = 0;
            Angriffsgeschwindigkeit = 0;
            Reichweite = 0;
            Wohnraum = 0;
            Einzel = 0;
        }

        public Trupp(string name, int level, int entwicklungskosten, int baukosten, int elixier, int reichweite)
        {
            Name = name;
            Level = level;
            Entwicklungskosten = entwicklungskosten;
            Baukosten = baukosten;
            Elixier = elixier;
            Trefferpunkte = 0;
            Schaden = 0;
            Bewegungsgeschwindigkeit = 0;
            Angriffsgeschwindigkeit = 0;
            Reichweite = reichweite;
            Wohnraum = 0;
            Einzel = 0;

        }

        public Trupp(string name, int level, int entwicklungskosten, int baukosten, int elixier, int treffpunkte, int schaden, int bewegungsgeschwindigkeit, int angriffsgeschwindigkeit, int reichweite, int wohnraum, int einzel)
        {
            Name = name;
            Level = level;
            Entwicklungskosten = entwicklungskosten;
            Baukosten = baukosten;
            Elixier = elixier;
            Trefferpunkte = treffpunkte;
            Schaden = schaden;
            Bewegungsgeschwindigkeit = bewegungsgeschwindigkeit;
            Angriffsgeschwindigkeit = angriffsgeschwindigkeit;
            Reichweite = reichweite;
            Wohnraum = wohnraum;
            Einzel = einzel;

        }

        //get , set Name
        public string get_Name() { return Name; }
        public void set_Name(string name) { Name = name; }

        //get , set Level
        public int get_Level() { return Level; }
        public void set_Level(int level) { Level = level; }

        //get , set Entwicklungskosten
        public int get_Entwicklungskosten() { return Entwicklungskosten; }
        public void set_Entwicklungskosten(int entwicklungskosten) { Entwicklungskosten = entwicklungskosten; }

        //get , set Baukosten
        public int get_Baukosten() { return Baukosten; }
        public void set_Baukosten(int baukosten) { Baukosten = baukosten; }

        //get , set Elixier
        public int get_Elixier() { return Elixier; }
        public void set_Elixier(int elixier) { Elixier = elixier; }

        //get , set Trefferpunkte
        public int get_Trefferpunkte() { return Trefferpunkte; }
        public void set_Trefferpunkte(int treffpunkte) { Trefferpunkte = treffpunkte; }

        //get , set Schaden
        public int get_Schaden() { return Schaden; }
        public void set_Schaden(int schaden) { Schaden = schaden; }

        //get , set Bewegungsgeschwindigkeit
        public int get_Bewegungsgeschwindigkeit() { return Bewegungsgeschwindigkeit; }
        public void set_Bewegungsgeschwindigkeit(int bewegungsgeschwindigkeit) { Bewegungsgeschwindigkeit = bewegungsgeschwindigkeit; }

        //get , set Angriffsgeschwindigkeit
        public int get_Angriffsgeschwindigkeit() { return Angriffsgeschwindigkeit; }
        public void set_Angriffsgeschwindigkeit(int angriffsgeschwindigkeit) { Angriffsgeschwindigkeit = angriffsgeschwindigkeit; }

        //get , set Reichweite
        public int get_Reichweite() { return Reichweite; }
        public void set_Reichweite(int reichweite) { Reichweite = reichweite; }

        //get , set Wohnraum
        public int get_Wohnraum() { return Wohnraum; }
        public void set_Wohnraum(int wohnraum) { Wohnraum = wohnraum; }

        //get , set Einzel
        public int get_Einzel() { return Einzel; }
        public void set_Einzel(int einzel) { Einzel = einzel; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //test example
            Held h = new Held();
            h.set_Name("Riesen");
            h.set_Level(5);
            h.set_Schaden(31);
            h.set_Trefferpunkte(670);
            h.set_Kosten(2250);

            Console.WriteLine($"name: {h.get_Name()}");
            Console.WriteLine($"level: {h.get_Level()}");
            Console.WriteLine($"schaden: {h.get_Schaden()}");
            Console.WriteLine($"treffpunkte: {h.get_Trefferpunkte()}");
            Console.WriteLine($"kosten: {h.get_Kosten()}");


            Console.WriteLine();
            Trupp t = new Trupp();
            t.set_Name("Barbar");
            t.set_Level(4);
            t.set_Entwicklungskosten(200000);
            t.set_Schaden(18);
            t.set_Trefferpunkte(85);

            Console.WriteLine($"name: {t.get_Name()}");
            Console.WriteLine($"level: {t.get_Level()}");
            Console.WriteLine($"entwicklung kosten: {t.get_Entwicklungskosten()}");
            Console.WriteLine($"schaden: {t.get_Schaden()}");
            Console.WriteLine($"trefferpunkte: {t.get_Trefferpunkte()}");
        }
    }
}
