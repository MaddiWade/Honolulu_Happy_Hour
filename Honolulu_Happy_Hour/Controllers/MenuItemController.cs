using Honolulu_Happy_Hour.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Honolulu_Happy_Hour.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly IMenuRepository repo;

        public MenuItemController(IMenuRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var m = new MenuItems();  
            return View(m);
        }

        public IActionResult GetMenuItems(MenuItems m)
        {
            var menuitems = repo.GetAllMenuItems();


            if (!String.IsNullOrEmpty(m.MenuItem))
            {
                menuitems = menuitems.Where(s => s.MenuItem.Contains(m.MenuItem));
            }

            return View(menuitems);
        }

        
    }
}
