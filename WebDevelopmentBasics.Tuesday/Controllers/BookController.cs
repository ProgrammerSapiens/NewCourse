using Microsoft.AspNetCore.Mvc;
using WebDevelopmentBasics.Tuesday.Models;

namespace WebDevelopmentBasics.Tuesday.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var books = new List<Book>
            {
                new Book(1,"Lord of the rings", "John Tolkien"),
                new Book(2, "Harry Potter", "Joan Roaling")
            };

            return View(books);
        }
    }
}
