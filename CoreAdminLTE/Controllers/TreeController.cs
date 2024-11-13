using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAdminLTE.Controllers
{
    public class TreeController : Controller
    {
        private readonly ILogger<DashboardController> _logger;
        public TreeController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index1()
        {
            
            return View();
        }
        [AllowAnonymous]
        public IActionResult Index2()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Index3()
        {
            return View();
        }
    }
}
