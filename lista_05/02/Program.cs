using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			IBingo b = new Bingo ();
			b.Iniciar (10);
			Console.WriteLine (b.Proximo());
			Console.WriteLine (b.Proximo());
			Console.WriteLine (b.Proximo());
			Console.WriteLine (b.Proximo());
			Console.WriteLine (b.Proximo());
			Console.WriteLine (b.Proximo());
			Console.WriteLine ("Sorteados:");
			foreach (int n in b.Sorteados())
				Console.Write (n + " "); 
			Console.ReadKey ();
		}
	}
}
