using System;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;
using WebStore.Persistence.DbContext;

namespace WebStore.Persistence.Repositories
{
    public class ProductRepository : RepositoryBase<Product, Guid>, IProductRepository
    {
        public ProductRepository(StoreDbContext context) : base(context)
        {

        }
    }
}
