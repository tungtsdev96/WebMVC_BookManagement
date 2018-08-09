using Fa.WebMVC.Model.Models;
using Fa.WebMVC.Service.category;
using System;
using System.Collections.Generic;
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

    }
}