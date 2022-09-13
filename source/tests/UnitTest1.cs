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
        var test = carController.Post(carResponseDto);

        Assert.Equal(test,carResponseDto);
    }



    [Fact]
    public void Light_JustBlue_True()
    {
        Light light = new Light();

        light.JustBlue();

        Assert.False(light.red);
        Assert.False(light.green);
        Assert.True(light.blue);
        Assert.False(light.yellow);
    }

    [Fact]
    public void Light_JustBlue_True2()
    {
        Light light = new Light();

        light.JustBlue();

        Assert.Equal("rgBy", light.getState());
    }

    

}

public class Light
{
    public bool red { get; set; }
    public bool green { get; set; }
    public bool blue { get; set; }
    public  bool yellow { get; set; }


    public Light()
    {
        
    }

    public void JustBlue()
    {
        this.red = false;
        this.green = false;
        this.blue = true;
        this.yellow = false;
    }

    public string getState()
    {
        string state = "";
        state += red ? "R" : "r";
        state += green ? "G" : "g";
        state += blue ? "B" : "b";
        state += yellow ? "Y" : "y";
        return state;

    }
}