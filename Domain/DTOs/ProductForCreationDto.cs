using System;

namespace WebStore.Domain.DTOs
{
    public class ProductForCreationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string Category { get; set; }
        public  Guid BasketId { get; set; }
    }
}
