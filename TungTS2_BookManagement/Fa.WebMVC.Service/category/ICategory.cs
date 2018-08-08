using Fa.WebMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.Service
{
    public interface ICategory
    {

        IEnumerable<Category> GetCategories();

        Category GetCategoryById(int categoryId);

        void InsertCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(int categoryId);

    }
}
