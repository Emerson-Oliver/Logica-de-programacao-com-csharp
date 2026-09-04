using System.Globalization;

namespace CalculadoraIdadeMedia;  

class Program
{  
	static void Main(string[] args)
	{ 
		Console.Clear();
		string[] dadosCadastrais = Console.ReadLine().Split(' ');
		string nome1 = dadosCadastrais[0];
		int idade1 = int.Parse(dadosCadastrais[1]);		

		dadosCadastrais = Console.ReadLine().Split(' ');
		string nome2 = dadosCadastrais[0];
		int idade2 = int.Parse(dadosCadastrais[1]);

		double idadeMedia = (double) (idade1 + idade2) / 2.0;

		Console.WriteLine($"A media de idade de {nome1} e {nome2} é de {idadeMedia.ToString("F1",CultureInfo.InvariantCulture)} anos");
	}
}