using System.Globalization;

namespace Bee1010;  

class Program
{
	static void Main(string[] args)
	{ 
		Console.Clear();
		string[] dados = Console.ReadLine().Split(' ');
		int codigoPeca1 = int.Parse(dados[0]);
		int quantidadePeca1 = int.Parse(dados[1]);
		double valorPeca1 = double.Parse(dados[2], CultureInfo.InvariantCulture);

		dados = Console.ReadLine().Split(' ');		
		int codigoPeca2 = int.Parse(dados[0]);
		int quantidadePeca2 = int.Parse(dados[1]);
		double valorPeca2 = double.Parse(dados[2], CultureInfo.InvariantCulture);

		double valorAPagar = ((quantidadePeca1 * valorPeca1) + (quantidadePeca2 * valorPeca2));

		Console.WriteLine($"Valor a pagar: R$ {valorAPagar.ToString("F2", CultureInfo.InvariantCulture)}");
	}
}