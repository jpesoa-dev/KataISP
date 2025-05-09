namespace CodingKatas.Kata3;

public class SolutionKata3
{
}

public interface IDrivable
{
    void Drive();
}

public interface IFlyableSolutionKata3
{
    void Fly();
}

public interface ISailable
{
    void Sail();
}

public class CarSolution : IDrivable
{
    public void Drive() => Console.WriteLine("Car is driving.");
}

public class PlaneSolution : IFlyableSolutionKata3
{
    public void Fly() => Console.WriteLine("Plane is flying.");
}

public class BoatSolution : ISailable
{
    public void Sail() => Console.WriteLine("Boat is sailing.");
}
