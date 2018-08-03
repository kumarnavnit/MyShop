using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
 public class Customer
    {
        [DisplayName("Customer ID")]
        public string Sid { get; set; }
        [StringLength(20)]
        [DisplayName("Customer Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, 1000)]
        public string Address { get; set; }
        public string Category { get; set; }


        public Customer()
        {
            this.Sid = Guid.NewGuid().ToString();
        }

        public Customer Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
