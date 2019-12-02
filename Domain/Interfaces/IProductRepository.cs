using System;
using WebStore.Domain.Entities;

namespace WebStore.Domain.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product, Guid>
    {
    }
}
