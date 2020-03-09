using Blockbusta.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blockbusta.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            return View();
        }
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
             return View(customers);

            
        }
        
        public ActionResult Details(int Id)
        {
            var customers = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c=> c.Id == Id);

            if (customers != null)
            {
                return View(customers);
            }
            else
            {
                return HttpNotFound();
            }
        }

    }
}