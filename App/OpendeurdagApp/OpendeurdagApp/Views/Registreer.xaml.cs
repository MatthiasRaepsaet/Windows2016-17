using OpendeurdagApp.Models;
using OpendeurdagApp.ViewModels;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OpendeurdagApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registreer : Page
    {
        private Gebruiker user; 
        public Registreer()
        {
            this.InitializeComponent();
        }

        private void Registreren(object sender, RoutedEventArgs e)
        {
            String Voornaam, Achternaam, Email, Paswoord, Straat, Huisnummer, Gemeente, Postcode, TelefoonNummer, GsmNummer, VoorkeursCampus, VoorkeursOpleiding;

            Voornaam = voornaam.Text;
            Achternaam = achternaam.Text;
            Email = email.Text;
            Paswoord = paswoord.Password;
            Straat = straat.Text;
            Huisnummer = huisnummer.Text;
            Gemeente = gemeente.Text;
            Postcode = postcode.Text;
            TelefoonNummer = telefoonNummer.Text;
            GsmNummer = gsmNummer.Text;

            ComboBoxItem campus = (ComboBoxItem) voorkeursCampus.SelectedItem;
            ComboBoxItem opleiding = (ComboBoxItem)voorkeursOpleiding.SelectedItem;

            VoorkeursCampus = campus.Content.ToString(); 
            VoorkeursOpleiding = opleiding.Content.ToString();

            user = new Gebruiker(Voornaam, Achternaam, Email, Paswoord, Straat, Huisnummer, Gemeente, Postcode, TelefoonNummer, GsmNummer, VoorkeursCampus, VoorkeursOpleiding);

            ViewModel.RegisterAndLogIn(user); 
        }
    }
}
