using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BasketService.DAL.Entity
{
    public class Product : BaseEntity
    {
        [Column(TypeName = "varchar(250)")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }

    }
}
