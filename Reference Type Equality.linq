<Query Kind="Program" />

void Main()
{
	var person1 = new Person() { Name = "Bob" };
	var person2 = new Person() { Name = "Bob" };

	(person1 == person2).Dump("Comparing references");
}

// Define other methods and classes here
class Person
{
	public string Name { get; set; }

	#region Hide
//	public static bool operator==(Person p1, Person p2)
//	{
//		"Running == check".Dump();
//		return p1.Name == p2.Name;
//	}
//	
//	public static bool operator!=(Person p1, Person p2)
//	{
//		return p1.Name != p2.Name;
//	}
	#endregion
}