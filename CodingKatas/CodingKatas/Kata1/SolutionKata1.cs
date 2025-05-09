namespace CodingKatas.Kata1;

public class SolutionKata1
{
}

public interface IFlyable
{
    void Fly();
}

public interface ISwimmable
{
    void Swim();
}

public interface IRunnable
{
    void Run();
}

public class BirdSolution : IFlyable, IRunnable
{
    public void Fly() => Console.WriteLine("Bird is flying.");
    public void Run() => Console.WriteLine("Bird is running.");
}

public class FishSolution : ISwimmable
{
    public void Swim() => Console.WriteLine("Fish is swimming.");
}

public class DogSolution : ISwimmable, IRunnable
{
    public void Swim() => Console.WriteLine("Dog is swimming.");
    public void Run() => Console.WriteLine("Dog is running.");
}
