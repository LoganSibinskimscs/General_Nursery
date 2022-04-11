using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherProject.Utility
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string Employee = "Employee";

        public static List<SelectListItem> GetRolesForDropDown(bool isAdmin)
        {
            if (isAdmin)
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Helper.Admin,Text=Helper.Admin}
                };
            }
            else
            {
                return new List<SelectListItem>
                {
                new SelectListItem{Value=Helper.Employee,Text=Helper.Employee}
                };
            }
        }
    }
}
