using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kripesh.MVC.Application.Repository;
using Kripesh.MVC.Application.Models;

namespace Kripesh.MVC.Application.Controllers
{

    public class TeacherController : Controller
    {
        ITeacherRepository _teacherRepository = new TeacherRepository();
        // GET: Teacher
        public ActionResult Index()
        {
            ViewBag.Title = "Teacher";

            return View(_teacherRepository.GetAll());
        }

        public ActionResult Edit(int id = 0)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }

            Teacher teacher = _teacherRepository.GetById(id);
            if (teacher == null)
            {
                return RedirectToAction("Index");
            }
            return View(teacher);
        }
        
    }
}