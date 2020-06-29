using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace weatherapp
{

    public class Weather
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double T { get; set; }
        public double Humidity { get; set; }
        public double Td { get; set; }
        public double AtmoPress { get; set; }
        public string Wind { get; set; }
        public double WindSpeed { get; set; }
        public double Clouds { get; set; }
        public double h { get; set; }
        public double VV { get; set; }
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