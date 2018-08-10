using Fa.WebMVC.Model.Models;
using Fa.WebMVC.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fa.WebMVC.Presentation.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {

       private readonly CategoryService categoryService;

       public CategoriesController(CategoryService _categoryService)
        {
            this.categoryService = _categoryService;
        }

        // GET: Admin/Categories
        public ActionResult Index()
        {
            return View(categoryService.GetCategories());
        }

        // GET: Admin/Categories/create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int numberRowsChange = categoryService.InsertCategory(category);
                    if (numberRowsChange > 0)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(category);
        }

        // GET: Admin/Categories/Details/1
        public ViewResult Details(int id)
        {
            var category = categoryService.GetCategoryById(id);
            return View(category);
        }

        // GET: Admin/Categories/Edit/5
        public ActionResult Edit(int id)
        {
            var category = categoryService.GetCategoryById(id);
            return View(category);
        }

        // POST: Admin/Categories/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    int numberRowsChange = categoryService.UpdateCategory(category);
                    if (numberRowsChange > 0)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(category);
        }

        // GET:  Admin/Categories/Delete/1
        public ActionResult Delete(int id)
        {
            var category = categoryService.GetCategoryById(id);
            return View(category);
        }

        // POST:  Admin/Categories/Delete/1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            bool success = categoryService.DeleteCategory(id);
            return RedirectToAction("Index");
        }

    }
}