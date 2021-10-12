using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApi.Exceptions;
using WebApi.Models;

namespace OrienteeringApi.Database
{

    /*
     * Like the EntityBase class, generic repositories may be okay
     * for beginners.
     * 
     * But, generic repository base classes are likely unnecessary and forces
     * your subclasses to implement behavior that is not needed.
     * A repository should, in my mind, be task-oriented and not
     * CRUD-based.
     *
     * Naming members of a base class also becomes too generic to be useful
     * anywhere.
     */

    public interface IRepositoryBase<T> where T : class
    {
        //Task<T> Get(int id);
        Task<List<T>> Get(
           Expression<Func<T, bool>> filter = null,
           Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
           string includeProperties = "");

        Task<T> GetSingle(Expression<Func<T, bool>> filter = null, string includeProperties = "");
        Task<List<T>> GetAll();

        Task<T> GetByID(object id);

        void Update(T entity);

        void Create(T entity);

        void Delete(object id);

        Task<bool> SaveChanges();

        Task<bool> Save();
    }
}