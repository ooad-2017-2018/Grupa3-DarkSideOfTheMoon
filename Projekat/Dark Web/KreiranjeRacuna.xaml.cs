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
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Dark_Web
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KreiranjeRacuna : Page
    {
        IMobileServiceTable<mafijasi> userTableObj = App.MobileService.GetTable<mafijasi>();
        
           

            public KreiranjeRacuna()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            
                try
                {
                    mafijasi obj = new mafijasi();
                obj.ime = Ime.Text;
                    obj.prezime = Prezime.Text;
                    obj.email = Email.Text;
                obj.adresaStanovanja = adresaStanovanja.Text;
                int pom;
                 int.TryParse(brojTelefona.Text,out pom);
                obj.brojTelefona = pom;
                obj.korisnickoIme = korisnickoIme.Text;
                obj.lozinka = lozinka.Text;
                    userTableObj.InsertAsync(obj);
                    MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog studenta.");


                    msgDialog.ShowAsync();
                }
                catch (Exception ex)
                {
                    MessageDialog msgDialogError = new MessageDialog("Error : " +
                   ex.ToString());
                    msgDialogError.ShowAsync();
                }
            
        }
    }

    
    }
