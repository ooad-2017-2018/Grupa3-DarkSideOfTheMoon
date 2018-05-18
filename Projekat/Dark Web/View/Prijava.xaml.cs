using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Dark_Web.View;
using Windows.UI.Popups;
using Dark_Web.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Dark_Web.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Prijava : Page
    {
        public Prijava()
        {
            this.InitializeComponent();
        }
        public void pocisti()
        {
            KorisnickoIme.Text = "";
            Lozinka.Password = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(KorisnickoIme.Text == "" || Lozinka.Password.ToString() == "")
            {
                MessageDialog msgDialog = new MessageDialog("Polje korisnicko ime ili lozinka su prazni!");
                msgDialog.ShowAsync();
                pocisti(); 
            }
            else if (KorisnickoIme.Text == "uprava" && Lozinka.Password.ToString()=="uprava")
                this.Frame.Navigate(typeof(FormaUprava));
            else if (KorisnickoIme.Text == "detektiv" && Lozinka.Password.ToString() == "detektiv")
                this.Frame.Navigate(typeof(FormaDetektiv));
            else if (KorisnickoIme.Text == "dostavljac" && Lozinka.Password.ToString() == "dostavljac")
                this.Frame.Navigate(typeof(FormaDostavljac));
            else if (KorisnickoIme.Text == "haker" && Lozinka.Password.ToString() == "haker")
                this.Frame.Navigate(typeof(FormaHaker));
            else if (KorisnickoIme.Text == "dobavljac" && Lozinka.Password.ToString() == "dobavljac")
                this.Frame.Navigate(typeof(FormaDobavljac));
            else if (KorisnickoIme.Text == "falsifikator" && Lozinka.Password.ToString() == "falsifikator")
                this.Frame.Navigate(typeof(FormaFalsifikator));
            else if (KorisnickoIme.Text == "utjerivac" && Lozinka.Password.ToString() == "utjerivac")
                this.Frame.Navigate(typeof(FormaUtjerivacDuga));
            else
            {
                MessageDialog msgDialog = new MessageDialog("Korisnicko ime ili lozinka nisu ispravni");
                msgDialog.ShowAsync();
                pocisti(); 
            }
        }

        private void Prijava1_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
