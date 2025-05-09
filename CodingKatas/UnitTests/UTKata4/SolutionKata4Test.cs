using CodingKatas.Kata4;

namespace UnitTests.UTKata4;

public class SolutionKata4Test
{
    [Fact]
    public void TemperatureSensor_ShouldReadTemperature()
    {
        ITemperatureReadable sensor = new TemperatureSensorSolution(36.7);
        var result = sensor.ReadTemperature();
        Assert.Equal(36.7, result);
    }

    [Fact]
    public void PressureSensor_ShouldReadPressure()
    {
        IPressureReadable sensor = new PressureSensorSolution(1000.3);
        var result = sensor.ReadPressure();
        Assert.Equal(1000.3, result);
    }

    [Fact]
    public void HumiditySensor_ShouldReadHumidity()
    {
        IHumidityReadable sensor = new HumiditySensorSolution(39.9);
        var result = sensor.ReadHumidity();
        Assert.Equal(39.9, result);
    }
}
