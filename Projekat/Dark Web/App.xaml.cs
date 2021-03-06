﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
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
using Dark_Web.View;


namespace Dark_Web
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    /// 
    

    class mafijasi
    {
        public string id
        {
            get;
            set;
        }
        public string ime
        {
            get;
            set;
        }
        public string prezime
        {
            get;
            set;
        }
        public string email
        {
            get;
            set;
        }
        public string adresaStanovanja
        {
            get;
            set;
        }
        public int brojTelefona
        {
            get;
            set;
        }
        public string korisnickoIme
        {
            get;
            set;
        }
        public string lozinka
        {
            get;
            set;
        }
        public string funkcija
        {
            get;
            set;
        }

    }
    sealed partial class App : Application
    {
        public static MobileServiceClient MobileService = new MobileServiceClient("https://dark--web.azurewebsites.net");

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
           // Hardkodirani izvjestaji
           //Hakiranje
            Izvjestaj noviIzvjestaj = new Izvjestaj(VrstaIzvjestaja.Hakiranje,"Izvjestaj o hakiranju 1"); 
            GlobalnaMafija.mafija.listaIzvjestajaHakiranje.Add(noviIzvjestaj);
            Izvjestaj noviIzvjestaj1 = new Izvjestaj(VrstaIzvjestaja.Hakiranje, "Izvjestaj o hakiranju 2");
            GlobalnaMafija.mafija.listaIzvjestajaHakiranje.Add(noviIzvjestaj1);
            //Pracenje
            Izvjestaj noviIzvjestaj2 = new Izvjestaj(VrstaIzvjestaja.Pracenje, "Izvjestaj o pracenju 1");
            GlobalnaMafija.mafija.listaIzvjestajaPracenje.Add(noviIzvjestaj2);
            Izvjestaj noviIzvjestaj3 = new Izvjestaj(VrstaIzvjestaja.Pracenje, "Izvjestaj o pracenju 2");
            GlobalnaMafija.mafija.listaIzvjestajaPracenje.Add(noviIzvjestaj3);
            //Utjerivanje duga
            Izvjestaj noviIzvjestaj4 = new Izvjestaj(VrstaIzvjestaja.UtjerivanjeDuga, "Izvjestaj o utjerivanju duga 1");
            GlobalnaMafija.mafija.listaIzvjestajaUtjerivanjeDuga.Add(noviIzvjestaj4);
            Izvjestaj noviIzvjestaj5 = new Izvjestaj(VrstaIzvjestaja.UtjerivanjeDuga, "Izvjestaj o utjerivanju duga 2");
            GlobalnaMafija.mafija.listaIzvjestajaUtjerivanjeDuga.Add(noviIzvjestaj5);
            //naplata
            Izvjestaj noviIzvjestaj6 = new Izvjestaj(VrstaIzvjestaja.Naplata, "Izvjestaj o naplati 1");
            GlobalnaMafija.mafija.listaIzvjestajaNaplata.Add(noviIzvjestaj6);
            Izvjestaj noviIzvjestaj7 = new Izvjestaj(VrstaIzvjestaja.Naplata, "Izvjestaj o naplati 2");
            GlobalnaMafija.mafija.listaIzvjestajaNaplata.Add(noviIzvjestaj7);

            //Hardkodirani zahtjevi
            //Brisanje robe
            Zahtjev noviZahtjev = new Zahtjev(VrstaZahtjeva.BrisanjeRobe, "Zahtjev za brisanje robe 1");
            GlobalnaMafija.mafija.listaZahtjevaBrisanje.Add(noviZahtjev); 
            Zahtjev noviZahtjev1 = new Zahtjev(VrstaZahtjeva.BrisanjeRobe, "Zahtjev za brisanje robe 2");
            GlobalnaMafija.mafija.listaZahtjevaBrisanje.Add(noviZahtjev1);
            //Hakiranje
            Zahtjev noviZahtjev2 = new Zahtjev(VrstaZahtjeva.Hakiranje, "Zahtjev za hakiranje 1");
            GlobalnaMafija.mafija.listaZahtjevaHakiranje.Add(noviZahtjev2);
            Zahtjev noviZahtjev3 = new Zahtjev(VrstaZahtjeva.Hakiranje, "Zahtjev za hakiranje 2");
            GlobalnaMafija.mafija.listaZahtjevaHakiranje.Add(noviZahtjev3);
            //Falsifikacija dokumenata
            Zahtjev noviZahtjev4 = new Zahtjev(VrstaZahtjeva.FalsifikacijaDokumenata, "Zahtjev za falsificiranje dokumenata 1");
            GlobalnaMafija.mafija.listaZahtjevaFalsifikator.Add(noviZahtjev4);
            Zahtjev noviZahtjev5 = new Zahtjev(VrstaZahtjeva.FalsifikacijaDokumenata, "Zahtjev za falsificiranje dokumenata 2");
            GlobalnaMafija.mafija.listaZahtjevaFalsifikator.Add(noviZahtjev5);
            //Privatni detektiv
            Zahtjev noviZahtjev6 = new Zahtjev(VrstaZahtjeva.IznajmljivanjeDetektiva, "Zahtjev za privatnog detektiva 1");
            GlobalnaMafija.mafija.listaZahtjevaPracenje.Add(noviZahtjev6);
            Zahtjev noviZahtjev7 = new Zahtjev(VrstaZahtjeva.IznajmljivanjeDetektiva, "Zahtjev za privatnog detektiva 2");
            GlobalnaMafija.mafija.listaZahtjevaPracenje.Add(noviZahtjev7);
            //Utjerivanje duga
            Zahtjev noviZahtjev8 = new Zahtjev(VrstaZahtjeva.UtjerivanjeDuga, "Zahtjev za utjerivanje duga 1");
            GlobalnaMafija.mafija.listaZahtjevaUtjerivanje.Add(noviZahtjev8);
            Zahtjev noviZahtjev9 = new Zahtjev(VrstaZahtjeva.UtjerivanjeDuga, "Zahtjev za utjerivanje duga 2");
            GlobalnaMafija.mafija.listaZahtjevaUtjerivanje.Add(noviZahtjev9);
            //Unos i naplata
            Zahtjev noviZahtjev10 = new Zahtjev(VrstaZahtjeva.UnosINaplataRobe, "Zahtjev za unos nove robe 1");
            GlobalnaMafija.mafija.listaZahtjevaUnosNove.Add(noviZahtjev10);
            Zahtjev noviZahtjev11 = new Zahtjev(VrstaZahtjeva.UnosINaplataRobe, "Zahtjev za unos nove robe 2");
            GlobalnaMafija.mafija.listaZahtjevaUnosNove.Add(noviZahtjev11);

            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // When the navigation stack isn't restored navigate to the first page,
                    // configuring the new page by passing required information as a navigation
                    // parameter
                    rootFrame.Navigate(typeof(Prijava), e.Arguments);
                }
                // Ensure the current window is active
                Window.Current.Activate();
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
