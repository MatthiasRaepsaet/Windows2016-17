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

        private String temperatureA;

        public String TemperatureA
        {
            get { return temperatureA; }
            set { temperatureA = value; RaisePropertyChanged(); }
        }

        private String cloudsA;

        public String CloudsA
        {
            get { return cloudsA; }
            set { cloudsA = value; RaisePropertyChanged(); }
        }

        private String humidityA;

        public String HumidityA
        {
            get { return humidityA; }
            set { humidityA = value; RaisePropertyChanged(); }
        }

        private String weatherKindA;

        public String WeatherKindA
        {
            get { return weatherKindA; }
            set { weatherKindA = value; RaisePropertyChanged(); }
        }

        private String temperatureG;

        public String TemperatureG
        {
            get { return temperatureG; }
            set { temperatureG = value; RaisePropertyChanged(); }
        }

        private String cloudsG;

        public String CloudsG
        {
            get { return cloudsG; }
            set { cloudsG = value; RaisePropertyChanged(); }
        }

        private String humidityG;

        public String HumidityG
        {
            get { return humidityG; }
            set { humidityG = value; RaisePropertyChanged(); }
        }

        private String weatherKindG;

        public String WeatherKindG
        {
            get { return weatherKindG; }
            set { weatherKindG = value; RaisePropertyChanged(); }
        }
        public async void CalculateWeather()
        {
            WeatherInfo weatherAalst = await new OpenWeatherClient("a91580e2d1ba4f9ac7f7e5d7a64af781").GetByCityNameAsync("Aalst");
            weatherAalst.temperature.ToCelsius();

            TemperatureA = weatherAalst.temperature.value.ToString() + "°C"; 
            CloudsA = weatherAalst.clouds.name;
            HumidityA = weatherAalst.humidity.value.ToString() + "%";
            WeatherKindA = weatherAalst.weather.value;

            WeatherInfo weatherGent = await new OpenWeatherClient("a91580e2d1ba4f9ac7f7e5d7a64af781").GetByCityNameAsync("Gent");
            weatherGent.temperature.ToCelsius();

            TemperatureG = weatherGent.temperature.value.ToString() + "°C";
            CloudsG = weatherGent.clouds.name;
            HumidityG = weatherGent.humidity.value.ToString() + "%";
            WeatherKindG = weatherGent.weather.value;

        }

    }
}
