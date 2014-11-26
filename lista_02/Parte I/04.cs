using System;

namespace Application
{
	class MainClass
	{
		public static int Minuto(int m){
			int posicao_m = m*6;
			return posicao_m;
		}

		public static double Hora(int h, int m){
			double posicao_h = 1;
			if (h <= 12)
				posicao_h = (h * 30) + (m / 2);
			if (h > 12)
				posicao_h = ((h - 12) * 30) + (m / 2);
			return posicao_h;
		}

		public static double Angulo(double h, int m){
			double angulo;
			if (h > m)
				angulo = h - m;
			else
				angulo = m - h;
			if (angulo > 180)
				angulo = 360 - angulo;
			return angulo;
		}

		public static void Main (string[] args)
		{
			string saida;
			int h, m, posicao_m;
			double angulo, posicao_h;
			h = m = -1;
			while (h<0 || h>23 || m<0 || m>59){
				Console.WriteLine ("Digite o horário no formato hh:mm");
				saida = Console.ReadLine ();
				string[] hora = saida.Split (':');
				h = int.Parse (hora [0]);
				m = int.Parse (hora [1]);
				if (h<0 || h>23 || m<0 || m>59)
					Console.WriteLine("Hora Inválida");
			}
			posicao_h = Hora (h, m);
			posicao_m = Minuto (m);
			angulo = Angulo (posicao_h, posicao_m);
			Console.WriteLine ("Menor ângulo formado entre os ponteiros: {0:0.0}", angulo);
			Console.ReadKey ();
		}
	}
}
