using System;

namespace Application
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Loja julia = new Loja ();
			int op = 10;

			while (op !=0) {
				Console.WriteLine ("Digite: \n0 para finalizar;\n" +
					"1 para adicionar carro;\n" +
					"2 para listar todos os carros;\n" +
					"3 para listar por modelo;\n" +
					"4 para listar por fabricante;\n" +
					"5 para listar por faixa de preço;\n" +
					"6 para mostrar o valor total do estoque.");
				op = int.Parse (Console.ReadLine ());
				if (op == 0)
					Console.WriteLine ("Operação finalizada!");
				else if (op == 1)
					julia.AdicionarCarro();
				else if (op == 2)
					julia.ListarCarros();
				else if (op == 3){
					Console.WriteLine ("Digite o modelo:");
					string m = Console.ReadLine();
					julia.ListarCarrosPorModelo(m);
				}
				else if (op == 4){
					Console.WriteLine ("Digite o fabricante:");
					string f = Console.ReadLine();
					julia.ListarCarrosPorFabricante(f);
				}
				else if (op == 5){
					Console.WriteLine ("Digite o menor valor:");
					double a = double.Parse(Console.ReadLine());
					Console.WriteLine ("Digite o maior valor:");
					double b = double.Parse(Console.ReadLine());
					julia.ListarCarrosPorPreco(a, b);
				}
				else if (op == 6)
					Console.WriteLine("{0:0.00}", julia.TotalFinanceiro());
				else
					Console.WriteLine("Operação inválida!");
			}

			Console.ReadKey ();
		}
	}
}
