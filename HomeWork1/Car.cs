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
    int age;
    public int Age
    { get { return age = DateTime.Now.Year - year; }
    set { age = value; }
   
}
    public double Mileage
    {
         get { return mileage; }
        private set { mileage = value; }
    }
    public virtual void Drive(int distanceKM, int timeH)
    {
        Console.WriteLine($"Average speed: {distanceKM / timeH}" );
    }
    ~Car()
    {
        Console.WriteLine("Object was deleted");
    }
    
   
}







