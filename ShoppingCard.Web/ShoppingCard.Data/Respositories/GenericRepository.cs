using Microsoft.EntityFrameworkCore;
using ShoppingCard.Data.ShoppingCardContext;

using ShoppingCart.Data.Repository.RespositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShoppingCart.Data.Repository.Respositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ShoppingCardDbContext shoppingCartDbContext;
        private readonly DbSet<TEntity> dbSet;

        public GenericRepository(ShoppingCardDbContext shoppingCartDbContext)
        {
            this.shoppingCartDbContext = shoppingCartDbContext;
            dbSet = shoppingCartDbContext.Set<TEntity>();
        }

        public void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        public void Delete(TEntity entityToDelete)
        {             
            dbSet.Remove(entityToDelete);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

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
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public void Create(TEntity entity)
        {
            dbSet.Add(entity); 
        }        

        public void Update(TEntity entityToUpdate)
        {
            dbSet.Update(entityToUpdate);
        }
    }
}
