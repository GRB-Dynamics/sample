//v0.1 copyright ?????????????? 20150508F1337
using System;
using System.Windows.Forms;

/////////////////////////////////////////////
/// <summary>
/// Person Represents a Person
/// </summary>
class Person
	{
	private string mName;
	private decimal mSalary;
	
	/////////////////////////////////////
	public Person(string name,decimal salary=0)
		{
		mName=name;
		mSalary=salary;
		}
	
	///////////////////////////////////////
	public void SayHello()
		{
		string msg=string.Format("Hello From {0}",mName);
		MessageBox.Show(msg,"Greetings");
		}


	//////////////////////////////////////
	public void Print()
		{
		string msg = string.Format("{0} salary is {1:c}", mName,mSalary);
		MessageBox.Show(msg, "Information");
		}

	/////////////////////////////////////
	public void UpdateSalary()
		{
		Console.Write("Please Enter New Salary for {0} : ",mName);
		
		string newsalarystr=Console.ReadLine();

		decimal newsalary=decimal.Parse(newsalarystr);		// This will throw an exception, if not parsable
		if(newsalary<0)
			{
			throw new Exception("Salary cannot be negative");
			}

		mSalary = newsalary;
		}


	//////////////////////////////////////
	public decimal GetSalary()
		{
		return mSalary;
		}

	}

