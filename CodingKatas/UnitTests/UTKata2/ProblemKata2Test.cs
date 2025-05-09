using CodingKatas.Kata2;

namespace UnitTests.UTKata2;

public class ProblemKata2Test
{
    [Fact]
    public void BasicPrinter_ShouldPrint()
    {
        var printer = new BasicPrinter();
        var exception = Record.Exception(() => printer.Print());
        Assert.Null(exception);
    }

    [Fact]
    public void BasicPrinter_Scan_ShouldThrowNotImplemented()
    {
        var printer = new BasicPrinter();
        Assert.Throws<NotImplementedException>(() => printer.Scan());
    }

    [Fact]
    public void BasicPrinter_Fax_ShouldThrowNotImplemented()
    {
        var printer = new BasicPrinter();
        Assert.Throws<NotImplementedException>(() => printer.Fax());
    }
}
