using Fa.WebMVC.DataAccessLayer.AccessDatabases;
using Fa.WebMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.DataAccessLayer
{
    public class CategoryRepository :  BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BookManagementContext _bookManagementContext) : base(_bookManagementContext)
        {
        }

        public IEnumerable<Category> GetCategories()
        {
            return base.GetEntities();
        }

        public Category GetCategoryById(int categoryId)
        {
            return base.GetEntityById(categoryId);
        }

        public void InsertCategory(Category category)
        {
            base.Insert(category);
        }

        public void UpdateCategory(Category category)
        {
            base.Update(category);
        }

        public void DeleteCategory(int categoryId)
        {
            base.Delete(categoryId);
        }

    }
}
