using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BasketService.DAL.Entity
{
    public class Basket : BaseEntity
    {
        public long CustomerId { get; set; }

        [ForeignKey("BasketId")]
        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
