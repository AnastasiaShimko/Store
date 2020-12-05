using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        StoreContext db;

        public HomeController(ILogger<HomeController> logger, StoreContext context)
        {
            db = context;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View(db.Phones.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.PhoneId = id;
            return View();
        }
        [HttpPost]
        public string Buy(User user, int phoneId)
        {
            Order order = new Order();
            order.User = user;
            order.ProductId = phoneId;
            db.Users.Add(user);
            db.Orders.Add(order);
            // сохраняем в бд все изменения
            //db.SaveChanges();
            return "Thanks, " + order.User.Name + "!";
        }
    }
}
