using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fa.WebMVC.DataAccessLayer;
using Fa.WebMVC.Model.Models;

namespace Fa.WebMVC.Service
{
    public class CategoryService : ICategory
    {

        private UnitOfWork unitOfWork;
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(UnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
            this.categoryRepository = (ICategoryRepository) unitOfWork.GetRepository<Category, ICategoryRepository, CategoryRepository>();
        }

        public IEnumerable<Category> GetCategories()
        {
            return categoryRepository.GetCategories();
            //return categoryRepository.GetEntities();
        }

        public Category GetCategoryById(int categoryId)
        {
            return categoryRepository.GetCategoryById(categoryId);
            //return categoryRepository.GetEntityById(categoryId);
        }

        public int InsertCategory(Category category)
        {
            //categoryRepository.Insert(category);
            categoryRepository.InsertCategory(category);
            return unitOfWork.Save();
        }

        public int UpdateCategory(Category category)
        {
            categoryRepository.UpdateCategory(category);
            //categoryRepository.Update(category);
            return unitOfWork.Save();
        }

        public bool DeleteCategory(int categoryId)
        {
            categoryRepository.DeleteCategory(categoryId);
            //categoryRepository.Delete(categoryId);
            return unitOfWork.Save() > 0;
        }
    }
}
