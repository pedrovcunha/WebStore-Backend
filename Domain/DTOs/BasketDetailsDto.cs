using System;
using System.Collections.Generic;
using WebStore.Domain.Entities;

namespace WebStore.Domain.DTOs
{
    public class BasketDetailsDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Buyer { get; set; }
        public string OnlineStoreDomainRegion { get; set; }
        public virtual ICollection<ProductDto> Products { get; private set; }
    }
}
