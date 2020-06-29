using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace weatherapp
{

    public class Weather
    {
        public DateTime Date { get; set; }
        public float T { get; set; }
        public float Humidity { get; set; }
        public float Td { get; set; }
        public int AtmoPress { get; set; }
        public string Wind { get; set; }
        public int WindSpeed { get; set; }
        public int Clouds { get; set; }
        public int h { get; set; }
        public int VV { get; set; }
        public string Other { get; set; }
    }
    class WeatherContext : DbContext
    {
        public WeatherContext()
            : base("DbConnection")
        { }

        public DbSet<Weather> Weathers { get; set; }
    }

}