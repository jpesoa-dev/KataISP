namespace CodingKatas.Kata4;

public class ProblemKata4
{
}

public interface ISensor
{
    double ReadTemperature();
    double ReadPressure();
    double ReadHumidity();
}

public class TemperatureSensor : ISensor
{
    public double ReadTemperature() => 22.5;
    public double ReadPressure() => throw new NotSupportedException("TemperatureSensor can't read pressure.");
    public double ReadHumidity() => throw new NotSupportedException("TemperatureSensor can't read humidity.");
}

public class PressureSensor : ISensor
{
    public double ReadTemperature() => throw new NotSupportedException("PressureSensor can't read temperature.");
    public double ReadPressure() => 1013.25;
    public double ReadHumidity() => throw new NotSupportedException("PressureSensor can't read humidity.");
}

public class HumiditySensor : ISensor
{
    public double ReadTemperature() => throw new NotSupportedException("HumiditySensor can't read temperature.");
    public double ReadPressure() => throw new NotSupportedException("HumiditySensor can't read pressure.");
    public double ReadHumidity() => 60.5;
}
