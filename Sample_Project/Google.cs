﻿
/////////////////////////////////////////////
public class Google
	{
	private string mName;

	//////////////////////////////////////////////
	public Google(string name)
		{
		mName=name;
		}

	//////////////////////////////////////////////
	public void SayHello()
		{
		System.Console.WriteLine("Hello from {0}",mName);
		}
	}
