namespace Garage;

public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }
    public virtual void Drive()
    {
        Console.WriteLine("VROOOM!");
    }
    public virtual void Stop()
    {
        Console.WriteLine("Skrrrt!");
    }
    public virtual void Turn()
    {
        Console.WriteLine("Neeeow!");
    }
}