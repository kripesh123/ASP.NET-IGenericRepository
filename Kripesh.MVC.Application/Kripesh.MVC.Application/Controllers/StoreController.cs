using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kripesh.MVC.Application.Models;
using Kripesh.MVC.Application.Repository;

namespace Kripesh.MVC.Application.Controllers
{
    public class StoreController : Controller
    {
        IStoreRepository _storeRepository = new StoreRepository();
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Title = "Store";
            return View(_storeRepository.GetAll());
        }
        public ActionResult Edit(int id=0)
        {
            ViewBag.Title = "Edit Store";
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            Store store = _storeRepository.getById(id);
            if(store == null)
            {
                return RedirectToAction("Index");
            }

            return View(store);
        }
    }
}