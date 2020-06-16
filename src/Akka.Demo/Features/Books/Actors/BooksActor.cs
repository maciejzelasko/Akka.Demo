using System.Threading.Tasks;
using Akka.Actor;
using Akka.Demo.BuildingBlocks;
using Akka.Demo.Features.Books.Commands;

namespace Akka.Demo.Features.Books.Actors
{
    public class BooksActor : ReceiveActor
    {
        private readonly IRepository<Book> _repository;

        public BooksActor(IRepository<Book> repository)
        {
            _repository = repository;

            ReceiveAsync<AddBookCommand>(AddBookAsync);
        }

        private async Task AddBookAsync(AddBookCommand command)
        {
            var book = new Book();

            await _repository.AddAsync(book);
            Sender.Tell(book.EntityId);
        }
    }
}
