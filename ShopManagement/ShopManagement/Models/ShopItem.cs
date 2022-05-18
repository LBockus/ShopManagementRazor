using System;

namespace ShopManagement.Models
{
    public class ShopItem
    {
        public string name { get; set; }
        public string shopName { get; set; }
        public DateTime expiryDate { get; set; } = DateTime.Now;
    }
}
