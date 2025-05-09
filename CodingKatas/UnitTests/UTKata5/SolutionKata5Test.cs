using CodingKatas.Kata5;

namespace UnitTests.UTKata5;

public class SolutionKata5Test
{
    [Fact]
    public void SmartLight_ShouldOnlyUsePowerAndWiFi()
    {
        IPowerControllable lightPower = new SmartLightSolution();
        IWiFiConnectable lightWiFi = new SmartLightSolution();

        lightPower.TurnOn();
        lightPower.TurnOff();
        lightWiFi.ConnectToWiFi();
    }

    [Fact]
    public void SmartSpeaker_ShouldSupportAllInterfaces()
    {
        IPowerControllable power = new SmartSpeakerSolution();
        IWiFiConnectable wifi = new SmartSpeakerSolution();
        IMusicPlayable music = new SmartSpeakerSolution();

        power.TurnOn();
        wifi.ConnectToWiFi();
        music.PlayMusic();
    }
}
