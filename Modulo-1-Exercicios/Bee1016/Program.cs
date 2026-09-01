namespace Bee1016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int distancia, tempo;
            distancia = int.Parse(Console.ReadLine());
            tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");
        }
    }
}