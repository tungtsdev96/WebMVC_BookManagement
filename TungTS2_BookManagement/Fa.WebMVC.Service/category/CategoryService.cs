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

        private UnitOfWork unitOfWork;
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(UnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
            this.categoryRepository = (ICategoryRepository) unitOfWork.GetRepository<Category>();
        }

        public IEnumerable<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
        }

        public Category GetCategoryById(int categoryId)
        {
            return categoryRepository.GetCategoryById(categoryId);
        }

        public int InsertCategory(Category category)
        {
            categoryRepository.InsertCategory(category);
            return unitOfWork.Save();
        }

        public int UpdateCategory(Category category)
        {
            categoryRepository.UpdateCategory(category);
            return unitOfWork.Save();
        }

        public bool DeleteCategory(int categoryId)
        {
            categoryRepository.DeleteCategory(categoryId);
            return unitOfWork.Save() > 0;
        }
    }
}
