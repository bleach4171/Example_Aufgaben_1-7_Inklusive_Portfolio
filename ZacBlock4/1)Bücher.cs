////
//Project Name : Bücher
//File Type : C# OOP
//Author : Zaccaria El Kacimi
//Created On : 15/04/2024
//Copy Rights : Zaccaria El Kacimi
////

using System;

namespace Bücher
{
    class Buch
    {
        private string Title;
        private string Author;
        private int ISBN;
        private string Genre;
        private string Verlag;
        private int Erscheinungsjahr;
        private string Kommentar;

        public Buch()
        {
            Title = "";
            Author = "";
            ISBN = 0;
            Genre = "";
            Verlag = "";
            Erscheinungsjahr = 0;
            Kommentar = "";
        }

        public Buch(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = 0;
            Genre = "";
            Verlag = "";
            Erscheinungsjahr = 0;
            Kommentar = "";
        }

        public Buch(string title, string author, int isbn, int erscheinungsjahr)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = "";
            Verlag = "";
            Erscheinungsjahr = erscheinungsjahr;
            Kommentar = "";
        }

        public Buch(string title, string author, int isbn, string genre, string verlag, int erscheinungsjahr, string kommentar)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            Verlag = verlag;
            Erscheinungsjahr = erscheinungsjahr;
            Kommentar = kommentar;
        }



        //get , set Title
        public string get_Title() { return Title; }
        public void set_Title(string title) { Title = title; }

        //get , set Author
        public string get_Author() { return Author; }
        public void set_Author(string author) { Author = author; }

        //get , set ISBN
        public int get_ISBN() { return ISBN; }
        public void set_ISBN(int isbn) { ISBN = isbn; }

        //get , set Genre
        public string get_Genre() { return Genre; }
        public void set_Genre(string genre) { Genre = genre; }

        //get , set Verlags
        public string get_Verlag() { return Genre; }
        public void set_Verlag(string verlag) { Verlag = verlag; }

        //get , set Erscheinungsjahr
        public int get_Erscheinungsjahr() { return Erscheinungsjahr; }
        public void set_Erscheinungsjahr(int erscheinungsjahr) { Erscheinungsjahr = erscheinungsjahr; }

        //get , set Kommentar
        public string get_Kommentar() { return Kommentar; }
        public void set_Kommentar(string kommentar) { Kommentar = kommentar; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //test example
            Buch b = new Buch();
            b.set_Title("Herr der Ringe");
            b.set_Author("J. R. R. Tolkien");
            b.set_Genre("Fantasy");
            b.set_Erscheinungsjahr(1954);

            Console.WriteLine($"{b.get_Title()}");
            Console.WriteLine($"{b.get_Author()}");
            Console.WriteLine($"{b.get_Genre()}");
            Console.WriteLine($"{b.get_Erscheinungsjahr()}");

        }
    }
}
