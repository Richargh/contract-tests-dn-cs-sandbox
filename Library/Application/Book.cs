using MongoDB.Bson.Serialization.Attributes;

namespace Richargh.Sandbox.ContractTests.Library.Application
{
    public class Book
    {

        [BsonId]
        public BookId Id { get; init; }
        
        public BookTitle Title { get; init; }
        
        public Book(
            BookId id, 
            BookTitle title)
        {
            Id = id;
            Title = title;
        }
        
        public record BookTitle(string RawValue);
        public record BookId(string RawValue);
    }
}