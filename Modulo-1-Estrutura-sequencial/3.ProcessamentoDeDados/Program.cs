using System.Globalization;

namespace ProcessamantoDeDados; 

class Program
{ 
	static void Main(string[] args) 
	{ 
		Console.Clear();

		int x = 5;
		int y = 2 * x;

		Console.WriteLine(x);
		Console.WriteLine(y);
		Console.WriteLine("---");

		int v1 = 5;
		double v2 = 2 * v1;

		Console.WriteLine(v1);
		Console.WriteLine(v2);
		Console.WriteLine("---");

		float b, B, h, area;

		b = 6f;
		B = 8f;
		h = 5f;

		area = (b + B) / 2f * h;

		Console.WriteLine($"Area: {area.ToString("F1")}");
		Console.WriteLine($"Area: {area.ToString("F1",CultureInfo.InvariantCulture)}");
		Console.WriteLine("---");

		int n1 = 5, n2 = 2;
		double resultado = (double) n1 / n2;

		Console.WriteLine(resultado);
		Console.WriteLine("---");
	}
}