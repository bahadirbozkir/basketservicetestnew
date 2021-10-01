﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasketService.DAL.Entity
{
    public class Customer : BaseEntity
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
