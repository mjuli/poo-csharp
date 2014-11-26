using System;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{

			double raio, circ, area;
			Console.WriteLine("Digite o raio de um círculo:");
			raio = double.Parse(Console.ReadLine());
			circ = 2 * Math.PI * raio;
			area = Math.PI * raio *raio;
			Console.WriteLine("Circunferência = {0:0.00} \nÁrea: {1:0.00}", circ, area);
			Console.ReadKey();

		}
	}
}
