namespace Garage;

public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"{MainColor} Zap!");
    }
    public override void Turn()
    {
        Console.WriteLine("The Tesla careens recklessly around a corner.");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla rolls to a stop, then rusts into oblivion after encountering a single drop of water.");
    }
}