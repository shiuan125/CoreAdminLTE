using CoreAdminLTE.Models;
using MaxMind.GeoIP2;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAdminLTE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            //nuget install MaxMind.GeoIP2 - 有free version，要註冊帳號。 
            var path = Directory.GetCurrentDirectory();
            path = path + @"\wwwroot\ip\GeoLite2-City.mmdb";
            using (var reader = new DatabaseReader(path))
            {
                var response = reader.City("118.163.104.61");
                
                //德國 De
                //18.193.2.17
                
                string isocode =response.Country.IsoCode;
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
