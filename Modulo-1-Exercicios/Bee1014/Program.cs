using System.Globalization;

namespace Bee1014;  

class Program
{ 
	static void Main(string[] args)
	{ 
		Console.Clear();
		int distancia = int.Parse(Console.ReadLine());
		double totalCombustivelGasto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

		double consumoMedio = (double) distancia / totalCombustivelGasto;

		Console.WriteLine($"{consumoMedio.ToString("F3",CultureInfo.InvariantCulture)} km/l");
	}
}