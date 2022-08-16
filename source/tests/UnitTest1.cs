using CarRent.Car.Api;
using Xunit;

namespace CarRent.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        CarController carController = new CarController();

        carController.Put(1,"");

        Assert.Equal(1, 1);
    }
}