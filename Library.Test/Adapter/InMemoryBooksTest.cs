using Richargh.Sandbox.ContractTests.Library.Fixtures.Adapter;
using Richargh.Sandbox.ContractTests.Library.Test.Application;

namespace Richargh.Sandbox.ContractTests.Library.Test.Adapter
{
    public class InMemoryBooksTest : BooksContract  
    {
        public InMemoryBooksTest() : base(new InMemoryBooks())
        {
        }
    }
}