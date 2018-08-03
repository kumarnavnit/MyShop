using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Cus_Display
    {
        public string id;

        public string Sid { get; set; }
       
        public string Name { get; set; }
        public string Description { get; set; }
       
        public string Address { get; set; }
        public string Category { get; set; }

        public static Cus_Display Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public void Remove(Cus_Display customerToDelete)
        {
            throw new NotImplementedException();
        }

        public Product Find(string id)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        //public Product Find(Func<object, bool> v)
        //{
        //    throw new NotImplementedException();
        //}

        //public Product Find(Func<object, bool> v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
