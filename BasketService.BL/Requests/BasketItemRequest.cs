using BasketService.BL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketService.BL.Requests
{
    public class BasketItemRequest
    {
        public long BasketId { get; set; }
        public long ProductId { get; set; }

        public long CustomerId { get; set; }

        public AddOrRemove AddOrRemove { get; set; }
    }
}
