using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			IPessoa[] lista = new IPessoa[5];
			lista [0] = new Aluno ("Aluno1", DateTime.Parse ("01/01/1990"), "12345", "TADS");
			lista [1] = new Aluno ("Aluno2", DateTime.Parse ("01/02/1990"), "12346", "TADS");
			lista [2] = new Aluno ("Aluno3", DateTime.Parse ("01/03/1990"), "12347", "TADS");
			lista [3] = new Professor ("Prof1", DateTime.Parse ("01/01/1989"), "12348", "DIATINF");
			lista [4] = new Professor ("Prof2", DateTime.Parse ("01/01/1988"), "12349", "DIATINF");
			foreach (IPessoa p in lista) {
				if (p.GetNascimento ().Month == 1) {
					Console.WriteLine ("{0} - {1}", p.GetNome (), p.GetNascimento ().ToShortDateString ());
					Console.WriteLine ("{0} - {1}", p.GetNome (), p.GetNascimento ().ToString ("dd/MM"));
				}
			}
			Console.ReadKey ();
		}
	}
}
