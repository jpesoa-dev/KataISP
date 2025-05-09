using CodingKatas.Kata5;

namespace UnitTests.UTKata5;

public class ProblemKata5Test
{
    [Fact]
    public void SmartLight_ShouldTurnOnAndConnectWiFi()
    {
        var device = new SmartLight();
        var ex1 = Record.Exception(() => device.TurnOn());
        var ex2 = Record.Exception(() => device.ConnectToWiFi());

        Assert.Null(ex1);
        Assert.Null(ex2);
    }

    [Fact]
    public void SmartLight_PlayMusic_ShouldThrowException()
    {
        var device = new SmartLight();
        Assert.Throws<NotSupportedException>(() => device.PlayMusic());
    }

    [Fact]
    public void SmartSpeaker_ShouldPerformAllFunctions()
    {
        var device = new SmartSpeaker();

        device.TurnOn();
        device.ConnectToWiFi();
        device.PlayMusic();
    }
}
