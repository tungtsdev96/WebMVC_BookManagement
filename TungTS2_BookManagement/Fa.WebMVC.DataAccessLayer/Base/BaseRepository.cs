using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Fa.WebMVC.DataAccessLayer.AccessDatabases;

namespace Fa.WebMVC.DataAccessLayer
{
    public class BaseRepository<T> : IBaseRepository<T> where T: class
    {

        internal BookManagementContext bookManagementContext;
        internal DbSet<T> dbSet;

        public BaseRepository(BookManagementContext _bookManagementContext)
        {
            this.bookManagementContext = _bookManagementContext;
            dbSet = bookManagementContext.Set<T>();
        }

        /// <summary>
        /// Get all Entities
        /// </summary>
        /// <returns>IEnumerable Entities</returns>
        public IEnumerable<T> GetEntities()
        {
            foreach (var item in dbSet.ToList<T>())
            {
                yield return item;
            }
        }

        /// <summary>
        /// Get entity by entityId
        /// </summary>
        /// <param name="id">Id of Entity</param>
        /// <returns>T entity</returns>
        public T GetEntityById(int id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        /// <summary>
        /// Update Entity 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            dbSet.Attach(entity);
            bookManagementContext.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Delete Entity From EntityId
        /// </summary>
        /// <param name="entityId"></param>
        public void Delete(int entityId)
        {
            var item = dbSet.Find(entityId);
            Delete(item);
        }

        private void Delete(T item)
        {
            if (bookManagementContext.Entry(item).State == EntityState.Detached)
            {
                dbSet.Attach(item);
            }
            dbSet.Remove(item);
        }
    }
}
