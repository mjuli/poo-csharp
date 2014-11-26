using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i;
			int[] sequencia = new int[10];
			sequencia [0] = 1;
			for (i = 1; i < 10; i++) {
				sequencia [i] = sequencia [i - 1] + i;
			}
			foreach (int k in sequencia){
				Console.WriteLine (k);
			}
			Console.ReadKey ();
		}
	}
}
