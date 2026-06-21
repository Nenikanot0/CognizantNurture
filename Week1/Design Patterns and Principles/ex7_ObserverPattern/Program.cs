using System;

class Program
{
    static void Main(string[] args)
    {
        StockMarket stockMarket = new StockMarket();

        Observer mobileApp = new MobileApp();
        Observer webApp = new WebApp();

        stockMarket.RegisterObserver(mobileApp);
        stockMarket.RegisterObserver(webApp);

        stockMarket.SetStock("TCS", 3850.50);

        Console.WriteLine();

        stockMarket.SetStock("Infosys", 1620.75);
    }
}