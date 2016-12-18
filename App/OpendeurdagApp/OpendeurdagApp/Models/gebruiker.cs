using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OpendeurdagApp.Models
{
    public class Gebruiker : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private String voornaam;

        public String Voornaam
        {
            get { return voornaam; }
            set { voornaam = value; RaisePropertyChanged(); }
        }

        private String achternaam;

        public String Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; RaisePropertyChanged(); }
        }

        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; RaisePropertyChanged(); }
        }

        private bool isAdmin;

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }


        public String Straat { get; set; }
        public String Huisnummer { get; set; }
        public String Gemeente { get; set; }
        public String Postcode { get; set; }

        public String TelefoonNummer { get; set; }
        public String GsmNummer { get; set; }

        public String VoorkeursCampus { get; set; }
        public String VoorkeursOpleiding { get; set; }

        public Gebruiker(String voornaam, String achternaam, String email, String straat, String huisnummer,String gemeente, String postcode,String telefoonNummer,String gsmNummer,
            String voorkeursCampus, String voorkeursOpleiding )
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.email = email;
            Straat = straat;
            Huisnummer = huisnummer;
            Gemeente = gemeente;
            Postcode = postcode;
            TelefoonNummer = telefoonNummer;
            GsmNummer = gsmNummer;
            VoorkeursCampus = voorkeursCampus;
            VoorkeursOpleiding = voorkeursOpleiding;
        }

        public Gebruiker()
        {

        }

    }
}
