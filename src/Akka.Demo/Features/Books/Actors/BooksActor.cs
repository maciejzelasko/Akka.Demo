using System.Threading.Tasks;
using Akka.Actor;
using Akka.Demo.Features.Books.Commands;

namespace Akka.Demo.Features.Books.Actors
{
    public class BooksActor : ReceiveActor
    {
        private readonly IBookRepository _repository;

        public BooksActor(IBookRepository repository)
        {
            _repository = repository;

            ReceiveAsync<AddBookCommand>(AddBookAsync);
        }

        private async Task AddBookAsync(AddBookCommand command)
        {
            var book = new Book(command.Name, command.Isbn);
            await _repository.AddAsync(book);
            Sender.Tell(book.Id);
        }
    }
}
