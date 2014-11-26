using System;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{

			string valor;
			Console.WriteLine("Digite um valor monetário:");
			valor = Console.ReadLine();
			string[] n = valor.Split(',');           
			Console.WriteLine("{0} reais e {1} centavos", n[0], n[1]);
			Console.ReadKey();
		}
	}
} 