// Starting out with a simple stylish "hello world.
/* Feel free to add on whatever and we'll see where this goes. */

// I'm bored waiting for Steven.
/* Let's make this 'hello world' a little bit more complex.
 Actually let's make this a lot more complex. 
 * "Let's have "Hello Tariq" be written in the main function.
 * Let's have "Hello Steven" happen in a prototyped function somewhere in this class.
 * Let's have "Hello Murali" happen in a function in a different class.
 * Let's have "Hello Microsoft" happen in a different namespace.
 * Let's have "Hello Google" happen in a different .cs file.
 
 */

namespace BubbleGum // Initiate namespace.
	{
	/////////////////////////////////////////////////////////////////////////////
	public class Git // Initiate class.
		{
		//static public void FunctionHello(); I guess it didn't need to be prototyped lol..........

		static public void Main() // Program starts by reading the Main function.
			{
			System.Console.WriteLine("Hi Tariq."); 
			FunctionHello(); // !!! I didn't need to prototype for any of these.
			Murali.ClassHello();
			Microsoft.MicrosoftHello.Hello();
			Phone.Music.Hi(); // I didn't even need to forward declare for this or anything. What was I learning in those C++ lessons...

			// You do not need this.  If you press F5(Debug Mode), execution does not stop.
			// Press Ctrl-F5 when you are executing with out debugging code.
			// System.Console.ReadKey();		// Reads a character from the user. Put this in 
												// because Visual Studio will close console immediately after program runs.
			}

		static public void FunctionHello()
			{
			System.Console.WriteLine("Hi Steven.");
			}
		}

	public class Murali
		{
		static public void ClassHello()
			{
			System.Console.WriteLine("Hi Murali.");
			}
		}
	}

namespace Microsoft
	{
	public class MicrosoftHello
		{
		static public void Hello()
			{
			System.Console.WriteLine("Hi Microsoft.");
			}
		}
	}