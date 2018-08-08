using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fa.WebMVC.DataAccessLayer.AccessDatabases;

namespace Fa.WebMVC.DataAccessLayer
{
    public class UnitOfWork: IDisposable
    {

        private BookManagementContext  context = new BookManagementContext();
        
        public int Save()
        {
            return context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
