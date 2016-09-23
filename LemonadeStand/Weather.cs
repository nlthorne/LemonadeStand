﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        List<string> weatherTypes;
        List<int> forecast;
        string weatherType;
        public int randomWeather;
        public int customerWeather;
        LemonadeStand lemonadestand;
        public Weather()
        {
            weatherTypes = new List<string>() { "Cold", "Rain", "Cloudy", "Sunny", "Hot" };
            forecast = new List<int>();
            lemonadestand = new LemonadeStand();
        }
        public int GetRandomWeather()
        {
            Random random = new Random();

            randomWeather = random.Next(0, weatherTypes.Count);
            weatherType = weatherTypes[randomWeather];
            return randomWeather;

        }
        public string GetWeatherName(int randomWeather)
        {
            return weatherTypes[randomWeather];
        }
        public void GetCustomerWeather()
        {
            customerWeather = randomWeather;
            return customerWeather;
        }
        public int CreateForecast()
        {

        }
    }
}
