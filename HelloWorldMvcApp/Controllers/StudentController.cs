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
        private readonly HelloWorldContext _context;

        public StudentController(HelloWorldContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Students.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            #region Older Code
            //Initializing the new model

            //Student model = new Student();
            //ViewData["GenderList"] = _context.StudentGenders.ToList();
            //model.Genders = _context.StudentGenders;
            //return View(model);
            #endregion
            StudentViewModel model = new StudentViewModel(); //Instance of the StudentViewModel

            //Populating the drop down field from our database 
            //_context [Database]
            //studentGendrs [Table]
            //ToList() [Makes it into a drop down]
            model.studentGender = _context.StudentGenders.ToList(); 

            return View(model); //Passing the data to our view
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel viewModel)
        {


            Student model = new Student();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //Populating our model
            model.Enrolled = viewModel.student.Enrolled;
            model.StudentName = viewModel.student.StudentName;
            model.StudentGenderId = viewModel.student.StudentGenderId;


            //Save the data 
            _context.Add(model); //Adding the data to the context
            _context.SaveChanges(); //Saving the data to the table

            return View("Details", model);
        }

        public IActionResult Details(Student model)
        {
            return View(model);
        }
    }
}