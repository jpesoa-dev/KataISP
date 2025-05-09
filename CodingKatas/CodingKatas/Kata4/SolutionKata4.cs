namespace CodingKatas.Kata4;

internal class SolutionKata4
{
}

public interface ITemperatureReadable
{
    double ReadTemperature();
}

public interface IPressureReadable
{
    double ReadPressure();
}

public interface IHumidityReadable
{
    double ReadHumidity();
}

public class TemperatureSensorSolution : ITemperatureReadable
{
    public double temperature {  get; set; }
    public TemperatureSensorSolution(double _temperature)
    {
        temperature = _temperature;
    }
    public double ReadTemperature() => temperature;
}

public class PressureSensorSolution : IPressureReadable
{
    public double pressure { get; set; }
    public PressureSensorSolution(double _pressure)
    {
        pressure = _pressure;
    }
    public double ReadPressure() => pressure;
}

public class HumiditySensorSolution : IHumidityReadable
{
    public double humidity { get; set; }
    public HumiditySensorSolution(double _humidity)
    {
        humidity = _humidity;
    }
    public double ReadHumidity() => humidity;
}
