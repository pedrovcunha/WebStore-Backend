using System;
using System.Collections.Generic;

namespace WebStore.Domain.Entities
{
    public class Basket
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Buyer { get; set; }
        public string OnlineStoreDomainRegion { get; set; }
        public virtual ICollection<Product> Products { get; private set; }
    }
}
