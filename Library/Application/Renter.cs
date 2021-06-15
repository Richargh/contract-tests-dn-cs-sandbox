using MongoDB.Bson.Serialization.Attributes;

namespace Richargh.Sandbox.ContractTests.Library.Application
{
    public class Renter
    {
        [BsonId]
        public RenterId Id { get; }
        
        public Renter(RenterId id)
        {
            Id = id;
        }
        
        public record RenterId(string RawValue);
    }
}