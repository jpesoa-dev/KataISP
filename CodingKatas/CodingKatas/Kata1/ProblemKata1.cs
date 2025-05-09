namespace CodingKatas.Kata1;

public class ProblemKata1
{
}

public interface IAnimal
{
    void Fly();
    void Swim();
    void Run();
}

public class Bird : IAnimal
{
    public void Fly() => Console.WriteLine("Bird is flying.");
    public void Swim() => throw new NotImplementedException("Bird can't swim.");
    public void Run() => Console.WriteLine("Bird is running.");
}

public class Fish : IAnimal
{
    public void Fly() => throw new NotImplementedException("Fish can't fly.");
    public void Swim() => Console.WriteLine("Fish is swimming.");
    public void Run() => throw new NotImplementedException("Fish can't run.");
}

public class Dog : IAnimal
{
    public void Fly() => throw new NotImplementedException("Dog can't fly.");
    public void Swim() => Console.WriteLine("Dog is swimming.");
    public void Run() => Console.WriteLine("Dog is running.");
}
