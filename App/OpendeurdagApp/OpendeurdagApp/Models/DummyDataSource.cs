
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpendeurdagApp.Models
{
    public static class DummyDataSource
    {
        public static List<News> News { get; set; } = new List<News>()
        {
            new News() {Title="Aankoop Hololens",Stad="Aalst",Description="Er is eindelijk beslist om een hololens aan te kopen."},
            new News() {Title="Pannekoekenverkoop",Stad="Gent",Description="Deze maandag worden er pannekoeken verkocht aan 1euro de stuk."},
            new News() {Title="Verjaardag Joeri",Stad="Algemeen",Description="Onze lievelingslector is jarig volgende week"}

        };


        public static List<Opleiding> Opleidingen { get; set; } = new List<Opleiding>()
        {
            new Opleiding() {OpleidingName="Toegepaste Informatica", OpleidingDescription= "Hier staat de description van een opleiding. Redelijk groto vak dus moet wel wat gezever in staan am i rite boys????????", Stad= "Aalst",OpleidingImage=""},
            new Opleiding() {OpleidingName="Office Management", OpleidingDescription= "Hier staat de description van een opleiding. Redelijk groto vak dus moet wel wat gezever in staan am i rite boys????????", Stad= "Aalst", OpleidingImage=""},
            new Opleiding() {OpleidingName="Toegepaste Informatica", OpleidingDescription= "Hier staat de description van een opleiding. Redelijk groto vak dus moet wel wat gezever in staan am i rite boys????????", Stad= "Gent", OpleidingImage=""}


        };
    }
}


