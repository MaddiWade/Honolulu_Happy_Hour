using System;
namespace Honolulu_Happy_Hour.Models
{
    public class MenuItems
    {
        public MenuItems()
        {
        }

        public int RestrauntID { get; set; }
        public int CatagoryID { get; set; }
        public string MenuItem { get; set; }
        public string ItemPrice { get; set; }
        public string TimeRange { get; set; }
        public int MenuItemID { get; set; }
        public string RestrauntName { get; set; }



    }
}
