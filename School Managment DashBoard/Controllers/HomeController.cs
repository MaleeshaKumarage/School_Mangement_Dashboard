using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using School_Managment_DashBoard.Models;

namespace School_Managment_DashBoard.Controllers
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
            return View();
        }

        public IActionResult Add_Student()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add_Student(StudentViewModel student)
        {
            new MySqlDBConnector.DBConnector().Insert(student.ToStudent());

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Delete_Student()
        {
            return View();
        }

        public IActionResult Student_List()
        {
            var data = new MySqlDBConnector.DBConnector().Select();
            return View(new StudentViewModel().ToStudentViewModel(data));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
