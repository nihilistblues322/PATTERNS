namespace Observer.Subscribers;

public class WindowDisplay : IObserver
{
    private float _temperature;

    public void Update(float temp)
    {
        _temperature = temp;
        Console.WriteLine($"Window Display: Температура обновлена до {_temperature}°C");
    }
}