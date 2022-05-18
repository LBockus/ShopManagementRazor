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
        public IActionResult Add(ShopItem shopitem)
        {
            _shopService.Add(shopitem);
                return RedirectToAction("Index");
        }

        public IActionResult Remove(string name)
        {
            _shopService.Remove(name);
            return RedirectToAction("Index");
        }
    }
}
