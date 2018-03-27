<Query Kind="Program">
  <Namespace>System.Runtime.Serialization.Formatters.Binary</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	var allHeroes = new HashSet<Hero>(HeroFactory.GetAllHeroes());

	// Get a reference to the first element (batman)
	var batman = allHeroes.ElementAt(0);
	
	allHeroes.Dump("All heroes");

//	allHeroes.Contains(batman).Dump("First contains key check");
//	batman.FirstName = "Dick";
//	batman.LastName = "Grayson";
	
//	allHeroes.Contains(batman).Dump("Second contains key check");
}

static class HeroFactory
{
	private static List<(string first, string last, string heroName)> Heroes { get; set; }
		= new List<(string first, string last, string heroName)>
		{		
			("Bruce","Wayne","Batman"),
			("Clark","Kent","Superman"),
			("Diana","Prince","Wonder Woman"),
			("Tony","Stark","Iron Man"),
			("Bruce","Banner","Hulk"),
			("Steve","Rogers","Captain America")
		};

	public static IEnumerable<Hero> GetAllHeroes()
	{
		foreach (var hero in Heroes)
		{
			yield return new Hero(hero.first, hero.last, hero.heroName);
		}
	}
}

class Hero
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string HeroName { get; private set; }

	public Hero(string first, string last, string heroName)
	{
		FirstName = first;
		LastName = last;
		HeroName = heroName;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Hero personToCompare)) return false;

		$"Running Equals() - {HeroName} / {personToCompare.HeroName}".Dump();
		Task.Delay(100).Wait();
		return FirstName.Equals(personToCompare.FirstName, StringComparison.InvariantCultureIgnoreCase) &&
			LastName.Equals(personToCompare.LastName, StringComparison.InvariantCultureIgnoreCase) &&
			HeroName.Equals(personToCompare.HeroName, StringComparison.InvariantCultureIgnoreCase);
	}

	public override int GetHashCode()
	{
		$"Running GetHashCode() - {FirstName[0]} ({FirstName.Substring(1)})".Dump();
		return FirstName[0];
	}
}