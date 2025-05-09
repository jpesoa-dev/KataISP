using CodingKatas.Kata6;

namespace UnitTests.UTKata6;

public class SolutionKata6Test
{
    [Fact]
    public void CreditCardProcessor_ShouldOnlyProcessCreditCard()
    {
        ICreditCardPayment processor = new CreditCardProcessorSolution();
        processor.ProcessCreditCard();
    }

    [Fact]
    public void PayPalProcessor_ShouldOnlyProcessPayPal()
    {
        IPayPalPayment processor = new PayPalProcessorSolution();
        processor.ProcessPayPal();
    }

    [Fact]
    public void CryptoProcessor_ShouldOnlyProcessCrypto()
    {
        ICryptoPayment processor = new CryptoProcessorSolution();
        processor.ProcessCrypto();
    }
}
