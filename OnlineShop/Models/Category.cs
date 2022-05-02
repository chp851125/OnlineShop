using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }            //類別名稱
        public List<Product> Products { get; set; }
    }
}
