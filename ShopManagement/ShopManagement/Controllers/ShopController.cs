using Microsoft.AspNetCore.Mvc;
using ShopManagement.Models;
using ShopManagement.Services;

namespace ShopManagement.Controllers
{
    public class ShopController : Controller
    {
        private ShopService _shopService;

        public ShopController(ShopService shopService)
        {
            _shopService = shopService;
        }

        public IActionResult Index()
        {
            var shopitem = _shopService.GetAll();
            return View(shopitem);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ShopItem shopitem = new ShopItem();
            return View(shopitem);
        }

        [HttpPost]
        public IActionResult Add(ShopItem shopItem)
        {
            _shopService.Add(shopItem);
                return RedirectToAction("Index");
        }

        public IActionResult Remove(string name)
        {
            _shopService.Remove(name);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ShopItem shopItem = _shopService.Get(id);
            return View(shopItem);
        }

        [HttpPost]
        public IActionResult Edit(ShopItem shopItem)
        {
            _shopService.Edit(shopItem);
            return RedirectToAction("Index");
        }
    }
}
