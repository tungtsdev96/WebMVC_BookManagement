using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fa.WebMVC.DataAccessLayer.AccessDatabases;
using Fa.WebMVC.Model.Models;

namespace Fa.WebMVC.DataAccessLayer
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(BookManagementContext _bookManagementContext) : base(_bookManagementContext)
        {
        }

        public Book GetBookById(int bookId)
        {
            return base.GetEntityById(bookId);
        }

        public IEnumerable<Book> GetBooks()
        {
            return base.GetEntities();
        }

        public void InsertBook(Book book)
        {
            base.Insert(book);
        }

        public void UpdateBook(Book book)
        {
            base.Update(book);
        }

        public void DeleteBook(int bookId)
        {
            base.Delete(bookId);
        }
    }
}
