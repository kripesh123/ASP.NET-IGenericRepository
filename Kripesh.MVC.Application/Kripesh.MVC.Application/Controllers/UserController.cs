using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kripesh.MVC.Application.Models;
using Kripesh.MVC.Application.Repository;

namespace Kripesh.MVC.Application.Controllers
{
    public class UserController : Controller
    {
        IUserRepository _userRepository = new UserRepository();
        // GET: User
        public ActionResult Index()
        {
            ViewBag.Title = "User";
            return View(_userRepository.GetAll());
        }

        public ActionResult Edit(int id=0)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            User user = _userRepository.GetById(id);
            if (user == null)
            {
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}