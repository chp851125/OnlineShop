using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers
{
    public class UserController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<OnlineShopUser> _userManager;

        public UserController(RoleManager<IdentityRole> roleManager, UserManager<OnlineShopUser> userManager)
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(OnlineShopUserRole role)
        {
            var roleExist = await _roleManager.RoleExistsAsync(role.RoleName); //判斷角色是否已存在
            if (!roleExist)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(role.RoleName));
            }
            return View();
        }
    }
}
