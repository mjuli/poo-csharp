using System;

namespace Application
{
	class MainClass
	{
		static int Mdc (int num1, int num2){
			int mdc = 1;
			for (int i = 1; i <= num1; i++) {
				if ((num1 % i == 0) && (num2 % i == 0))
					mdc = i;
			}
			return mdc;
		}

		static int Mmc (int num1, int num2){
			int fim = num1 * num2;
			int mmc = 0;
			for (int i = num1; i <= fim; i++) {
				if ((i % num1 == 0) && (i % num2 == 0)) {
					mmc = i;
					break;
				}
			}
			return mmc;
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Primeiro número:");
			int n1 = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Segundo número:");
			int n2 = int.Parse (Console.ReadLine ());
			Console.WriteLine("MDC: {0}", Mdc(n1, n2));
			Console.WriteLine("MMC: {0}", Mmc(n1, n2));
			Console.ReadKey();
		}
	}
}
