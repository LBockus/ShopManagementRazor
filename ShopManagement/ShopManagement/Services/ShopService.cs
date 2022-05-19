using ShopManagement.Data;
using ShopManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopManagement.Services
{
    public class ShopService
    {
        private DataContext _dataContext;

        public ShopService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<ShopItem> GetAll()
        {
            return _dataContext.shopItems.ToList();
        }

        public void Add(ShopItem shopitem)
        {
            _dataContext.Add(shopitem);
            _dataContext.SaveChanges();
        }

        public void Remove(string name)
        {
            var shopItem = _dataContext.shopItems.FirstOrDefault(t => t.Name == name);
            _dataContext.shopItems.Remove(shopItem);
            _dataContext.SaveChanges();
        }

        public ShopItem Get(int id)
        {
            var item = _dataContext.shopItems.FirstOrDefault(t => t.Id == id);
            if(id == null)
            {
                throw new ArgumentException("Item was not found");
            }
            return item;
        }

        public void Edit(ShopItem shopItem)
        {
            ShopItem item = _dataContext.shopItems.FirstOrDefault(c => c.Id == shopItem.Id);
            item.Name = shopItem.Name;
            item.ExpiryDate = shopItem.ExpiryDate;
            item.ShopName = shopItem.ShopName;
            _dataContext.SaveChanges();
        }
    }
}
