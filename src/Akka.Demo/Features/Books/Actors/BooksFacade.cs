using System;
using System.Threading.Tasks;
using Akka.Demo.Features.Books.Commands;

namespace Akka.Demo.Features.Books.Actors
{
    using BuildingBlocks;

    public interface IBooksFacade 
    {
        Task<Guid> AddBookAsync(AddBookCommand command);
    }

    internal sealed class BooksFacade : IBooksFacade
    {
        private readonly IRepository<Book> _repository;

        public BooksFacade(IRepository<Book> repository)
        {
            this._repository = repository;
        }

        public async Task<Guid> AddBookAsync(AddBookCommand command)
        {
            var book = new Book(command.Name, command.Isbn);
            await _repository.AddAsync(book);
            return book.Id;
        }
    }
}
