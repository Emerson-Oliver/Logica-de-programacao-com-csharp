namespace Bee1003;  

class Program
{ 
	static void Main(string[] args) 
	{  
		Console.Clear();
		int A = int.Parse(Console.ReadLine()?? "0");
		int B = int.Parse(Console.ReadLine()?? "0");

		int SOMA = A + B;

		Console.WriteLine($"SOMA = {SOMA}");
	}
}