using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int i =1; i<=30; i++) {
				if (i % 3 == 0) {
					Console.Write (i+" ");
					Console.Write (3 * i - 3+" ");
				} 
				else
					Console.Write (i+" ");
			}
			Console.ReadKey ();
		}
	}
}
