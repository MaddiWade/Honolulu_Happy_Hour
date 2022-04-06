using Honolulu_Happy_Hour.Models;
using System;
using System.Collections.Generic;
namespace Honolulu_Happy_Hour
{
    public interface IMenuRepository
    {
        public IEnumerable<MenuItems> GetAllMenuItems();

        
    }
   
}
