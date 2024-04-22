////
//Project Name : Schauspieler
//File Type : C# OOP
//Author : Zaccaria El Kacimi
//Created On : 15/04/2024
//Copy Rights : Zaccaria El Kacimi
////

using System;

namespace Schauspiel
{
    class Schauspieler
    {
        private string Vorname;
        private string Nachname;
        private string Spitzname;
        private string Geburtsort;
        private string Geburtsdatum;
        private string Nationalitaet;
        private double Groesse;

        public Schauspieler()
        {
            Vorname = "";
            Nachname = "";
            Spitzname = "";
            Geburtsort = "";
            Geburtsdatum = "";
            Nationalitaet = "";
            Groesse = 0;
        }

        public Schauspieler(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
            Spitzname = "";
            Geburtsort = "";
            Geburtsdatum = "";
            Nationalitaet = "";
            Groesse = 0;
        }

        public Schauspieler(string vorname, string nachname, string spitzname, double groesse)
        {
            Vorname = vorname;
            Nachname = nachname;
            Spitzname = spitzname;
            Geburtsort = "";
            Geburtsdatum = "";
            Nationalitaet = "";
            Groesse = groesse;
        }

        public Schauspieler(string vorname, string nachname, string spitzname, string geburtsort, string geburtsdatum, string nationalitaet, double groesse)
        {
            Vorname = vorname;
            Nachname = nachname;
            Spitzname = spitzname;
            Geburtsort = geburtsort;
            Geburtsdatum = geburtsdatum;
            Nationalitaet = nationalitaet;
            Groesse = groesse;

        }

        //get , set Vorname
        public string get_Vorname() { return Vorname; }
        public void set_Vorname(string vorname) { Vorname = vorname; }

        //get , set Nachname
        public string get_Nachname() { return Nachname; }
        public void set_Nachname(string nachname) { Nachname = nachname; }

        //get , set Spitzname
        public string get_Spitzname() { return Spitzname; }
        public void set_Spitzname(string spitzname) { Spitzname = spitzname; }

        //get , set Geburtsort
        public string get_Geburtsort() { return Geburtsort; }
        public void set_Geburtsort(string geburtsort) { Geburtsort = geburtsort; }

        //get , set Geburtsdatum
        public string get_Geburtsdatum() { return Geburtsdatum; }
        public void set_Geburtsdatum(string geburtsdatum) { Geburtsdatum = geburtsdatum; }

        //get , set Nationalitaet
        public string get_Nationalitaet() { return Nationalitaet; }
        public void set_Nationalitaet(string nationalitaet) { Nationalitaet = nationalitaet; }

        //get , set Groesse
        public double get_Groesse() { return Groesse; }
        public void set_Groesse(double groesse) { Groesse = groesse; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //test example
            Schauspieler b = new Schauspieler();
            b.set_Vorname("Harrison");
            b.set_Nachname("Ford");
            b.set_Geburtsort("Chicago, Illnois, USA");
            b.set_Geburtsdatum("13-07-1942");
            b.set_Nationalitaet("American");
            b.set_Groesse(1.85);

            Console.WriteLine($"{b.get_Vorname()}");
            Console.WriteLine($"{b.get_Nachname()}");
            Console.WriteLine($"{b.get_Geburtsort()}");
            Console.WriteLine($"{b.get_Geburtsdatum()}");
            Console.WriteLine($"{b.get_Nationalitaet()}");
            Console.WriteLine($"{b.get_Groesse()} m");


        }
    }
}
