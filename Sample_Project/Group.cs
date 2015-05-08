//v0.1 copyright ???????? 20150508F1354
using System;
using System.Collections.Generic;

/// <summary>
/// A collection of Persons
/// </summary>
class Group
	{
	string mName = "";
	List<Person> mGroupMembers=new List<Person>();
	
	/////////////////////////////////////////////////
	public Group(string name)
		{
		mName = name;
		}


	/////////////////////////////////////////////////
	public void Add(Person person)
		{
		mGroupMembers.Add(person);
		}


	/////////////////////////////////////////////////
	public void Print()
		{
		if (mGroupMembers.Count == 0)
			{
			Console.WriteLine("The group {0} has no persons", mName);
			return;
			}

		Console.WriteLine("The group  {0} contains {1} persons. ", mName, mGroupMembers.Count);

		foreach (Person p in mGroupMembers)
			{
			p.Print();
			}
		}

	/////////////////////////////////////////////////
	public void SayHello()
		{
		foreach (Person p in mGroupMembers)
			{
			p.SayHello();
			}
		}



	/////////////////////////////////////////////////
	public decimal GetTotalSalary()
		{
		decimal sum=0.0M;
		foreach(Person p in mGroupMembers)
			{
			sum = sum + p.GetSalary();
			}

		return sum;
		}

	}

