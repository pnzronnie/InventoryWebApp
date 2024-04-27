using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;
using WebApplication2.Data;
using System.Data;
using System.IO;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        DbContextOptions<Context> _contextOptions;

        public HomeController(ILogger<HomeController> logger, DbContextOptions<Context> contextOptions)
        {
            _logger = logger;
            _contextOptions = contextOptions;
        }

        public IActionResult Index()
        {
            System.IO.File.Copy("computerservice.db", "./File/computerservice.db", true);

            using (Context _context = new Context(_contextOptions))
            {
                var list = _context.Orders.Where(i => i.InProgress && !i.Deleted).Select(a => new
                {
                    a.Id,
                    a.DateCreation,
                    a.Master.NameMaster,
                    a.TypeTechnic.NameTypeTechnic,
                    a.BrandTechnic.NameBrandTechnic,
                    a.ModelTechnic,
                    a.Client.NameClient,
                    a.Diagnosis,
                    a.UrgentRepairs
                }).OrderByDescending(i => i.Id).ToList();

                return View(list);
            }
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
