//Author : SkyKOG

public interface IPointy
{
	byte Points { get; }
}

class Hexagon : Shape,IPointy
{
	public Hexagon() {}
	public Hexagon (string name) : base(name){}

	//IPointy Implementation
	public byte Points
	{
		get {return 6;}
	}
}

static void Main(string[] args)
{
	Hexagon hex2 = new Hexagon("Peter");
	IPointy ispointy = hex2 as IPointy;
	if(ispointy != null)
		Console.WriteLine("Points: {0}", ispointy.Points);
	else
		Console.WriteLine("OOPS! Not pointy...");
}

/*

The Explainaition : 

Well This program works on the simle principle that certain operations will be performed 
when associated members are invoked ... an interface in C# is like inheritance an in the 
above program we are trying to inherit some features depending upon need ... 

An interface addes features to a class without modifying the class itself ... the values inside 
the interface are worked upon using the set and get methods ...

When we say :
Hexagon hex2 = new Hexagon("Peter");
this is gonna work perfectly as Shape is a class and the Hexagon class inherits from it 
the line "public Hexagon (string name)" will recieve the passed string "Peter" and appropriate 
operation of printing will be performed ... the implementation of Shape class has been omitted.

The interface feature is implemented as follows : 
To implement a feature of points the IPointy interface has been	created for certain shapes ...
we are checking weather the association has been done using the check "hex2 as Ipointy"
if the association exists then the points will be printed accordingly. 
(And in our case the association exists as we have associated Hexagon with IPointly "class Hexagon : Shape,IPointy")
the points are set and returned using the property Points

*/

