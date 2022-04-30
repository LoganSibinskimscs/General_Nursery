using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public async Task<IActionResult> Index(string sortOrder, int? pageNumber = 1)
        {
            ViewData["IDSortParam"] = String.IsNullOrEmpty(sortOrder) ? "idDesc" : "";

            var weather = from s in _db.Weather select s;

            switch (sortOrder)
            {
                case "idDesc":
                    weather = weather.OrderByDescending(s => s.ID);
                    break;
                default:
                    weather = weather.OrderBy(s => s.ID);
                    break;
            }
            int pageSize = 20;
            //IEnumerable<WeatherViewModel> objList = _db.Weather;
            return View(await PaginatedList<WeatherViewModel>.CreateAsync(weather.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
    }
}
