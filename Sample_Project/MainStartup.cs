public class MainStartup
	{
	////////////////////////////////////////
	static public void Main()
		{ 
		Person tariq=new Person("Tariq",12345M);
		Person steve=new Person("Steve",12345M);
		Person devi=new Person("Devi");

		Group grp=new Group("GRB-Dynamics");
		grp.Add(tariq);
		grp.Add(steve);
		grp.Add(devi);

		grp.Print();
		
		tariq.UpdateSalary();
		
		grp.Print();
		grp.SayHello();		
		}
	}

