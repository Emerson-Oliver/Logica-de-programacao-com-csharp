using System.Globalization;

namespace Exercicio;

class Program 
{ 
	static void Main(string[] args)
	{ 
		Console.Clear();

		Console.Write("Entre com seu nome completo: ");
		string nomeCompleto = Console.ReadLine();
		Console.Write("Quantos quartos tem na sua casa? ");
		int quartos = int.Parse(Console.ReadLine());
		Console.Write("Entre com o preço de um produto qualquer: ");
		double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
		Console.Write("Entre com seu ultimo nome, sua idade e sua altura escreva na mesma lina com um espaço: ");

		string[] dados = Console.ReadLine().Split(' ');
		string ultimoNome = dados[0];
		int idade = int.Parse(dados[1]);
		float altura = float.Parse(dados[2]);

		Console.WriteLine(nomeCompleto);
		Console.WriteLine(quartos);
		Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
		Console.WriteLine(ultimoNome);
		Console.WriteLine(idade);
		Console.WriteLine(altura);
	}
}
