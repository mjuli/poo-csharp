using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int r = Texto.ContarPalavras ("Minha terra tem palmeiras onde canta o sabiá");
			Console.WriteLine (r +" palavras");
			Console.ReadKey ();
		}
	}
}
