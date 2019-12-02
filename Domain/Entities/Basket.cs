using System;
using System.Collections.Generic;

namespace WebStore.Domain.Entities
{
    public class Basket
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<Product> Products { get; private set; }
    }
}
