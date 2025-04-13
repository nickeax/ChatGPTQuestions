/*
10. Events and Event Handlers
Question: Create a class TemperatureSensor that raises an event when the temperature exceeds 30°C. 
Create a method HandleTemperatureExceeded to handle this event and print a message when it's triggered. 
 */
var monitor = new TemperatureMonitor();


public class TemperatureEventArgs : EventArgs
{
    public int Temperature { get; set; }
    public string Message { get; set; }
}

public class TemperatureMonitor
{
    public TemperatureMonitor()
    {
        var ts = new TemperatureSensor();
        ts.DangerousTemperature += Notification;
        ts.TemperatureChanged += Notification;

        ts.BeginTemperatureIncrease(20, 30);
    }

    public void Notification(Object sender, TemperatureEventArgs temperatureEventArgs)
    {
        Console.WriteLine($"UPDATE: {temperatureEventArgs.Message}");
    }
}

public class TemperatureSensor
{
    public event EventHandler<TemperatureEventArgs> TemperatureChanged;
    public event EventHandler<TemperatureEventArgs> DangerousTemperature;

    public void BeginTemperatureIncrease(int startingTemperature, int maxTemperature)
    {
        for (int i = startingTemperature; i < 2000; i++)
        {
            RaiseTemperatureChanged(i);
            Thread.Sleep(300);
            if (i >= maxTemperature)
            {
                RaiseDangerousTemperature(i);
                break;
            }
        }
    }

    public void RaiseTemperatureChanged(int temperature)
    {
        TemperatureChanged?.Invoke(this, new TemperatureEventArgs { Message = $"Temperature update: {temperature}℃" });
    }

    public void RaiseDangerousTemperature(int dangerousTemperature)
    {
        DangerousTemperature?.Invoke(this, new TemperatureEventArgs { Message = $"WARNING: Dangerous temperature of {dangerousTemperature}℃ reached!" });
    }

}