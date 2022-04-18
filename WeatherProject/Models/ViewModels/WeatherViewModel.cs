using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherProject.Models.ViewModels
{
    public class WeatherViewModel
    {
        [Key]
        public int ID { get; set; }
        public decimal AMBIENT_TEMPERATURE { get; set; }
        public decimal GROUND_TEMPERATURE { get; set; }
        public decimal AIR_QUALITY { get; set; }
        public decimal AIR_PRESSURE { get; set; }
        public decimal HUMIDITY { get; set; }
        public decimal WIND_DIRECTION { get; set; }
        public decimal WIND_SPEED { get; set; }
        public decimal WIND_GUST_SPEED { get; set; }
        public decimal RAINFALL { get; set; }
    }
}
