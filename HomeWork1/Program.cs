
using System.Runtime.CompilerServices;

public class Car
{

    string brand;
    string model;
    int year;
    double mileage;

    
    public Car(string brand, string model, int year, double mileage)
    {
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.mileage = mileage;
    }
    public virtual void Drive(double distance)
    {
        mileage += distance;

    }
    public int Age
    { get { return year; }
    set { int age = DateTime.Now.Year - year; }
   
}
    public double Mileage
    {
         get { return mileage; }
        private set { mileage = value; }
    }
    public virtual void Drive(int distanceKM, int timeH)
    {
        Console.WriteLine($" Average speed {distanceKM / timeH}" );
    }
    ~Car()
    {
        Console.WriteLine("Object was deleted");
    }
    
   
}



public class ElectricCar: Car
{
    private double batteryCapacity;
    private double batteryLevel;
    public ElectricCar(string brand, string model, int year, double mileage, double batteryCapacity)
        : base(brand, model, year, mileage) 
    {
        this.batteryCapacity = batteryCapacity;
        this.batteryLevel = batteryCapacity;// if battery is full
    }

   
    
     public override void Drive(double distance)
    {
        double batteryConsumptionPer1KM = 1.0;
        double requiredBattery = distance * batteryConsumptionPer1KM;
        batteryLevel -= requiredBattery;
        if (batteryLevel < requiredBattery)
        {
            throw new InvalidOperationException("Not enough battery to drive the requested distance.");
        }
    }
    public double BatteryLevel
    {
        get{ return batteryLevel; }
    }
    public void Charge(double amount) 
    {
        batteryLevel += amount;
        if (batteryLevel > batteryCapacity)
        {
            batteryLevel = batteryCapacity;
        }
    }

}







