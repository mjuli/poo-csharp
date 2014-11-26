using System;

namespace Application
{
	class PG:Progressao 
	{
		public override double[] GetElementos (int n){
			double[] x = new double[n];
			for (int i = 1; i < n; i++) 
				x [i] = GetPrimeiroElemento () * Math.Pow(GetRazao(), i);
			return x;
		}

		public override double GetElemento (int n){
			return GetPrimeiroElemento () * Math.Pow(GetRazao(), (n - 1));
		}

		public override double GetSoma (int n){
			double[] x = GetElementos (n);
			double soma = 0;
			foreach (double elem in x)
				soma += elem;
			return soma;
		}
	}
}

