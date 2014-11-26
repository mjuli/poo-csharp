using System;

namespace Application
{
	public class Loja
	{
		public Loja ()
		{
		}
		private string nome, endereco;
		private Carro[] estoque = new Carro[30];
		private int qtd = 0 ;

		public void SetNome(string nome){
			this.nome = nome;
		}

		public void SetEndereco(string endereco){
			this.endereco = endereco;
		}

		public string GetNome(){
			return nome;
		}

		public string GetEndereco(){
			return endereco;
		}

		public void AdicionarCarro(){
			Console.WriteLine ("Modelo:");
			string modelo = Console.ReadLine ();
			Console.WriteLine ("Fabricante:");
			string fabricante = Console.ReadLine ();
			Console.WriteLine ("Ano:");
			int ano = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Preço:");
			double preco = double.Parse(Console.ReadLine ());
			Carro c = new Carro (fabricante, modelo, ano, preco);
			if (qtd < 30) {
				estoque [qtd] = c;
				qtd++;
			} 
			else
				Console.WriteLine ("Capacidade Esgotada");
		}

		public void ListarCarros(){
			for (int i = 0; i < qtd; i++) {
				Console.Write ("{0} - {1} - {2} - {3:0.00}\n", estoque[i].GetModelo (), estoque [i].GetFabricante (), estoque [i].GetAno (), estoque [i].GetPreco ());
			}
		}

		public double TotalFinanceiro(){
			double total = 0;
			for (int i = 0; i < qtd; i++) {
				total = total + estoque [i].GetPreco ();
			}
			return total;
		}

		public void ListarCarrosPorFabricante(string fabricante){
			for (int i = 0; i < qtd; i++) {
				if (estoque [i].GetFabricante() == fabricante) {
					Console.Write ("{0} - {1} - {2:0.00}\n", estoque [i].GetModelo (), estoque [i].GetAno (), estoque [i].GetPreco ());
				}
			}
		}

		public void ListarCarrosPorModelo(string modelo){
			for (int i = 0; i < qtd; i++) {
				if (estoque [i].GetModelo() == modelo) {
					Console.Write ("{0} - {1} - {2:0.00}\n", estoque [i].GetFabricante (), estoque [i].GetAno (), estoque [i].GetPreco ());
				}
			}
		}
		public void ListarCarrosPorPreco(double a, double b){
			double maior, menor;
			if (a > b) {
				maior = a;
				menor = b;
			}
			else{
				maior = b;
				menor = a;
			}
			for (int i = 0; i < qtd; i++) {
				if (estoque [i].GetPreco()>= menor && estoque[i].GetPreco()<= maior) {
					Console.Write ("{0} - {1} - {2}\n", estoque [i].GetFabricante (), estoque [i].GetModelo (), estoque [i].GetAno ());
				}
			}
		}


	}
}

