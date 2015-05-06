
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
		string greetings=string.Format("Hello from {0}",mName);
		System.Windows.Forms.MessageBox.Show(greetings);
		}
	}

