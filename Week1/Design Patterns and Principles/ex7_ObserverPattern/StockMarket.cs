using System.Collections.Generic;

public class StockMarket : Stock
{
    private List<Observer> observers = new List<Observer>();

    private string stockName;
    private double stockPrice;

    public void RegisterObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(Observer observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (Observer observer in observers)
        {
            observer.Update(stockName, stockPrice);
        }
    }

    public void SetStock(string name, double price)
    {
        stockName = name;
        stockPrice = price;
        NotifyObservers();
    }
}