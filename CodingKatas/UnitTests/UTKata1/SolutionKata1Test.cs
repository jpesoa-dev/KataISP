using CodingKatas.Kata1;

namespace UnitTests.UTKata1;

public class SolutionKata1Test
{
    [Fact]
    public void Bird_ShouldFlyAndRun()
    {
        var bird = new Bird();

        bird.Fly();  // IFlyable
        bird.Run();  // IRunnable
    }

    [Fact]
    public void Fish_ShouldSwim()
    {
        var fish = new Fish();
        fish.Swim();  // ISwimmable
    }

    [Fact]
    public void Dog_ShouldRunAndSwim()
    {
        var dog = new Dog();

        dog.Run();   // IRunnable
        dog.Swim();  // ISwimmable
    }
}
