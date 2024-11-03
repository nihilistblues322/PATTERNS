using Observer.Publisher;
using Observer.Subscribers;

namespace Observer;

class Program
{
    static void Main()
    {
        WeatherStation weatherStation = new WeatherStation();

        PhoneDisplay phoneDisplay = new PhoneDisplay();
        WindowDisplay windowDisplay = new WindowDisplay();
        ComputerDisplay computerDisplay = new ComputerDisplay();

        weatherStation.RegisterObserver(phoneDisplay);
        weatherStation.RegisterObserver(windowDisplay);
        weatherStation.RegisterObserver(computerDisplay);

        // Изменяем температуру и уведомляем подписчиков
        weatherStation.SetTemperature(25.0f);
        weatherStation.SetTemperature(30.0f);

        // Убираем одного подписчика и обновляем температуру
        weatherStation.RemoveObserver(phoneDisplay);
        weatherStation.SetTemperature(28.0f);
    }
}