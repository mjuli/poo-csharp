using System;

namespace Application
{
	class MainClass
	{
		public static string Senha(string s){
			string[] palavras = s.Split (' ');
			int size = palavras.Length;
			string[] num = new string[size];
			for (int i = 0; i < size; i++) {
				num [i] = palavras[i].Length.ToString();
			}
			string password = string.Join("", num);
			return password;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite uma frase:");
			string frase = Console.ReadLine ();
			Console.WriteLine ("Senha: {0}", Senha (frase));
			Console.ReadKey ();
		}
	}
}
