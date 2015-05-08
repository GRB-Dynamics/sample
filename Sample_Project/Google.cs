
/////////////////////////////////////////////
public class Google
	{
	private string mName;// I've seen this convention of adding m as a prefix for class variables in a C++ tutorial before.

	//////////////////////////////////////////////
	public Google(string name)
		{
		mName=name;
		}

	//////////////////////////////////////////////
	public void SayTotal(int tariqSalary, int steveSalary, int deviSalary)
		{
		int total = tariqSalary + steveSalary + deviSalary;
		string money = string.Format("Combined we make ${0} per year.", total);
		System.Windows.Forms.MessageBox.Show(money); 
		}

	//////////////////////////////////////////////
	public void SayHello(int salary)
		{
		string greetings=string.Format("Hello from {0}. I make ${1} per year.", mName, salary);
		System.Windows.Forms.MessageBox.Show(greetings); 
		}
	}

