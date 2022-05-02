using OnlineShop.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class OnlineShopUserViewModel
    {
        public OnlineShopUser User { get; set; }
        public string RoleName { get; set; }
    }
}
