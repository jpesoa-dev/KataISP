using CodingKatas.Kata3;

namespace UnitTests.UTKata3;

public class ProblemKata3Test
{
    [Fact]
    public void Car_ShouldDrive()
    {
        var car = new Car();
        var exception = Record.Exception(() => car.Drive());
        Assert.Null(exception);
    }

    [Fact]
    public void Car_Fly_ThrowsNotSupportedException()
    {
        var car = new Car();
        Assert.Throws<NotSupportedException>(() => car.Fly());
    }

    [Fact]
    public void Plane_ShouldFly()
    {
        var plane = new Plane();
        var exception = Record.Exception(() => plane.Fly());
        Assert.Null(exception);
    }

    [Fact]
    public void Plane_Drive_ThrowsNotSupportedException()
    {
        var plane = new Plane();
        Assert.Throws<NotSupportedException>(() => plane.Drive());
    }

    [Fact]
    public void Boat_ShouldSail()
    {
        var boat = new Boat();
        var exception = Record.Exception(() => boat.Sail());
        Assert.Null(exception);
    }

    [Fact]
    public void Boat_Fly_ThrowsNotSupportedException()
    {
        var boat = new Boat();
        Assert.Throws<NotSupportedException>(() => boat.Fly());
    }
}
