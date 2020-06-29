using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace weatherapp
{

    public class Weather
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
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