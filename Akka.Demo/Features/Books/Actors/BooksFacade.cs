using System;
using System.Threading.Tasks;
using Akka.Demo.Features.Books.Commands;

namespace Akka.Demo.Features.Books.Actors
{
    public interface IBooksFacade 
    {
        Task<Guid> AddBookAsync(AddBookCommand command);
    }

    public class BooksFacade : IBooksFacade
    {
        public Task<Guid> AddBookAsync(AddBookCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
