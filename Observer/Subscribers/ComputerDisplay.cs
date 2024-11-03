namespace Observer.Subscribers;

public class ComputerDisplay : IObserver
{
    private float _temperature;
    public void Update(float temperature)
    {
        _temperature = temperature;
        Console.WriteLine($"Computer Display: Температура обновлена до {_temperature}°C");
    }
}