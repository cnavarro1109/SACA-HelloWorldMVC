using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldMvcApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(ContactViewModel model)
        {

            return View(model);
        }
    }
}