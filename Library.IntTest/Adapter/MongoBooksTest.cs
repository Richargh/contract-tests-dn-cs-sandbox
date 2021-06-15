using MongoDB.Driver;
using Richargh.Sandbox.ContractTests.Library.Adapter;
using Richargh.Sandbox.ContractTests.Library.Test.Application;
using Xunit;

namespace Richargh.Sandbox.ContractTests.Library.IntTest.Adapter
{
    [Collection(MongoCollection.Name)]
    public class MongoBooksTest : BooksContract
    {
        public MongoBooksTest() : base(new MongoBooks(new MongoUrl(MongoCollection.MongoUrl)))
        {
        }
    }
}