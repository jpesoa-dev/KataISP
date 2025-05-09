using CodingKatas.Kata1;

namespace UnitTests.UTKata1;

public class ProblemKata1Test
{
    [Fact]
    public void Bird_ShouldFlyAndRun()
    {
        var bird = new Bird();
        var exception = Record.Exception(() =>
        {
            bird.Fly();
            bird.Run();
        });

        Assert.Null(exception);
    }

    [Fact]
    public void Bird_Swim_ShouldThrowException()
    {
        var bird = new Bird();
        Assert.Throws<NotImplementedException>(() => bird.Swim());
    }

    [Fact]
    public void Fish_ShouldSwim()
    {
        var fish = new Fish();
        var exception = Record.Exception(() => fish.Swim());
        Assert.Null(exception);
    }

    [Fact]
    public void Fish_Fly_ShouldThrowException()
    {
        var fish = new Fish();
        Assert.Throws<NotImplementedException>(() => fish.Fly());
    }

    [Fact]
    public void Dog_ShouldRunAndSwim()
    {
        var dog = new Dog();
        dog.Run();
        dog.Swim();
    }

    [Fact]
    public void Dog_Fly_ShouldThrowException()
    {
        var dog = new Dog();
        Assert.Throws<NotImplementedException>(() => dog.Fly());
    }
}
