using Fa.WebMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.DataAccessLayer
{
    public interface IBookRepository: IBaseRepository<Book>
    {

        IEnumerable<Book> GetBooks();

        Book GetBookById(int bookId);

        void InsertBook(Book book);

        void UpdateBook(Book book);

        void DeleteBook(int bookId);

    }
}
