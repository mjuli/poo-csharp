using System;

namespace Application
{
	class MainClass
	{
		static void Idade(string data, out int anos, out int meses) {
			String[] partes = data.Split ('/');
			DateTime dataAtual = DateTime.Today;
			anos = dataAtual.Year - int.Parse (partes [2]);
			if (int.Parse (partes [1]) > dataAtual.Month) {
				anos--;
			} 
			else if (int.Parse (partes [1]) == dataAtual.Month) {
				if (int.Parse (partes [0]) > dataAtual.Day) {
					anos--;
				}
			}
			if (int.Parse (partes [1]) > dataAtual.Month) {
				meses = int.Parse (partes [1]) - dataAtual.Month;
				meses = 12 - meses;
			}
			else if (int.Parse (partes [1]) == dataAtual.Month) {
				if (dataAtual.Day >= int.Parse (partes [0])) {
					meses = 0;
				} else {
					meses = 11;
				}
			}
			else {
				meses = dataAtual.Month - int.Parse (partes [1]);
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite sua data de nascimento no formato dd/mm/aaaa:");
			String data = Console.ReadLine ();
			int anos;
			int meses;
			Idade (data, out anos, out meses);
			Console.WriteLine ("Sua idade é de " + anos + " anos e " + meses + " meses.");
		}
	}
}
