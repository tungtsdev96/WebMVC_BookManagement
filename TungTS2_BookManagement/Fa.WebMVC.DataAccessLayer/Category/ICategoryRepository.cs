using System;
using System.Collections.Generic;
using Fa.WebMVC.Model.Models;

namespace Fa.WebMVC.DataAccessLayer
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        IEnumerable<Category> GetCategories();

        Category GetCategoryById(int categoryId);

        void InsertCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(int categoryId);
    }
}
