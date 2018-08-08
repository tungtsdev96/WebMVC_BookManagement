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

        public CategoryService categoryService = new CategoryService();

        // GET: Admin/Categories
        public ActionResult Index()
        {
            return View(categoryService.GetCategories());
        }
    }
}