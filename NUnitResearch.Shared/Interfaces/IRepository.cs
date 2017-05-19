using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NUnitResearch.Shared.Interfaces
{
   /// <summary>
   /// A repository interface to be implemented by all 
   /// </summary>
   public interface IRepository<T>
      where T : IEntity
   {
      /// <summary>
      /// Create an entity of type T
      /// </summary>
      bool Create(T entity);

      /// <summary>
      /// Get a full collection
      /// </summary>
      IQueryable<T> ReadAll();

      /// <summary>
      /// Get a single entity by ID
      /// </summary>
      T ReadById(int id);

      /// <summary>
      /// Update a single entity
      /// </summary>
      bool Update(T entity);

      /// <summary>
      /// Delete an entity of type T
      /// </summary>
      void Delete(T entity);

      /// <summary>
      /// Query a collection
      /// </summary>
      IQueryable<T> Where(Expression<Func<T, bool>> predicate);
   }
}
