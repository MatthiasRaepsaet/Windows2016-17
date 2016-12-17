using OpenWeatherNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OpendeurdagApp.Models
{
    class Weather : INotifyPropertyChanged
    {
        public Weather()
        {
            CalculateWeather();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double temperature;

        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; RaisePropertyChanged(); }
        }

        private String clouds;

        public String Clouds
        {
            get { return clouds; }
            set { clouds = value; RaisePropertyChanged(); }
        }

        private String humidity;

        public String Humidity
        {
            get { return humidity; }
            set { humidity = value; RaisePropertyChanged(); }
        }

        private String weatherKind;

        public String WeatherKind
        {
            get { return weatherKind; }
            set { weatherKind = value; RaisePropertyChanged(); }
        }

        public async void CalculateWeather()
        {
            WeatherInfo weather = await new OpenWeatherClient("a91580e2d1ba4f9ac7f7e5d7a64af781").GetByCityNameAsync("Aalst");
            weather.temperature.ToCelsius();

            Temperature = weather.temperature.value; 
            Clouds = weather.clouds.name;
            Humidity = weather.humidity.value.ToString() + "%";
            WeatherKind = weather.weather.value; 

        }

    }
}
