using CodingKatas.Kata2;

namespace UnitTests.UTKata2;

public class SolutionKata2Test
{
    [Fact]
    public void BasicPrinter_ShouldOnlyPrint()
    {
        IPrintable printer = new BasicPrinterSolution();
        printer.Print();
    }

    [Fact]
    public void AllInOnePrinter_ShouldPrintScanFax()
    {
        var printer = new AllInOnePrinter();

        printer.Print();
        printer.Scan();
        printer.Fax();
    }

    [Fact]
    public void AllInOnePrinter_AsInterfaces_ShouldWorkIndependently()
    {
        IPrintable printable = new AllInOnePrinter();
        IScannable scannable = new AllInOnePrinter();
        IFaxable faxable = new AllInOnePrinter();

        printable.Print();
        scannable.Scan();
        faxable.Fax();
    }
}
