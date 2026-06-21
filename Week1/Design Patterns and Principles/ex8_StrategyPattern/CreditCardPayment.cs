using System;

public class CreditCardPayment : PaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine(
            $"Paid Rs.{amount} using Credit Card.");
    }
}