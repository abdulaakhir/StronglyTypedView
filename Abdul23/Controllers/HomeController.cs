using Abdul23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Abdul23.Controllers
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
            //Employee obj = new Employee()
            //{
            //    EmpId = 101,
            //    EmpName="Abdul",
            //    Designation="Manager",
            //    Salary=25000
            //};

            var myEmployees = new List<Employee>
            {
                new Employee {EmpId=101,EmpName="Abdul",Designation="Manager",Salary=20000},
                new Employee {EmpId=102,EmpName="Aakhir",Designation="Manager",Salary=30000},
                new Employee {EmpId=103,EmpName="Punam",Designation="Manager",Salary=40000},
                new Employee {EmpId=104,EmpName="Pavan",Designation="Manager",Salary=50000},
                new Employee {EmpId=105,EmpName="Pasvan",Designation="Manager",Salary=60000},
            };

            return View(myEmployees);
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
