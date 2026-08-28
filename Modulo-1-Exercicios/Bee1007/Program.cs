namespace Bee1007;  

class Program
{ 
	
	
		static void Main(string[] args) 
		{ 
			Console.Clear();
			int A = int.Parse(Console.ReadLine()?? "0");
			int B = int.Parse(Console.ReadLine()?? "0");
			int C = int.Parse(Console.ReadLine()?? "0");
			int D = int.Parse(Console.ReadLine()?? "0");

			int DIFERENCA = (A * B - C * D);

			Console.WriteLine($"DIFERENCA = {DIFERENCA}");
		}
	
}