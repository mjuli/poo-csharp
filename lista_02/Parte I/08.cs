using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string conta;
			int num1, num2;
			float total;
			Console.WriteLine ("Digite dois valores inteiros separados por um operador +, -, * ou /");
			conta = Console.ReadLine();
			if (conta.Contains ("+")) {
				string[] operacao = conta.Split('+');
				num1 = int.Parse(operacao[0]);
				num2 = int.Parse(operacao[1]);
				total = num1 + num2;
			}
			else if (conta.Contains ("-")) {
				string[] operacao = conta.Split('-');
				num1 = int.Parse(operacao[0]);
				num2 = int.Parse(operacao[1]);
				total = num1 - num2;
			} 
			else if (conta.Contains ("*")) {
				string[] operacao = conta.Split('*');
				num1 = int.Parse(operacao[0]);
				num2 = int.Parse(operacao[1]);
				total = num1 * num2;
			} 
			else if (conta.Contains ("/")) {
				string[] operacao = conta.Split('/');
				num1 = int.Parse(operacao[0]);
				num2 = int.Parse(operacao[1]);
				total = num1 / num2;
			} 
			else {
				Console.WriteLine ("Expressão incorreta.");
				return;
			}
			Console.WriteLine ("O resultado da operação é {0}", total);
			Console.ReadKey();
		}
	}
}
