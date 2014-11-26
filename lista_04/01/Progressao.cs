using System;

namespace Application
{
	abstract class Progressao
	{
		private double primeiroElemento;
		private double razao;

		public void SetPrimeiroElemento(double x){
			primeiroElemento = x;
		}

		public void SetRazao(double x){
			razao = x;
		}

		public double GetPrimeiroElemento(){
			return primeiroElemento;
		}

		public double GetRazao(){
			return razao;
		}

		public abstract double[] GetElementos (int n);
		public abstract double GetElemento (int n);
		public abstract double GetSoma (int n);
	}
}

