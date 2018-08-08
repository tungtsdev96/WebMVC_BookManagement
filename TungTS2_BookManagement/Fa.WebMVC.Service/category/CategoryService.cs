using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fa.WebMVC.DataAccessLayer;
using Fa.WebMVC.Model.Models;

namespace Fa.WebMVC.Service.category
{
    public class CategoryService : ICategory
    {

        private ICategoryRepository categoryRepository;

        public CategoryService()
        {
            categoryRepository = new CategoryRepository(new DataAccessLayer.AccessDatabases.BookManagementContext());
        }

        public CategoryService(ICategoryRepository _categoryRepository)
        {
            this.categoryRepository = _categoryRepository;
        }
        
        public IEnumerable<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }

        public Category GetCategoryById(int categoryId)
        {
            return categoryRepository.GetCategoryById(categoryId);
        }

        public void InsertCategory(Category category)
        {
            categoryRepository.InsertCategory(category);
        }

        public void UpdateCategory(Category category)
        {
            categoryRepository.UpdateCategory(category);
        }

        public void DeleteCategory(int categoryId)
        {
            categoryRepository.DeleteCategory(categoryId);
        }

    }
}
