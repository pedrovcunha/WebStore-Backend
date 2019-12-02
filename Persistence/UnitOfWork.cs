using System;
using WebStore.Domain.Interfaces;
using WebStore.Persistence.DbContext;
using WebStore.Persistence.Repositories;

namespace WebStore.Persistence
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly StoreDbContext _context;

        public UnitOfWork(StoreDbContext context)
        {
            _context = context;
        }

        private BasketRepository _basketRepository;
        private ProductRepository _productRepository;

        public IBasketRepository Basket => _basketRepository ??= new BasketRepository(_context);
        public IProductRepository Product => _productRepository ??= new ProductRepository(_context);

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        #region Dispose

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
