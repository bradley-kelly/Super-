using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_ComicBooksCharacters.Models;

namespace MVC_ComicBooksCharacters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ComicBookContext db = null;
        public HomeController(ComicBookContext ComicDB)
        {
            this.db = ComicDB;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<ComicBook> model = (from comic in db.ComicBooks orderby comic.ComicBookTitle select comic).ToList();
            return View(model);
        }
    }
}
