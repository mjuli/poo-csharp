using System;

namespace Application
{
	class MainClass
	{
		static int Soma(int inicio, int fim){
			int soma = 0;
			for (int i = inicio; i <= fim; i++) {
				soma += i;
			}
			return soma;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Início do intervalo:");
			int inicio = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Fim do intervalo:");
			int fim = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Soma: {0}", Soma (inicio, fim));
			Console.ReadKey ();
		}
	}
}
