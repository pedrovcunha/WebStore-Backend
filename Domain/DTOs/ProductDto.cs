using System;
using WebStore.Domain.Entities;

namespace WebStore.Domain.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string Category { get; set; }
    }
}
