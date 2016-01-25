using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kripesh.MVC.Application.Models;
using Kripesh.MVC.Application.Repository;


namespace Kripesh.MVC.Application.Controllers
{
    public class AutoController : Controller
    {
        IAutoRepository _autoRepository = new AutoRepository();
        // GET: Auto
        public ActionResult Index()
        {
            ViewBag.Title = "Auto";
            return View(_autoRepository.GetAll());
        }

        public ActionResult Edit(int id=0)
        {
            ViewBag.Title = "Edit Auto";
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            Auto auto = _autoRepository.GetById(id);
            if (auto == null)
            {
                return RedirectToAction("Index");
            }
            return View(auto);
        }
    }
}