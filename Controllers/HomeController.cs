using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using System.Diagnostics;

namespace MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //string timeNow = DateTime.Now.ToString();
            //ViewBag.TimeNow = timeNow;
            //ViewBag.Name = "Raj";
            //ViewBag.Rank = 1;

            //ViewBag.GroupData = new { RollNo=1, Name="Raja",Age=24 };

            //List<string> list = new List<string>();
            //list.Add("A");
            //list.Add("B");
            //list.Add("C");
            //list.Add("D");

            //ViewBag.Rank = 2;

            //ViewBag.List = list;
            ViewData.Add("name", 1);
            ViewData.Add("Jashu", 2);


            Employee emp = new Employee()
            {
                Id = 1,
                Name="Hari",
                Salary=20000
            };

            return View("View",emp);
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
