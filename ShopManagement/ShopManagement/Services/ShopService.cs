using ShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Services
{
    public class ShopService
    {
        public ShopService()
        {

        }

        private List<ShopItem> _shopItem = new List<ShopItem>();

        public List<ShopItem> GetAll()
        {
            return _shopItem;
        }

        public void Add(ShopItem shopitem)
        {
            _shopItem.Add(shopitem);
        }

        public void Remove(string name)
        {
            _shopItem = _shopItem.Where(si => si.name != name).ToList();
        }
    }
}
