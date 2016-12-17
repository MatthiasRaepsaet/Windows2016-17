using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendApplication.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }

        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Gemeente { get; set; }
        public string Postcode { get; set; }

        public string TelefoonNummer { get; set; }
        public string GsmNummer { get; set; }

        public string VoorkeursCampus { get; set; }
        public string VoorkeursOpleiding { get; set; }
    }
}