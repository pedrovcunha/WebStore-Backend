using System;
using WebStore.Domain.Entities;

namespace WebStore.Domain.Interfaces
{
    public interface IBasketRepository: IRepositoryBase<Basket, Guid>
    {
    }
}
