namespace CodingKatas.Kata6;

internal class SolutionKata6
{
}

public interface ICreditCardPayment
{
    void ProcessCreditCard();
}

public interface IPayPalPayment
{
    void ProcessPayPal();
}

public interface ICryptoPayment
{
    void ProcessCrypto();
}

public class CreditCardProcessorSolution : ICreditCardPayment
{
    public void ProcessCreditCard() => Console.WriteLine("Processing credit card payment...");
}

public class PayPalProcessorSolution : IPayPalPayment
{
    public void ProcessPayPal() => Console.WriteLine("Processing PayPal payment...");
}

public class CryptoProcessorSolution : ICryptoPayment
{
    public void ProcessCrypto() => Console.WriteLine("Processing crypto payment...");
}
