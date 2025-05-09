namespace CodingKatas.Kata2;

public class SolutionKata2
{
}

public interface IPrintable
{
    void Print();
}

public interface IScannable
{
    void Scan();
}

public interface IFaxable
{
    void Fax();
}

public class BasicPrinterSolution : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }
}

public class AllInOnePrinter : IPrintable, IScannable, IFaxable
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning document...");
    }

    public void Fax()
    {
        Console.WriteLine("Faxing document...");
    }
}
