namespace CodingKatas.Kata3;

public class ProblemKata3
{
}

public interface IVehicle
{
    void Drive();
    void Fly();
    void Sail();
}

public class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Car is driving.");
    public void Fly() => throw new NotSupportedException("Car can't fly.");
    public void Sail() => throw new NotSupportedException("Car can't sail.");
}

public class Plane : IVehicle
{
    public void Drive() => throw new NotSupportedException("Plane can't drive.");
    public void Fly() => Console.WriteLine("Plane is flying.");
    public void Sail() => throw new NotSupportedException("Plane can't sail.");
}

public class Boat : IVehicle
{
    public void Drive() => throw new NotSupportedException("Boat can't drive.");
    public void Fly() => throw new NotSupportedException("Boat can't fly.");
    public void Sail() => Console.WriteLine("Boat is sailing.");
}
