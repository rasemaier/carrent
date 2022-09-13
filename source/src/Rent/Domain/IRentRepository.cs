namespace CarRent.Rent.Domain
{
    using CarRent.Common.Domain;

    public interface IRentRepository : IRepository<Rent>
    {
        Rent GetByRentNumber(string rentNumber);
    }
}
