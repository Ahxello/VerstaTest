using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VerstaTest.Data;
using VerstaTest.Models;

namespace VerstaTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Order> orders = _db.Orders.ToList();
            return View(orders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order obj)
        {
            if (ModelState.IsValid)
            {
                obj.OrderId = Guid.NewGuid();
                _db.Orders.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Заказ создан успешно";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult CheckOrder(Guid? id)
        {
            if (id == null || id == Guid.Empty) { return NotFound(); }
            var orderFromDb = _db.Orders.Find(id);
            if (orderFromDb == null) { return NotFound(); }
            return View(orderFromDb);
        }
    }
}
