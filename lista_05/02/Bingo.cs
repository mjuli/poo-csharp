using System;
using System.Linq;

namespace Application
{
	public class Bingo:IBingo
	{
		private int n, k;
		private int[] num;

		public void Iniciar(int n){
			this.n = n;
			num = new int[n];
			k = 0;
		}

		public int Proximo(){
			if (k == n)
				return -1;
			int x;
			Random r = new Random ();
			do {
				x = r.Next (n+1); //Número sorteado
			}
			while (num.Contains(x));
			num [k] = x;
			k++;
			return x;

		}

		public int[] Sorteados(){
			int[] ret = new int[k];
			Array.Copy (num, ret, k);
			return ret;
		}
	}
}

