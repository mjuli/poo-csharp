using System;

namespace Application
{
	class MainClass
	{
		static string Iniciais(string nome){
			int i, size;
			string[] palavras = nome.Split (' ');
			size = palavras.Length;
			char[] iniciais = new char[size];
			for (i = 0; i < size; i++){
				iniciais[i] = palavras[i].ToCharArray()[0];
			}
			string inic = string.Join("", iniciais);
			return inic;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Nome Completo:");
			string nome = Console.ReadLine ();
			Console.WriteLine("Iniciais: {0}", Iniciais(nome));
			Console.ReadKey ();
		}
	}
}
