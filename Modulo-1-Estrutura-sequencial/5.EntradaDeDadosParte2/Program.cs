using System.Globalization;

namespace EntradaDeDados;

class Program
{ 
	static void Main(string[] args) 
	{
		Console.Clear();

		int idade = int.Parse(Console.ReadLine());
		char sexo = char.Parse(Console.ReadLine());
		double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
		Console.WriteLine();

		Console.WriteLine("Voce digitou");
		Console.WriteLine(idade);
		Console.WriteLine(sexo);
		Console.WriteLine(altura);
		Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
		Console.WriteLine("------------------");

		String[] dadosCadastrais = Console.ReadLine().Split(' ');
		string nome = dadosCadastrais[0];
		char genero = char.Parse(dadosCadastrais[1]);
		int idade2 = int.Parse(dadosCadastrais[2]);
		double altura2 = double.Parse(dadosCadastrais[3], CultureInfo.InvariantCulture);
		Console.WriteLine();

		Console.WriteLine("Voce digitou");
		Console.WriteLine(nome);
		Console.WriteLine(genero);
		Console.WriteLine(idade2);
		Console.WriteLine(altura2.ToString("F2",CultureInfo.InvariantCulture));
		Console.WriteLine("------------------");
	}
}