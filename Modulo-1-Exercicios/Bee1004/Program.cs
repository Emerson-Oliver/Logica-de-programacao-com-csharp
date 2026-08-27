namespace Bee1004;

class Program  
{  
	static void Main(string[] args) 
	{ 
		Console.Clear();
		int A = int.Parse(Console.ReadLine()?? "0");
		int B = int.Parse(Console.ReadLine()?? "0");

		int PROD = A * B;

		Console.WriteLine($"PROD = {PROD}");
	}
}
