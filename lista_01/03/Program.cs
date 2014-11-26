using System;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			float[] x = new float[3];
			int i;
			float resultado;
			for (i = 0; i < 3; i++){
				Console.WriteLine("Digite a {0}ª nota:", i+1);
				x[i] = float.Parse(Console.ReadLine());
			}
			resultado = 20 - (((x[0] * 2) + (x[1] * 2) + (x[2] * 3)) / 3);
			Console.WriteLine("Nota para passar: {0}", resultado);
			Console.ReadKey();   
		}
	}
}