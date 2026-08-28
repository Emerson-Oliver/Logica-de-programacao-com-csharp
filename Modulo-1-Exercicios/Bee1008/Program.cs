using System.Globalization;

namespace Bee1008;

class Program
{
	static void Main(string[] args)
	{ 
		Console.Clear();
		int numeroDoFuncionario = int.Parse(Console.ReadLine()?? "0");
		int numeroDeHorasTrabalhadas = int.Parse(Console.ReadLine()?? "0");
		decimal valorPorHora = decimal.Parse(Console.ReadLine()?? "0" ,CultureInfo.InvariantCulture);

		decimal salarioLiquido =  numeroDeHorasTrabalhadas * valorPorHora;

		Console.WriteLine($"Number = {numeroDoFuncionario}");
		Console.WriteLine($"SALARY U$ = {salarioLiquido.ToString("F2",CultureInfo.InvariantCulture)}");
	}
}
