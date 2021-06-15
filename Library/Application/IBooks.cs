using System.Threading.Tasks;

namespace Richargh.Sandbox.ContractTests.Library.Application
{
    public interface IBooks
    {
        public Task Put(Book book);
        
        public Task<Book?> FindById(Book.BookId id);
    }
}