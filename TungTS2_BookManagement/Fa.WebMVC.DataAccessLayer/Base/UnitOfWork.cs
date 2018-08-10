using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fa.WebMVC.DataAccessLayer.AccessDatabases;
using Fa.WebMVC.Model.Models;

namespace Fa.WebMVC.DataAccessLayer
{
    public class UnitOfWork: IDisposable
    {

        private BookManagementContext context;

        public UnitOfWork(BookManagementContext _context)
        {
            this.context = _context;
        }

        /// <summary>
        /// list Repoisitory map with type of Class Entity 
        /// </summary>
        public Dictionary<Type, object> ListRepositories = new Dictionary<Type, object>();

        /// <summary>
        /// Get repository need to do
        /// </summary>
        /// <typeparam name="TEntity"> Type of class Entity</typeparam>
        /// <returns> IBase<Repository> baseRepository </returns>
        public IBaseRepository<TEntity> GetRepository<TEntity, TRepo>() 
            where TEntity: class
            where TRepo : IBaseRepository<TEntity>
        {
            if (ListRepositories.Keys.Contains(typeof(TEntity)))
            {
                return ListRepositories[typeof(TEntity)] as IBaseRepository<TEntity>;
            }

            IBaseRepository<TEntity> baseRepository = new BaseRepository<TEntity>(context);

            ListRepositories.Add(typeof(TEntity), baseRepository);
            return baseRepository;
        }

        public IBaseRepository<TEntity> GetRepository<TEntity, IRepo, Repo>()
            where TEntity : class
            where IRepo : IBaseRepository<TEntity>
            where Repo : BaseRepository<TEntity>
        {
            if (ListRepositories.Keys.Contains(typeof(TEntity)))
            {
                return (IRepo) ListRepositories[typeof(TEntity)];
            }

            IRepo repo = (IRepo) Activator.CreateInstance(typeof(Repo), context);

            ListRepositories.Add(typeof(TEntity), repo);
            return  repo;
        }

        /// <summary>
        /// Save change Database
        /// </summary>
        /// <returns>number rows change</returns>
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
