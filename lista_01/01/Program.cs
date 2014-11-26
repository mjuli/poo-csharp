using System;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome;
			Console.WriteLine("Digite seu nome:");
			nome = Console.ReadLine();
			Console.WriteLine("Bem vindo ao C#, {0}", nome);
			Console.ReadKey();

		}
	}
}