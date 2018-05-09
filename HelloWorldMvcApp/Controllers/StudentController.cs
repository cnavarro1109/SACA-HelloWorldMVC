using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMvcApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            Student model = new Student();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            return View("Details", model);
        }

        public IActionResult Details(Student model)
        {
            return View(model);
        }
    }
}