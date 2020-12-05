using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Store.Interfaces;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// DIP example.
        /// HomeController class not depends on class EmailMessageSender or TelegramMessageSender.
        /// It depends on interface, so we can easily change its logic by changing singleton service.
        /// </summary>
        private readonly ILogger<HomeController> _logger;
        private IMessageSender _messageSender;
        StoreContext db;

        public HomeController(ILogger<HomeController> logger, StoreContext context, IMessageSender messageSender)
        {
            db = context;
            _messageSender = messageSender;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View(db.Products.ToList());
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
            // Here _messageSender is EmailMessageSender
            var sendMessageResult = _messageSender.Send(order);
            return $"Thanks, {order.User.Name}! {sendMessageResult}";
        }
    }
}
