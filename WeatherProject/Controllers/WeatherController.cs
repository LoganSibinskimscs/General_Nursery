using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherProject.Models;
using WeatherProject.Models.ViewModels;

namespace WeatherProject.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherDBContext _db;

        public WeatherController(WeatherDBContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<WeatherViewModel> objList = _db.Weather;
            return View(objList);
        }

        //[HttpPost]
        //public IActionResult Index(WeatherViewModel model)
        //{
        //    WeatherViewModel weather = new WeatherViewModel();

        //    return View(model);
        //}
    }
}
