using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Progressao pa = new PA ();
			pa.SetPrimeiroElemento (2);
			pa.SetRazao (2);
			double[] x = pa.GetElementos (10);
			foreach (double elem in x)
				Console.WriteLine (elem);
			Console.WriteLine (pa.GetSoma (10));
			PG pg = new PG ();
			pg.SetPrimeiroElemento (2);
			pg.SetRazao (2);
			double[] y = pg.GetElementos (10);
			foreach (double elem in y)
				Console.WriteLine (elem);
			Console.WriteLine (pg.GetSoma (10));
			Console.ReadKey ();
		}
	}
}
