using Fresh_Cart.DatabaseOps;
using Fresh_Cart.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fresh_Cart.Controllers
{
    public class OrderController : Controller
    {
        FCDBContext _dbContext;
        public OrderController()
        {
            _dbContext = new FCDBContext();
        }
        [HttpPost]
        public IActionResult Create(Order order)
        {
            _dbContext.Orders.Add(order);
            int successCount =  _dbContext.SaveChanges();
            if (successCount > 0)
            {
                return RedirectToAction("Details", new { order.Id});
            }
            else return View();
        }
        public IActionResult Details(long id)
        {
            //var order = _dbContext.Orders.Where(c => c. == id).FirstOrDefault();
            //Order order = new Order();
            return View(_dbContext.Orders);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
