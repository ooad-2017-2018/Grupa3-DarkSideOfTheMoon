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
    public sealed partial class FormaDetektiv : Page
    {
        public FormaDetektiv()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava)); 
        }


        private void kliknuto(object sender, RoutedEventArgs e)
        {
            izvjestaj.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(izvjestaj.Text == "")
            {
                MessageDialog msgDialog = new MessageDialog("Morate napisati izvjestaj.");
                msgDialog.ShowAsync();
            }
            else
            {
                string info = lista.SelectedItem.ToString();
                Zahtjev novi = new Zahtjev(VrstaZahtjeva.Hakiranje, info);
            }
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(lista.SelectedItems.Count == 0)
            {
                MessageDialog msgDialog = new MessageDialog("Morate odabrati zahtjev.");
                msgDialog.ShowAsync();
            }
            else
            {
                string info = lista.SelectedItem.ToString();
                Zahtjev novi = new Zahtjev(VrstaZahtjeva.Hakiranje, info);
            }
          
        }

        private void detektiv_Loaded(object sender, RoutedEventArgs e)
        {
            for(int index = 0; index<GlobalnaMafija.mafija.listaZahtjevaPracenje.Count; index++)
            {
                
                    lista.Items.Add(GlobalnaMafija.mafija.listaZahtjevaPracenje[index].ToString());
                
            }
           
        }

        private void lista_ItemClick(object sender, ItemClickEventArgs e)
        {
            detalji.Text = GlobalnaMafija.mafija.listaZahtjevaPracenje[lista.SelectedIndex].ispisiInfo();
        }
    }
}
