namespace CarRent.Customer.Domain
{
    using CarRent.Common.Domain;

    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByCustomerNumber(string carNumber);
    }
}
