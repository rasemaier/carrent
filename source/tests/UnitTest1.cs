using CarRent.Car.Api;
using CarRent.Car.Api.v1;
using Xunit;

namespace CarRent.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        CarController carController = new CarController();
        CarResponseDto carResponseDto = new CarResponseDto();
        carController.Post(carResponseDto);

        Assert.Equal(1, 1);
    }
}