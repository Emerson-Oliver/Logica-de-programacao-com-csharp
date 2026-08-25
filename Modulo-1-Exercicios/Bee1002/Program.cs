using System.Globalization;

namespace Bee1002;  

class Program 
{  
	static void Main(string[] args) 
	{  
			Console.Clear();

			double raio = double.Parse(Console.ReadLine()?? "0" ,CultureInfo.InvariantCulture);

			double n = 3.14159;

			double area = n * Math.Pow(raio, 2); 

			Console.WriteLine($"A={area.ToString("F4",CultureInfo.InvariantCulture)}");
	}
}