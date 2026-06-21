using System;

public class WebApp : Observer
{
    public void Update(string stockName, double stockPrice)
    {
        Console.WriteLine(
            $"Web App: {stockName} price updated to Rs.{stockPrice}");
    }
}