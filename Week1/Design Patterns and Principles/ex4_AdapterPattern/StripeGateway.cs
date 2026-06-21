using System;

public class StripeGateway
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Payment of Rs.{amount} processed through Stripe.");
    }
}