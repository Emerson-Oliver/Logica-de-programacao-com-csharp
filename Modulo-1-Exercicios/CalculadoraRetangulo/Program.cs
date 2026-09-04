using System.Globalization;

namespace CalculadoraRetangulo;  

class Program
{  
	static void Main(string[] args)
	{ 
		Console.Clear();
		double bhase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
		double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

		double area = bhase * altura;
		double perimetro = 2 * (bhase + altura);
		double diagonal = Math.Sqrt(Math.Pow(bhase, 2) + Math.Pow(altura, 2));

		Console.WriteLine($"Area = {area.ToString("F2",CultureInfo.InvariantCulture)}");
		Console.WriteLine($"Perimetro = {perimetro.ToString("F4",CultureInfo.InvariantCulture)}");
		Console.WriteLine($"Diagonal = {diagonal.ToString("F4",CultureInfo.InvariantCulture)}");
	}
}