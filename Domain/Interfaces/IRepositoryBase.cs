using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebStore.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity, in TIdType> where TEntity : class
    {
        Task<TEntity> Add(TEntity pObj);
        void AddRange(List<TEntity> pList);
        TEntity GetById(TIdType pId);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>>[] pExpressions,
            Expression<Func<TEntity, object>>[] pIncludeProperties = null);
        Task<TEntity> Update(TEntity pObj);
        Task<TEntity>  Remove(TEntity pObj);
    }
}
