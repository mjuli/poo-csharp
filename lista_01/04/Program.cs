using System;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			string ano, data;
			int a;
			Console.WriteLine("Digite sua data de nascimento:");
			data = Console.ReadLine();
			ano = data.Substring(6, 4);
			a = int.Parse(ano);
			Console.WriteLine("Em 31/12/2014, voce terá {0} anos", 2014 - a);
			Console.ReadKey();
		}
	}
}
