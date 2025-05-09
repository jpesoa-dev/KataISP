using CodingKatas.Kata4;

namespace UnitTests.UTKata4;

public class ProblemKata4Test
{
    [Fact]
    public void TemperatureSensor_ShouldReadTemperature()
    {
        var sensor = new TemperatureSensor();
        var result = sensor.ReadTemperature();
        Assert.Equal(22.5, result);
    }

    [Fact]
    public void TemperatureSensor_ReadPressure_ThrowsException()
    {
        var sensor = new TemperatureSensor();
        Assert.Throws<NotSupportedException>(() => sensor.ReadPressure());
    }

    [Fact]
    public void PressureSensor_ShouldReadPressure()
    {
        var sensor = new PressureSensor();
        var result = sensor.ReadPressure();
        Assert.Equal(1013.25, result);
    }

    [Fact]
    public void PressureSensor_ReadHumidity_ThrowsException()
    {
        var sensor = new PressureSensor();
        Assert.Throws<NotSupportedException>(() => sensor.ReadHumidity());
    }

    [Fact]
    public void HumiditySensor_ShouldReadHumidity()
    {
        var sensor = new HumiditySensor();
        var result = sensor.ReadHumidity();
        Assert.Equal(60.5, result);
    }

    [Fact]
    public void HumiditySensor_ReadTemperature_ThrowsException()
    {
        var sensor = new HumiditySensor();
        Assert.Throws<NotSupportedException>(() => sensor.ReadTemperature());
    }
}
