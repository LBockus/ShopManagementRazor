using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Models
{
    public class ShopItem
    {
        public string name { get; set; }
        public string shopName { get; set; }
        public DateTime expiryDate { get; set; } = DateTime.Now;
    }
}
