using System;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;
using WebStore.Persistence.DbContext;

namespace WebStore.Persistence.Repositories
{
    public class BasketRepository: RepositoryBase<Basket, Guid>, IBasketRepository
    {
        public BasketRepository(StoreDbContext context) : base(context)
        {

        }
    }
}
