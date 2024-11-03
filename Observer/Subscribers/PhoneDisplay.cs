namespace Observer.Subscribers;

public class PhoneDisplay : IObserver
{
    private float _temperature;

    public void Update(float temp)
    {
        _temperature = temp;
        Console.WriteLine($"Phone Display: Температура обновлена до {_temperature}°C");
    }
}