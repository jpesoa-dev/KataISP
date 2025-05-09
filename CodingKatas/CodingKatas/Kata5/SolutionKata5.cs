namespace CodingKatas.Kata5;

internal class SolutionKata5
{
}

public interface IPowerControllable
{
    void TurnOn();
    void TurnOff();
}

public interface IWiFiConnectable
{
    void ConnectToWiFi();
}

public interface IMusicPlayable
{
    void PlayMusic();
}

public class SmartLightSolution : IPowerControllable, IWiFiConnectable
{
    public void TurnOn() => Console.WriteLine("Smart Light is turned on.");
    public void TurnOff() => Console.WriteLine("Smart Light is turned off.");
    public void ConnectToWiFi() => Console.WriteLine("Smart Light connected to WiFi.");
}

public class SmartSpeakerSolution : IPowerControllable, IWiFiConnectable, IMusicPlayable
{
    public void TurnOn() => Console.WriteLine("Smart Speaker is turned on.");
    public void TurnOff() => Console.WriteLine("Smart Speaker is turned off.");
    public void ConnectToWiFi() => Console.WriteLine("Smart Speaker connected to WiFi.");
    public void PlayMusic() => Console.WriteLine("Smart Speaker is playing music.");
}
