using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int soma = 0;
			Console.WriteLine ("Digite uma sequência de números separados por vírgula:");
			string num = Console.ReadLine ();
			string[] numeros = num.Split (',');
			for(int i = 0; i < numeros.Length; i++){
				int x = int.Parse(numeros[i]); 
				soma += x;
			}
			Console.WriteLine (soma);
			Console.ReadKey ();
		}
	}
}
