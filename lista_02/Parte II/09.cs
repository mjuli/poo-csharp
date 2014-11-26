using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase:");
			string frase = Console.ReadLine ();
			string[] palavras = frase.Split (' ');
			for (int i = 0; i < palavras.Length; i++) {
				Console.WriteLine (palavras[oi]);
			}

			Console.ReadKey ();
		}
	}
}
