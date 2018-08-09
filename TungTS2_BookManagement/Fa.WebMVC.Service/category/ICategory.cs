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

        int InsertCategory(Category category);

        int UpdateCategory(Category category);

        bool DeleteCategory(int categoryId);

    }
}
