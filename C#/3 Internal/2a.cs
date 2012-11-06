//Author : SkyKOG

public class Garage : IEnumerable
{
	private Car[] carArray;
	public Garage()
	{
		carArray = new Car[4];
		carArray[0] = new Car("Merc", 200, 0);
		carArray[1] = new Car("Aston", 90, 0);
		carArray[2] = new Car("Lamborghini", 30, 0);
		carArray[3] = new Car("Sonata", 30, 0);
	}
	public IEnumerator GetEnumerator()
	{
		return carArray.GetEnumerator();
	}
}

public class Program
{
	static void Main(string[] args)
	{
		Garage cars = new Garage();
		foreach (Car c in cars)
		{
			Console.WriteLine("{0} is going {1} MPH",c.name, c.speed);
		}
	}
}