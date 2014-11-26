using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Racional x = new Racional (1, 2);
			Racional y = new Racional (2, 3);
			Console.WriteLine (x);
			Console.WriteLine (y);
			Racional z = x.Multiplicar (y);
			Racional w = Racional.Multiplicar (x, z);
			Racional t = x * w;
			Console.WriteLine (z);
			Console.WriteLine (w);
			Console.WriteLine (t);
			Console.ReadKey ();
		}
	}
}
