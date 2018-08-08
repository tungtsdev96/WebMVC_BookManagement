using Fa.WebMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.DataAccessLayer
{
    public interface IAuthorRepository : IBaseRepository<Author>
    {

        IEnumerable<Author> GetAuthors();

        Author GetAuthorById(int authorId);

        void InsertAuthor(Author author);

        void UpdateAuthor(Author author);

        void DeleteAuthor(int authorId);

    }
}
