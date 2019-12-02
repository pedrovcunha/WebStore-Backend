using System;

namespace WebStore.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string Category { get; set; }
        public  Guid? BasketId { get; set; }
        public virtual Basket Basket { get; set; }
    }
}
