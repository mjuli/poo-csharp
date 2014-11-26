using System;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			int soma_h, soma_m, extra, h1, h2, m1, m2;
			string total1, total2;

			Console.WriteLine("Digite o primeiro horário no formato hh:mm :");
			total1 = Console.ReadLine();
			Console.WriteLine("Digite o segundo horário no formato hh:mm :");
			total2 = Console.ReadLine();
			string[] hora1 = total1.Split(':');
			string[] hora2 = total2.Split(':');
			m1 = int.Parse(hora1[1]);
			m2 = int.Parse(hora2[1]);
			h1 = int.Parse(hora1[0]);
			h2 = int.Parse(hora2[0]);
			soma_m = m1 + m2;
			extra = 0;
			if (soma_m > 60)
			{
				extra = 1;
				soma_m = soma_m - 60;
			}
			soma_h = h1 + h2 + extra;
			Console.WriteLine("Total de horas = {0:00}:{1:00}", soma_h, soma_m);
			Console.ReadKey();   
		}
	}
}