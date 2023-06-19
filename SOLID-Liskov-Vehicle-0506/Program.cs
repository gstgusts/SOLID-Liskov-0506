namespace LSP;

public class Program
{
    public static void TestDrive(Vehicle vehicle)
    {
        vehicle.Drive();
    }
    public static void Main(string[] args)
    {
        var car = new Car();
        TestDrive(car);

        var truck = new Truck();
        TestDrive(truck);

        Vehicle aircraft = new Aircraft();
        TestDrive(aircraft); // side effect
    }
}