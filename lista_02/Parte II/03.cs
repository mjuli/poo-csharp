using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i;
			for (i = 1; i <= 10; i++) {
				if (i % 2 == 0)
					Console.WriteLine (i * (-1));
				else
					Console.WriteLine (i);
			}
			Console.ReadKey ();
		}
	}
}
