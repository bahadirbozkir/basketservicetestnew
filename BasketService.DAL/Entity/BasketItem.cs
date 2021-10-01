using System;
using System.Collections.Generic;
using System.Text;

namespace BasketService.DAL.Entity
{
    public class BasketItem : BaseEntity
    {
        public long BasketId { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
