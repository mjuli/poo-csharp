using System;

namespace Application
{
	class MainClass
	{
		public static int Maior (int[] x){
			int i, maior;
			maior = x [0];
			for(i = 0; i < 3; i++) {
				if (x [i] > maior)
					maior = x [i];
			}
			return maior;
		}
		public static int Menor (int[] x){
			int i, menor;
			menor = x [0];
			for (i = 0; i < 3; i++) {
				if (x [i] < menor)
					menor = x [i];
			}
			return menor;
		}
		public static void Main (string[] args)
		{
			int soma, i;
			int[] x = new int[3];
			for (i = 0; i < 3; i++) {
				Console.WriteLine ("Digite o {0}º valor:", i+1);
				x [i] = int.Parse (Console.ReadLine ());
			}
			soma = Maior (x) + Menor (x);
			Console.WriteLine ("A soma do maior com o menor número é: {0}", soma);
			Console.ReadKey ();
		}
	}
}
