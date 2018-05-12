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
     private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (KorisnickoIme.Text == "uprava" && Lozinka.Text == "uprava")
                this.Frame.Navigate(typeof(FormaUprava));
            else if (KorisnickoIme.Text == "detektiv" && Lozinka.Text == "detektiv")
                this.Frame.Navigate(typeof(FormaDetektiv));
            else if (KorisnickoIme.Text == "dostavljac" && Lozinka.Text == "dostavljac")
                this.Frame.Navigate(typeof(FormaDostavljac));
            else if (KorisnickoIme.Text == "haker" && Lozinka.Text == "haker")
                this.Frame.Navigate(typeof(FormaHaker));
        }
    }
}
