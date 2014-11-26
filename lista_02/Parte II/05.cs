using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string frase;
			int i, size, inicio;
			Console.WriteLine ("Digite uma frase: ");
			frase = Console.ReadLine ();
			string[] palavra = frase.Split (' ');
			size = palavra.Length - 1;
			inicio = 1;
			while (inicio <= size) {
				for (i = inicio; i <= size; i++){
					Console.Write("{0} ", palavra [i]);
					if (i == size){
						inicio += 1;
						Console.Write("\n");
					}
				}
			
			}
			Console.ReadKey ();
		}
	}
}
