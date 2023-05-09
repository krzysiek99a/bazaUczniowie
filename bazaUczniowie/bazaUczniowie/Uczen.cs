using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace bazaUczniowie
{
    internal class Uczen
    {
        public Uczen() { }
        public Uczen(string imie, string nazwisko, int klasa, string plec, string miasto)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Klasa = klasa;
            Plec = plec;
            Miasto = miasto;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Klasa { get; set; }
        public string Plec { get; set; }
        public string Miasto { get; set; }

    }
}
