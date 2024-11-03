using Observer.Subscribers;

namespace Observer.Publisher;

public class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers = [];
    private float _temperature;

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_temperature);
        }
    }

    public void SetTemperature(float temp)
    {
        _temperature = temp;
        NotifyObservers(); // Уведомляем подписчиков при изменении температуры
    }
}