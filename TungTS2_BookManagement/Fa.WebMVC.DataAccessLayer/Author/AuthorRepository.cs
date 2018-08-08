using Fa.WebMVC.DataAccessLayer.AccessDatabases;
using Fa.WebMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.DataAccessLayer
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookManagementContext _bookManagementContext) : base(_bookManagementContext)
        {
        }

        public IEnumerable<Author> GetAuthors()
        {
            return base.GetEntities();
        }

        public Author GetAuthorById(int authorId)
        {
            return base.GetEntityById(authorId);
        }

        

        public void InsertAuthor(Author author)
        {
            base.Insert(author);
        }

        public void UpdateAuthor(Author author)
        {
            base.Update(author);
        }

        public void DeleteAuthor(int authorId)
        {
            base.Delete(authorId);
        }
    }
}
