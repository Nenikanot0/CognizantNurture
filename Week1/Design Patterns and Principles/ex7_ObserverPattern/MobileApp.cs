using System;

public class MobileApp : Observer
{
    public void Update(string stockName, double stockPrice)
    {
        Console.WriteLine(
            $"Mobile App: {stockName} price updated to Rs.{stockPrice}");
    }
}