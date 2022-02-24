using System;

namespace WebApplication1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int Temperature_C { get; set; }

        public int TemperatureF => 32 + (int)(Temperature_C / 0.5556);

        public string Summary { get; set; }
    }
}
