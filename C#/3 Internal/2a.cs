//Author : SkyKOG

using System;

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

/*

The Explainaition : 

Well this is a program whish implements the IEnumberable interface ...
Not only arrays but any type which supports the method GetEnumerator() can be iterated using the 
foreach construct.
Classes or structues which support this method advertise that they are able to expose the contained 
subitems.
As the System.Array type already implements the IEnumerable & IEnumerator, one can simply delegate the 
request as shown above.
Once the Garage class has been made enumerable by interfacing it with the IEnumerable interface 
(class Garage : IEnumerable)we can use the foreach construct to iterate over the Car objects.

In short IEnumerable allows non-conventional(derived) data types like classes/structures 
to be Enumerable/Iteratable like conventional data types.

*/
