using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bazaUczniowie
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Wszyscy : ContentPage
    {
        SQLiteConnection bazaUczniowie;
        public Wszyscy(SQLiteConnection baza)
        {
            InitializeComponent();
            bazaUczniowie = baza;

            List<Uczen> wszyscyUczniowie = bazaUczniowie.Table<Uczen>().ToList();

            listaW.ItemsSource = wszyscyUczniowie;
        }
    }
}