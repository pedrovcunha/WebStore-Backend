using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities;

namespace WebStore.Domain.DTOs
{
    public class BasketDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Buyer { get; set; }
        public string OnlineStoreDomainRegion { get; set; }
    }
}
