using HelloWorldProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace HelloWorldProject.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        public string test()
        {
            return "Hello from test method";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Employees()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Employees(Employee emp)
        {
            if(ModelState.IsValid)
            {
                Repository.addEmployee(emp);
                return View("confirmpage", emp);
            }
            else
            {
                return View();
            }
            
        }

        public ViewResult viewEmployees()
        {
            var data = Repository.GetEmployees();
            //getting active employees only
            var filtered_data = data.Where(emp => emp.isActive == true);
            return View(filtered_data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
