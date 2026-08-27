using System.Globalization;
namespace Bee1005;

class Program  
{  
	static void Main(string[] args) 
	{ 
		Console.Clear();
		double A = double.Parse(Console.ReadLine()?? "0", CultureInfo.InvariantCulture);
		double B = double.Parse(Console.ReadLine()?? "0", CultureInfo.InvariantCulture);

		double MEDIA = (A * 3.5 + B * 7.5) / 11.0;

		Console.WriteLine($"MEDIA = {MEDIA.ToString("F5",CultureInfo.InvariantCulture)}");
	}
}
