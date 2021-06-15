using Xunit;

namespace Richargh.Sandbox.ContractTests.Library.IntTest
{
    [CollectionDefinition(Name)]
    public class MongoCollection
    {
        // This class has no code, and is never created. It's just the way to define Test Collections in xUnit.Net
        public const string Name = "Mongo collection";
        
        public const string MongoUrl = "mongodb://localhost:27017";
    }
}