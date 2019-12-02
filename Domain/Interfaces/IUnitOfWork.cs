namespace WebStore.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IBasketRepository Basket { get; }
        IProductRepository Product { get; }

        bool Save();
        void Dispose();
    }
}
