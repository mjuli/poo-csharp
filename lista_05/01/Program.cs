using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Fibonacci f = new Fibonacci ();
			Console.WriteLine (f.Proximo());
			Console.WriteLine (f.Proximo());
			Console.WriteLine (f.Proximo());
			Console.WriteLine (f.Proximo());
			Console.WriteLine (f.Proximo());
			Console.WriteLine (f.Proximo());
			f.Iniciar();
			Console.WriteLine (f.Proximo());
			Console.ReadKey ();
		}
	}
}
