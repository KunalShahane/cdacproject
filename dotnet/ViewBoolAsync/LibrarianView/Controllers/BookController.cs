using BL;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibrarianViewUsers.Controllers
{
    public class BookController : Controller
    {
        BookBL bbl = new BookBL();
        public async Task < IActionResult> Index()
        {
            List<Book> blist = await bbl.getAllBook();
            return View(blist);
        }
    }
}
