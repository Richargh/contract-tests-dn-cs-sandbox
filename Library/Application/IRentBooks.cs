namespace Richargh.Sandbox.ContractTests.Library.Application
{
    public interface IRentBooks
    {
        public void Rent(Book.BookId id, Renter.RenterId renterId);
    }
}