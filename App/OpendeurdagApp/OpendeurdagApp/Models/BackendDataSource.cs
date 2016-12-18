using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpendeurdagApp.Models
{
    public static class BackendDataSource
    {
        public static async void LoadBackendData()
        {
            HttpClient client = new HttpClient();
            //var json = await client.GetStringAsync(new Uri("http://localhost:16134/api/news"));
            //News = new List<News>(JsonConvert.DeserializeObject<List<News>>(json));

            //json = await client.GetStringAsync(new Uri("http://localhost:16134/api/gebruikers"));
            //Gebruikers = new List<Gebruiker>(JsonConvert.DeserializeObject<List<Gebruiker>>(json));

            //json = await client.GetStringAsync(new Uri("http://localhost:16134/api/opleidings"));
            //Opleidingen = new List<Opleiding>(JsonConvert.DeserializeObject<List<Opleiding>>(json));
        }

        public static List<News> News { get; set; }

        public static List<Opleiding> Opleidingen { get; set; }

        public static List<Gebruiker> Gebruikers { get; set; }
    }
}
