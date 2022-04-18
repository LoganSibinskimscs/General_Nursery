using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherProject.Controllers;
using WeatherProject.Models.ViewModels;

namespace WeatherProject.Models
{
    public class WeatherDBContext : DbContext
    {
        public WeatherDBContext(DbContextOptions<WeatherDBContext> options) : base(options)
        {

        }

        public DbSet<WeatherViewModel> Weather { get; set; }
    }
}
