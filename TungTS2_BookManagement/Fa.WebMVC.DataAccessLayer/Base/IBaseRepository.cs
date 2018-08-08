using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.WebMVC.DataAccessLayer
{
    public interface IBaseRepository<T> where T: class
    {
        /// <summary>
        /// Get all Entities
        /// </summary>
        /// <returns>IEnumerable Entities</returns>
        IEnumerable<T> GetEntities();

        /// <summary>
        /// Get entity by entityId
        /// </summary>
        /// <param name="id">Id of Entity</param>
        /// <returns>T entity</returns>
        T GetEntityById(int id);

        /// <summary>
        /// Insert entity
        /// </summary>
        /// <param name="entity"></param>
        void Insert(T entity);

        /// <summary>
        /// Update Entity 
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Delete Entity From EntityId
        /// </summary>
        /// <param name="entityId"></param>
        void Delete(int entityId);
    }
}
