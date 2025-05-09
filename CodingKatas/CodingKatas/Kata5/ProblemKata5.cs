namespace CodingKatas.Kata5;

internal class ProblemKata5
{
}

public interface ISmartDevice
{
    void TurnOn();
    void TurnOff();
    void ConnectToWiFi();
    void PlayMusic();
}

public class SmartLight : ISmartDevice
{
    public void TurnOn() => Console.WriteLine("Smart Light is turned on.");
    public void TurnOff() => Console.WriteLine("Smart Light is turned off.");
    public void ConnectToWiFi() => Console.WriteLine("Smart Light connected to WiFi.");
    public void PlayMusic() => throw new NotSupportedException("Smart Light can't play music.");
}

public class SmartSpeaker : ISmartDevice
{
    public void TurnOn() => Console.WriteLine("Smart Speaker is turned on.");
    public void TurnOff() => Console.WriteLine("Smart Speaker is turned off.");
    public void ConnectToWiFi() => Console.WriteLine("Smart Speaker connected to WiFi.");
    public void PlayMusic() => Console.WriteLine("Smart Speaker is playing music.");
}