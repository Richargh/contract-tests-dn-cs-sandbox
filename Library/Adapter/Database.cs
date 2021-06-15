using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace Richargh.Sandbox.ContractTests.Library.Adapter
{
    public static class Database
    {
        private const string DbName = "richargh-db";
        
        public static IMongoDatabase Create(MongoUrl mongoUrl)
        {
            var database = new MongoClient(mongoUrl).GetDatabase(DbName);

            var pack = new ConventionPack
            {
                new CamelCaseElementNameConvention(), 
                new EnumRepresentationConvention(BsonType.String)
            };
            ConventionRegistry.Register("RSS Conventions", pack, _ => true);
            
            return database;
        }
    }
}