using System.Globalization;

namespace CalculadoraAreaTerreno;

class Program
{
	static void Main(String[] args)
	{ 
		Console.Clear();
		double largura = double.Parse(Console.ReadLine() ?? "0" ,CultureInfo.InvariantCulture);
		double comprimento = double.Parse(Console.ReadLine()?? "0" ,CultureInfo.InvariantCulture);
		double preco = double.Parse(Console.ReadLine()?? "0" ,CultureInfo.InvariantCulture);

		double area = largura * comprimento;
		double precoFinal = area * preco;

		Console.WriteLine($"AREA = {area.ToString("F2",CultureInfo.InvariantCulture)}");
		Console.WriteLine($"PRECO = R$ {precoFinal.ToString("F2",CultureInfo.InvariantCulture)}");
	} 
}
