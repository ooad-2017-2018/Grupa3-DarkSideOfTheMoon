using Microsoft.WindowsAzure.MobileServices;
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
    public sealed partial class FormaUprava : Page
    {
        IMobileServiceTable<mafijasi> userTableObj = App.MobileService.GetTable<mafijasi>();
        

        public FormaUprava()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Ime.Text == "" || Prezime.Text == "" || adresaStanovanja.Text == "" || brojTelefona.Text == "" || Email.Text == "" || korisnickoIme.Text == "" || lozinka.Text == "")
            {
                MessageDialog msgDialog = new MessageDialog("Nepotpuni podaci");
                msgDialog.ShowAsync();
            }

            else
            {
                try
                {
                    mafijasi obj = new mafijasi();
                    obj.ime = Ime.Text;
                    obj.prezime = Prezime.Text;
                    obj.email = Email.Text;
                    obj.adresaStanovanja = adresaStanovanja.Text;
                    int pom;
                    int.TryParse(brojTelefona.Text, out pom);
                    obj.brojTelefona = pom;
                    obj.korisnickoIme = korisnickoIme.Text;
                    obj.lozinka = lozinka.Text;
                    userTableObj.InsertAsync(obj);
                    MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog uposlenika.");
                    msgDialog.ShowAsync();
                }
                catch (Exception ex)
                {

                    MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                    msgDialogError.ShowAsync();
                }
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(naziv.Text == "" || cijena.Text == "" || opis.Text == "")
            {
                MessageDialog msgDialog = new MessageDialog("Nepotpuni podaci");
                msgDialog.ShowAsync();
            }
            else
            {
                if (d.IsChecked==true)
                {
                    Roba novaRoba = new Roba(VrstaRobe.Dijamant, Convert.ToDouble(cijena.ToString()), naziv.Text, opis.Text);
                    GlobalnaMafija.mafija.listaRobe.Add(novaRoba);
                }
                else if(a.IsChecked==true){
                    Roba novaRoba = new Roba(VrstaRobe.Antikvitet, Convert.ToDouble(cijena.ToString()), naziv.Text, opis.Text);
                    GlobalnaMafija.mafija.listaRobe.Add(novaRoba);
                }
                else if (s.IsChecked == true)
                {
                    Roba novaRoba = new Roba(VrstaRobe.Slika, Convert.ToDouble(cijena.ToString()), naziv.Text, opis.Text);
                    GlobalnaMafija.mafija.listaRobe.Add(novaRoba);
                }
                else
                {
                    Roba novaRoba = new Roba(VrstaRobe.Nakit, Convert.ToDouble(cijena.ToString()), naziv.Text, opis.Text);
                    GlobalnaMafija.mafija.listaRobe.Add(novaRoba);
                }
                 
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if(lista.SelectedItems.Count == 0 || razlog.Text=="")
            {
                MessageDialog msgDialog = new MessageDialog("Morate odabrati robu i navesti razlog brisanja.");
                msgDialog.ShowAsync();
            }
            else
            {
                Zahtjev zahtjev = new Zahtjev(VrstaZahtjeva.BrisanjeRobe, razlog.Text); 
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if(lista.SelectedItems.Count == 0)
            {
                MessageDialog msgDialog = new MessageDialog("Morate odabrati zahtjev.");
                msgDialog.ShowAsync();
            }
            else
            {
                Zahtjev zahtjev = new Zahtjev(VrstaZahtjeva.UnosINaplataRobe, lista.SelectedItem.ToString());
                GlobalnaMafija.mafija.listaZahtjeva.RemoveAt(lista.SelectedIndex);
                GlobalnaMafija.mafija.listaZahtjeva.Add(zahtjev);
            }
            
           
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (lista.SelectedItems.Count == 0)
            {
                MessageDialog msgDialog = new MessageDialog("Morate odabrati zahtjev.");
                msgDialog.ShowAsync();
            }
            else
            {
                GlobalnaMafija.mafija.listaZahtjeva.RemoveAt(lista.SelectedIndex);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if(lista2.SelectedItems.Count == 0)
            {
                MessageDialog msgDialog = new MessageDialog("Morate odabrati zahtjev.");
                msgDialog.ShowAsync();
            }
            else
            {
                string info = lista.SelectedItem.ToString();
                Zahtjev zahtjev = new Zahtjev(VrstaZahtjeva.UtjerivanjeDuga, info);
                GlobalnaMafija.mafija.listaIzvjestaja.RemoveAt(lista.SelectedIndex); 
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
