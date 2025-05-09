using CodingKatas.Kata1;
using CodingKatas.Kata3;

namespace UnitTests.UTKata3;

public class SolutionKata3Test
{
    [Fact]
    public void Car_ShouldDrive()
    {
        IDrivable car = new CarSolution();
        car.Drive();
    }

    [Fact]
    public void Plane_ShouldFly()
    {
        IFlyableSolutionKata3 plane = new PlaneSolution();
        plane.Fly();
    }

    [Fact]
    public void Boat_ShouldSail()
    {
        ISailable boat = new BoatSolution();
        boat.Sail();
    }
}
