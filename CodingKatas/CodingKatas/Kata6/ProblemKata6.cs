namespace CodingKatas.Kata6;

internal class ProblemKata6
{
}

public interface IPaymentProcessor
{
    void ProcessCreditCard();
    void ProcessPayPal();
    void ProcessCrypto();
}

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessCreditCard() => Console.WriteLine("Processing credit card payment...");
    public void ProcessPayPal() => throw new NotSupportedException("PayPal not supported.");
    public void ProcessCrypto() => throw new NotSupportedException("Crypto not supported.");
}

public class PayPalProcessor : IPaymentProcessor
{
    public void ProcessCreditCard() => throw new NotSupportedException("Credit card not supported.");
    public void ProcessPayPal() => Console.WriteLine("Processing PayPal payment...");
    public void ProcessCrypto() => throw new NotSupportedException("Crypto not supported.");
}

public class CryptoProcessor : IPaymentProcessor
{
    public void ProcessCreditCard() => throw new NotSupportedException("Credit card not supported.");
    public void ProcessPayPal() => throw new NotSupportedException("PayPal not supported.");
    public void ProcessCrypto() => Console.WriteLine("Processing crypto payment...");
}
