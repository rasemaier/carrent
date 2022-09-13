using CarRent.Common.Domain;

namespace CarRent.Customer.Domain
{
    // (Supplier)
    public class Customer : Entity, IAggregateRoot
    {
        public string CustomerNumber { get; }
    }
}
