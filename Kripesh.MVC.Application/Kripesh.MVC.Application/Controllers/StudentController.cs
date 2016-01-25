using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kripesh.MVC.Application.Models;
using Kripesh.MVC.Application.Repository;

namespace Kripesh.MVC.Application.Controllers
{
    public class StudentController : Controller 
    {
        IStudentRepository _studentRepository = new StudentRepository();
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Title = "Student";
            return View(_studentRepository.GetAll());
        }

        public ActionResult Edit(int id = 0)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }


            Student student = _studentRepository.GetByID(id);
            if(student == null)
            {
                return RedirectToAction("Index");
            }
            return View(student);
        }

    }
}