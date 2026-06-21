public class PaymentContext
{
    private PaymentStrategy paymentStrategy;

    public PaymentContext(PaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(PaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void ExecutePayment(double amount)
    {
        paymentStrategy.Pay(amount);
    }
}