namespace Bee1001;  

class Program 
{  
	static void Main(string[] args) 
	{  
		int A = int.Parse(Console.ReadLine()?? "0");
		int B = int.Parse(Console.ReadLine()?? "0");

		int X = A + B;

		Console.WriteLine("X = " + X);
	}
}