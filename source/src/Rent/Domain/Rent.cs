using CarRent.Car.Domain;
using CarRent.Common.Domain;

namespace CarRent.Rent.Domain
{
    public class Rent : Entity, IAggregateRoot
    {
        public string RentNumber { get; }

    }
}
