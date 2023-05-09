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
    public partial class Dodaj : ContentPage
    {
        SQLiteConnection bazaUczniowie;
        public Dodaj(SQLiteConnection baza)
        {
            InitializeComponent();
            this.bazaUczniowie = baza;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string plec;
            if (kobietaW.IsChecked)
            {
                plec = "Kobieta";
            } else plec = "Mężczyzna";


            Uczen nowyUczen = new Uczen(imieW.Text, nazwiskoW.Text, int.Parse(klasaW.Text), plec, miastoW.Text);
            bazaUczniowie.Insert(nowyUczen);
            imieW.Text = String.Empty;
            nazwiskoW.Text = String.Empty;
            klasaW.Text = String.Empty;
            miastoW.Text = String.Empty ;
        }
    }
}