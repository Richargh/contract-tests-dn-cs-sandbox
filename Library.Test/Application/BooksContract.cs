using System.Threading.Tasks;
using FluentAssertions;
using Richargh.Sandbox.ContractTests.Library.Application;
using Xunit;

namespace Richargh.Sandbox.ContractTests.Library.Test.Application
{
    public abstract class BooksContract
    {
        private readonly IBooks _books;
        
        protected BooksContract(IBooks books)
        {
            _books = books;
        }

        [Fact (DisplayName = "Should not contain any books initially")]
        public async Task InitiallyEmpty()
        {
            // given
            // when
            var result = await _books.FindById(new Book.BookId("123"));
            // then
            result.Should().BeNull();
        }
    }
}
