using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase:");
			char[] frase = Console.ReadLine ().ToCharArray ();
			for (int i = (frase.Length - 1); i >= 0; i--){
				Console.Write (frase [i]);
			}
			Console.ReadKey ();
		}
	}
}
