using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class FormaFalsifikator : Page
    {
        public FormaFalsifikator()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                
                this.Frame.Navigate(typeof(Prijava));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(ime.Text == "" || ime.Text == "Ime" || prezime.Text=="" || prezime.Text=="Prezime" || mjesto.Text=="" || mjesto.Text=="Mjesto rodjenja" || drzava.Text=="" || drzava.Text=="Drzavljanstvo" || prebivaliste.Text=="" || prebivaliste.Text == "Prebivaliste")
            {
                MessageDialog msgDialog = new MessageDialog("Nepotpuni podaci.");
                msgDialog.ShowAsync();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ime2.Text == "" || ime2.Text == "Ime" || prezime2.Text == "" || prezime2.Text == "Prezime" || mjesto2.Text == "" || mjesto2.Text == "Mjesto rodjenja" || drzava2.Text == "" || drzava2.Text == "Drzavljanstvo" || prebivaliste2.Text == "" || prebivaliste2.Text == "Prebivaliste")
            {
                MessageDialog msgDialog = new MessageDialog("Nepotpuni podaci.");
                msgDialog.ShowAsync();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (ime3.Text == "" || ime3.Text == "Ime" || prezime3.Text == "" || prezime3.Text == "Prezime" || mjesto3.Text == "" || mjesto3.Text == "Mjesto rodjenja" || drzava3.Text == "" || drzava3.Text == "Drzavljanstvo" || prebivaliste3.Text == "" || prebivaliste3.Text == "Prebivaliste")
            {
                MessageDialog msgDialog = new MessageDialog("Nepotpuni podaci.");
                msgDialog.ShowAsync();
            }
        }
    }
}
