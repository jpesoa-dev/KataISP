namespace CodingKatas.Kata2;

public class ProblemKata2
{
}

public interface ILegacyPrinter
{
    void Print();
    void Scan();
    void Fax();
}

public class BasicPrinter : ILegacyPrinter
{
    public void Print()
    {
        Console.WriteLine("Printing document...");
    }

    public void Scan()
    {
        throw new NotImplementedException("Scan not supported on BasicPrinter.");
    }

    public void Fax()
    {
        throw new NotImplementedException("Fax not supported on BasicPrinter.");
    }
}
