using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i;
			int erro = 0;
			int[] x = new int[4];
			Console.WriteLine ("Digite 4 valores diferentes:");
			for (i=0; i<4; i++) {
				x[i] = int.Parse (Console.ReadLine ());
			}
			Array.Sort (x);
			for (i=0; i<3; i++) {
				if (x [i] == x [i + 1])
					erro = 1;
			}
			if (erro == 1)
				Console.WriteLine ("Erro");
			else
				Console.WriteLine ("Maior número: {0}\nMenor número: {1}\nA soma do segundo maior e do segundo menor: {2}", x [3], x [0], x [1] + x [2]); 
			Console.ReadKey ();
		}
	}
}
