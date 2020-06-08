using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MrZhao_NetCorePro_DAL;
using MrZhao_NetCorePro_Entity;
using MrZhao_NetCorePro_Web.Models;

namespace MrZhao_NetCorePro_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _dbContext;
        public HomeController(ILogger<HomeController> logger,MyDbContext dbContext
            )
        {
           
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            //WebSite website = new WebSite();
            //website.SiteName = "幸福能量";
            //website.SiteInfo = "幸福能量介绍，大家一起共建";
            //_dbContext.WebSites.Add(website);
            //_dbContext.SaveChanges();

            var website=_dbContext.WebSites.Find(1);

            ViewBag.Msg = website.SiteName+ "成功了";
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
