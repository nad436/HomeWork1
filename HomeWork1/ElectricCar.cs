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






