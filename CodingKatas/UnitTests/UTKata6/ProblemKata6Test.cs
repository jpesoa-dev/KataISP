using CodingKatas.Kata6;

namespace UnitTests.UTKata6;

public class ProblemKata6Test
{
    [Fact]
    public void CreditCardProcessor_ShouldProcessCreditCard()
    {
        var processor = new CreditCardProcessor();
        var ex = Record.Exception(() => processor.ProcessCreditCard());
        Assert.Null(ex);
    }

    [Fact]
    public void CreditCardProcessor_OtherMethods_ShouldThrow()
    {
        var processor = new CreditCardProcessor();
        Assert.Throws<NotSupportedException>(() => processor.ProcessPayPal());
        Assert.Throws<NotSupportedException>(() => processor.ProcessCrypto());
    }

    [Fact]
    public void PayPalProcessor_ShouldProcessPayPal()
    {
        var processor = new PayPalProcessor();
        processor.ProcessPayPal();
    }

    [Fact]
    public void PayPalProcessor_CreditCardAndCrypto_ShouldThrow()
    {
        var processor = new PayPalProcessor();
        Assert.Throws<NotSupportedException>(() => processor.ProcessCreditCard());
        Assert.Throws<NotSupportedException>(() => processor.ProcessCrypto());
    }

    [Fact]
    public void CryptoProcessor_ShouldProcessCrypto()
    {
        var processor = new CryptoProcessor();
        processor.ProcessCrypto();
    }

    [Fact]
    public void CryptoProcessor_OtherMethods_ShouldThrow()
    {
        var processor = new CryptoProcessor();
        Assert.Throws<NotSupportedException>(() => processor.ProcessCreditCard());
        Assert.Throws<NotSupportedException>(() => processor.ProcessPayPal());
    }
}
