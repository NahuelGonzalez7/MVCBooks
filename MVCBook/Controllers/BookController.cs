using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBook.Admin;
using MVCBook.Models;

namespace MVCBook.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View("Index",AdmBook.List());
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            Book book = new Book();
            return View("Create", book);
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                AdmBook.Insert(book);
                return RedirectToAction("Index");
            }
            return View("Create", book);
        }
    }
}