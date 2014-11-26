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
			Console.WriteLine ("{0}", palavras.Length);
			Console.ReadKey ();
		}
	}
}
