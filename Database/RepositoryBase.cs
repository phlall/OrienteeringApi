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
    
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly OrienteeringContext context;
        protected readonly DbSet<T> Entities;

        protected RepositoryBase(OrienteeringContext context) {
            this.context = context;
            Entities = context.Set<T>();
        }

        public async Task<List<T>> Get(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = "")
        {
            IQueryable<T> query = Entities;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return await orderBy(query).ToListAsync();
            }

            return await query.ToListAsync();
        }


        public async Task<T> GetSingle(Expression<Func<T, bool>> filter = null, string includeProperties = "")
        {
            IQueryable<T> query = Entities;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return await query.FirstOrDefaultAsync();
        }


        public async Task<T> GetByID(object id)
        {
            return await Entities.FindAsync(id);
        }

        //public async Task<T> Get(int id) {
        //    //T entity = await Entities.SingleOrDefaultAsync(e => e.Id.Equals(id));
        //    T entity = await Entities.FindAsync(id);
        //    //if (entity is null) throw new EntityNotFoundException<T>(id);
        //    return entity;
        //}

        public async Task<List<T>> GetAll() {
            return await Entities.ToListAsync();
        }

        public virtual void Update(T entity) {
             Entities.Update(entity);
          //  await SaveChanges();
        }
        public virtual void Create(T entity)
        {
            Entities.Add(entity);
            // await SaveChanges();
            // return entity.Id;
        }

        //public virtual async Task<int> Create(T entity) {
        //    Entities.Add(entity);
        //   // await SaveChanges();
        //   // return entity.Id;
        //}

        public virtual async void Delete(object id) {
            T entity = await Entities.FindAsync(id);
            Entities.Remove(entity);

           // await SaveChanges();
        }

        public async Task<bool> SaveChanges() {
            try {
                var timestamp = DateTime.Now;
                foreach (var entry in context.ChangeTracker.Entries()
                    .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
                {
                    entry.Property("Modified").CurrentValue = timestamp;

                    if (entry.State == EntityState.Added)
                    {
                        entry.Property("Created").CurrentValue = timestamp;
                    }
                }
                await context.SaveChangesAsync();
                return true;
            } catch (Exception) {
                return false;
            }
        }


    }
}