<Query Kind="Program" />

void Main()
{
	var apple1 = new Apple() { Variety = "Golden Delicious"};
	var orange1 = new Orange() { Variety = "Navel"};

	//(apple1 == orange1).Dump();
}

// Define other methods and classes here
class Apple 
{
	public string Variety { get; set; }

	#region Hide
//	public static bool operator ==(Apple a1, Apple a2)
//	{
//		"Running apple compairison".Dump();
//		return a1.Variety == a2.Variety;
//	}
//
//	public static bool operator !=(Apple a1, Fruit a2)
//	{
//		return a1.Variety != a2.Variety;
//	}
	#endregion
}

class Orange 
{
	public string Variety { get; set; }

	#region Hide
//	public static bool operator ==(Orange o1, Orange o2)
//	{
//		"Running orange compairison".Dump();
//		return o1.Variety == o2.Variety;
//	}
//
//	public static bool operator !=(Orange o1, Orange o2)
//	{
//		return o1.Variety != o2.Variety;
//	}
	#endregion
}

#region Hide
abstract class Fruit
{
	public string Variety { get; set; }
	
	public static bool operator==(Fruit f1, Fruit f2)
	{
		"Running fruit compairison".Dump();
		return f1.Variety == f2.Variety;
	}

	public static bool operator !=(Fruit f1, Fruit f2)
	{
		return f1.Variety != f2.Variety;
	}
}
#endregion