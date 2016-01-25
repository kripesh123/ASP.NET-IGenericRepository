using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kripesh.MVC.Application.Models;
using Kripesh.MVC.Application.Repository;


namespace Kripesh.MVC.Application.Controllers
{
    public class MobileController : Controller
    {
        IMobileRepository _mobileRepository = new MobileRepository();
        // GET: Mobile
        public ActionResult Index()
        {
            ViewBag.Title = "Mobile";
            return View(_mobileRepository.GetAll());
        }

        public ActionResult Edit(int id = 0)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            Mobile mobile = _mobileRepository.GetById(id);
            if (mobile == null)
            {
                return RedirectToAction("Index");
            }
            return View(mobile);
        }
    }
}