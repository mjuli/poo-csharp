using System;

namespace Application
{
	public class Carro
	{
		private string fabricante, modelo;
		private double preco;
		private int ano;

		public Carro (string f, string m, int a, double p){
			fabricante = f;
			modelo = m;
			ano = a;
			preco = p;
		}
		public void SetPreco(double p){
			preco = p;		
		}
		public string GetFabricante(){
			return fabricante;
		}
		public string GetModelo(){
			return modelo;
		}
		public double GetPreco(){
			return preco;
		}
		public int GetAno(){
			return ano;
		}
	}
}

