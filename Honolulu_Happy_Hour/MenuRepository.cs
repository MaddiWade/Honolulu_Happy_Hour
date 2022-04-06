using Dapper;
using Honolulu_Happy_Hour.Models;
using System.Collections.Generic;
using System.Data;

namespace Honolulu_Happy_Hour
{
    public class MenuRepository : IMenuRepository
    {
        private readonly IDbConnection _conn;

        public MenuRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<MenuItems> GetAllMenuItems()
        {
            return _conn.Query<MenuItems>("SELECT * FROM MENUITEMS;");
        }

        
    }
}
