namespace Garage;

public class Cessna : Vehicle  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine("Whoosh!");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Cessna gracefully banks against the sky");
    }
    public override void Stop()
    {
        Console.WriteLine("The Cessna suddenly stops in midair; its engines stall out and it crashes and burns.");
    }
}