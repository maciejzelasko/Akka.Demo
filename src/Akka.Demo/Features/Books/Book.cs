using System;

namespace Akka.Demo.Features.Books
{
    using BuildingBlocks;

    public class Book : BaseEntity
    {
        public Book(string name, string isbn)
        {
            Id = Guid.NewGuid();
            Name = name;
            Isbn = isbn;
        }

        public Guid Id { get; }
        public string Name { get; }
        public string Isbn { get; }
    }
}
