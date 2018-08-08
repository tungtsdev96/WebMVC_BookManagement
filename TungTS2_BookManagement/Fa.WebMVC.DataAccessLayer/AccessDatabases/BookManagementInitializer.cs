using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Fa.WebMVC.DataAccessLayer.AccessDatabases
{
    public class BookManagementInitializer: DropCreateDatabaseIfModelChanges<BookManagementContext>
    {

        protected override void Seed(BookManagementContext context)
        {
            base.Seed(context);
        }
    }
}
