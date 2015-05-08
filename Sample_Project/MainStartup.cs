/// I was looking for API tutorials online but I didn't see anything really educational...
/// If you know how to make an API in C# then let's do it Devi! 
/////////////////////////////////////////////
public class MainStartup
	{
	/////////////////////////////////////////

	static public int ReadSalary(string name)
		{
		System.Console.WriteLine("Please enter {0}'s salary. ", name);
		string input = System.Console.ReadLine();
		int number;
		System.Int32.TryParse(input, out number);
		return number;
		}
	
	////////////////////////////////////////
	static public void Main()
		{ 
		Google tariq=new Google("Tariq");
		Google steve=new Google("Steve");
		Google devi = new Google("Devi");

		//Ask user for inputs. 
		int tSalary = ReadSalary("Tariq");
		int sSalary = ReadSalary("Steve");
		int dSalary = ReadSalary("Devi");

		tariq.SayHello(tSalary);
		steve.SayHello(sSalary);
		devi.SayHello(dSalary);

		devi.SayTotal(tSalary, sSalary, dSalary); 
		// Kind of sucks you have to specify the object to use a function that's in this class. 
		// I tried to just use Google.SayTotal(tSalary, sSalary, dSalary); but that gives an error.

		}
	}

