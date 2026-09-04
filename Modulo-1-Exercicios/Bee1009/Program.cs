using System.Globalization;

namespace Bee1009;  

class Program
{ 
	static void Main(string[] args)
	{ 
		Console.Clear();
		string nomeDoVendedor = Console.ReadLine() ?? "0";
		double salarioFixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
		double totalDeVendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

		double salarioLiquido = ((salarioFixo) + (totalDeVendas * 0.15));

		Console.WriteLine($"TOTAL R$ = {salarioLiquido.ToString("F2",CultureInfo.InvariantCulture)}");
	}	
}