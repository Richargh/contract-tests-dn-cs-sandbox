using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Richargh.Sandbox.ContractTests.Library.Application;

namespace Richargh.Sandbox.ContractTests.Library.Fixtures.Adapter
{
    public class InMemoryBooks : IBooks
    {
        private readonly IDictionary<Book.BookId, Book> _allBooks;

        public InMemoryBooks(IEnumerable<Book> books)
        {
            _allBooks = books.ToDictionary(it => it.Id);
        }

        public InMemoryBooks(params Book[] books) : this(books.ToList()) { }
        public InMemoryBooks() : this(new List<Book>()) { }

        public Task Put(Book book)
        {
            _allBooks[book.Id] = book;
            return Task.CompletedTask;
        }

        public Task<Book?> FindById(Book.BookId id)
        {
            return Task.FromResult(_allBooks.ContainsKey(id) ? _allBooks[id] : default);
        }
    }
}