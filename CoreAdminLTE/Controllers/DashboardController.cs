using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAdminLTE.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;
        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        public IActionResult Index1()
        {
            _logger.LogInformation("Dashboard Index 1 通知...");
            _logger.LogWarning("Dashboard Index 1 警告...");
            _logger.LogError("Dashboard Index 1 log 錯誤...");
            _logger.LogInformation("Dashboard Index 1 Info 現在時間(utc):{Time}", DateTime.UtcNow);
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
