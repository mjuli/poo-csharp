using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase:");
			char[] frase = Console.ReadLine ().ToCharArray();
			int size = frase.Length;
			int j;
			for (int i = 1; i <= size; i++) {
				for (int k = i; k < size + i; k++) {
					if (k >= size)
						j = k - size;
					else
						j = k;
					Console.Write (frase[j]);
				}
				Console.Write ("\n");
			}
			Console.ReadKey ();
		}
	}
}
