using System.Threading.Tasks;
using MongoDB.Driver;
using Richargh.Sandbox.ContractTests.Library.Application;

namespace Richargh.Sandbox.ContractTests.Library.Adapter
{
    public class MongoBooks : IBooks
    {
        private readonly IMongoCollection<Book> _allBooks;
        private static readonly ReplaceOptions Overwrite = new() {IsUpsert = true};
        
        public MongoBooks(MongoUrl mongoUrl)
        {
            _allBooks = Database.Create(mongoUrl).GetCollection<Book>("sandbox.contracttests.library.books");
        }

        public async Task Put(Book book)
        {
            await _allBooks.ReplaceOneAsync(x => book.Id.Equals(x.Id), book, Overwrite);
        }

        public async Task<Book?> FindById(Book.BookId id)
        {
            return (await _allBooks.FindAsync(x => x.Id.Equals(id))).FirstOrDefault();
        }
    }
}