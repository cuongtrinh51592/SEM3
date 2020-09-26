using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session09.Models;

namespace Session09.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST:  Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(
            [Bind("ID,Title,ReleaseDate,Cost")] BookModel bookModel)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(bookModel);
        }
    }
}
