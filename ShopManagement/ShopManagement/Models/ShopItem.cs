using System;

namespace ShopManagement.Models
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShopName { get; set; }
        public DateTime ExpiryDate { get; set; } = DateTime.Now;
    }
}
