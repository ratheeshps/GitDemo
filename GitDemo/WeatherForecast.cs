using System;

namespace GitDemo
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        //sdfd
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
