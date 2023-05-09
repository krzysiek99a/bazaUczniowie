using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bazaUczniowie
{
    public partial class MainPage : ContentPage
    {
        string pathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) , "uczniowie.db");
        SQLiteConnection bazaUczniowie;
        public MainPage()
        {
            InitializeComponent();
            bazaUczniowie = new SQLiteConnection(pathDB);
            bazaUczniowie.CreateTable<Uczen>();
        }

        private void Dodaj_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dodaj(bazaUczniowie));
        }

        private void Wszyscy_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Wszyscy(bazaUczniowie));
        }
    }
}
