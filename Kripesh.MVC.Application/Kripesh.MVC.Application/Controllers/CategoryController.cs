using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kripesh.MVC.Application.Models;
using Kripesh.MVC.Application.Repository;


namespace Kripesh.MVC.Application.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryRepository _categoryRepository = new CategoryRepository();
        
        // GET: Category
        public ActionResult Index()
        {
            ViewBag.Title = " Category ";
            return View(_categoryRepository.GetAll());
        }

        public ActionResult Edit(int id = 0)
        {
            ViewBag.Title = "Edit Category";
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            Category category = _categoryRepository.GetById(id);

            if (category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}