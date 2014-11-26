using System;

namespace ConsoleApplication1
{
	class Program
	{
		public static void Maiores(int[] x, float media)
		{
			int i;
			for (i = 0; i < 4; i++){
				if (x[i] > media)
					Console.WriteLine(x[i]);
			}      
		}
		public static void Menores(int[] x, float media)
		{
			int i;
			for (i = 0; i < 4; i++)
			{
				if (x[i] < media)
					Console.WriteLine(x[i]);
			}
		}
		static void Main(string[] args)
		{
			int[] x = new int[4];
			int i, soma;
			float media; 
			soma=0;
			for (i = 0; i < 4; i++){
				Console.WriteLine("Digite o {0}º valor:", i+1);
				x[i] = int.Parse(Console.ReadLine());
				soma += x[i];
			}
			media = soma / 4;
			Console.WriteLine("Média: {0}", media); 
			Console.WriteLine("Números maiores que a média:");
			Maiores(x, media);
			Console.WriteLine("Números menores que a média:");
			Menores(x, media);
			Console.ReadKey();   
		}
	}
}