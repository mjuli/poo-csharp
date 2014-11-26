using System;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] x = new int[10];
			int i, maior, menor;
			for (i = 0; i < 10; i++){
				Console.WriteLine("Digite o {0:00}º valor:", i+1);
				x[i] = int.Parse(Console.ReadLine());
			}
			maior = menor = x[0];
			foreach (int k in x){
				if (k > maior) maior = k;
				if (k < menor) menor = k;
			}
			Console.WriteLine("Maior= {0} \nMenor= {1}", maior, menor);
			Console.ReadKey();   
		}
	}
}