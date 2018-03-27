<Query Kind="Program" />

void Main()
{
	var employees = new HashSet<Employee>();
	var employee1 = new Employee(1001, "Bob");
	var employee1Copy = new Employee(1001, "Bob");

	"Adding employee1...".Dump();
	employees.Add(employee1);//.Dump("Add employee1 result");

	"Adding employee1Copy...".Dump();
	employees.Add(employee1Copy);//.Dump("Add employee1Copy result");

	employees.Dump("Dumping all employees");
}

// Define other methods and classes here
class Employee
{
	public int Id { get; private set; }
	public string Name { get; set; }
	
	public Employee(int id, string name)
	{
		Id = id;
		Name = name;
	}
	
	#region Hide 1	
//	public static bool operator==(Employee e1, Employee e2)
//	{
//		return e1.Id == e2.Id;	
//	}
//
//	public static bool operator !=(Employee e1, Employee e2)
//	{
//		return e1.Id != e2.Id;
//	}
	#endregion
	#region Hide 2
//	public override bool Equals(object obj)
//	{
//		"Employee Equals Method called".Dump();
//		if(!(obj is Employee employee)) return false;
//
//		return this == employee;
//	}
	
	#region Hide 3
//	public override int GetHashCode()
//	{
//		"Employee GetHashCode Method called".Dump();
//		return 1;
//	}
	#endregion
	#endregion
}