using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int m;
			string date;
			string[]data = new string[3];
			string[] mes = new string[]{"janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};
			Console.WriteLine ("Digite uma data no formato dd/mm/aaaa :");
			date = Console.ReadLine ();
			data = date.Split ('/');
			m = int.Parse (data [1]);
			Console.WriteLine ("A data é {0} de {1} de {2}.", data[0], mes[m-1], data[2]);
			Console.ReadLine();
		}
	}
}
