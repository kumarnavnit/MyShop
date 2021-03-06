﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        [DisplayName("Product ID")]
        public string id { get; set; }
        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range (0,1000)]
        public string Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }

        public Product()
        {
            this.id = Guid.NewGuid().ToString();
        }

        public static implicit operator Product(Cus_Display v)
        {
            throw new NotImplementedException();
        }
    }
}
