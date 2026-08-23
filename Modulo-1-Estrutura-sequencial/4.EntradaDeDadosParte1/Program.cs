namespace EntradaDeDados;

class Program
{ 
	static void Main(string[] args)
	{ 
		Console.Clear();

		string frase = Console.ReadLine();
		string cor1 = Console.ReadLine();
		string cor2 = Console.ReadLine();
		string cor3 = Console.ReadLine();
		Console.WriteLine();
		Console.WriteLine("Voce digitou: ");
		Console.WriteLine(frase);
		Console.WriteLine(cor1);
		Console.WriteLine(cor2);
		Console.WriteLine(cor3);
		Console.WriteLine("----------");

		string[] frutas = Console.ReadLine().Split(' ');
		string fruta1 = (frutas[0]);
		string fruta2 = (frutas[1]);
		string fruta3 = (frutas[2]);

		Console.WriteLine();

		Console.WriteLine("Voce digitou: ");		
		Console.WriteLine(fruta1);
		Console.WriteLine(fruta2);
		Console.WriteLine(fruta3);
		Console.WriteLine("----------");
	}
}