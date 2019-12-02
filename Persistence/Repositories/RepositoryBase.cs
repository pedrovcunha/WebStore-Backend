using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Interfaces;
using WebStore.Persistence.DbContext;

namespace WebStore.Persistence.Repositories
{
    public class RepositoryBase<TEntity, TIdType> : IRepositoryBase<TEntity, TIdType> where TEntity : class
    {
        internal StoreDbContext Context;

        public RepositoryBase(StoreDbContext context)
        {
            Context = context;
        }

        public async Task<TEntity> Add(TEntity pObj)
        {
            await Context.Set<TEntity>().AddAsync(pObj);
            await Context.SaveChangesAsync();
            return pObj;
        }

        public async void AddRange(List<TEntity> pList)
        {
            await Context.Set<TEntity>().AddRangeAsync(pList);
        }

        public TEntity GetById(TIdType pId)
        {
            return Context.Set<TEntity>().Find(pId);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>>[] pExpressions,  Expression<Func<TEntity, object>>[] pIncludeProperties = null)
        {
            if (pExpressions == null) throw new ArgumentNullException(nameof(pExpressions));
            if (pExpressions.Length == 0) throw new ArgumentException("Argument Empty.");

            IQueryable<TEntity> items = Context.Set<TEntity>();

            var predicate = PredicateBuilder.New<TEntity>(true);

            foreach (var expression in pExpressions)
                predicate.And(expression);

            items = items.Where(predicate);

            if (pIncludeProperties != null)
            {
                items = pIncludeProperties.Aggregate(items, (current, includeProperty) => current.Include(includeProperty));
            }

            return items;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>();
        }

        public async Task<TEntity> Update(TEntity pObj)
        {
            Context.Update(pObj);
            Context.Entry(pObj).State = EntityState.Modified;
            await Context.SaveChangesAsync();

            return pObj;
        }

        public async Task<TEntity> Remove(TEntity pObj)
        {
            Context.Remove(pObj);
            await Context.SaveChangesAsync();

            return pObj;
        }

    }
}
