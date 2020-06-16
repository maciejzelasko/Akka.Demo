using System.Threading.Tasks;
using Akka.Demo.Features.Books.Actors;
using Akka.Demo.Features.Books.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Akka.Demo.Features.Books
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBooksFacade _books;

        public BooksController(IBooksFacade books)
        {
            _books = books;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] AddBookCommand command)
        {
            var bookId = await _books.AddBookAsync(command);
            return Accepted($"books/{bookId}");
        }
    }
}
