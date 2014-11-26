using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase");
			string frase = Console.ReadLine ();
			for (int i = 0; i < frase.Length; i++) {
				Console.WriteLine ("{0} - {1}", i + 1, frase);
			}
			Console.ReadKey();
		}
	}
}
