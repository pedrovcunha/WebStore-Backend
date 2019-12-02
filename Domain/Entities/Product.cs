using System;

namespace WebStore.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public  Guid BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
