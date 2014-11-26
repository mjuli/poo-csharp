using System;

namespace Application
{
	class MainClass
	{
		static string UltimoDia (int mes, int ano){
			int dia = 0;
			int[] d30 = {4, 6, 9, 11};
			int[] d31 = {1, 3, 5, 7, 8, 10, 12};
			if (mes == 2){
				if(ano%4 == 0){
					if(ano%100==0){
						if(ano%400==0){
							dia = 29;
						}
						else
							dia = 28;
					}
					else
						dia = 29;
				}
				else
					dia = 28;
			}
			else{
				for (int i= 0; i<7; i++){
					if (mes == d30[i])
						dia = 30;
					else if(mes == d31[i])
						dia = 31;
				}
			}
			string d = dia.ToString();
			string month = mes.ToString();
			string a = ano.ToString();
			if (mes < 10){
				string zero = "0";
				string m = zero + month;
				string[] ult_dia = {d, m, a};
				string data = string.Join("/", ult_dia);
				return data;
			}
			else{
				string[] ult_d = {d, month, a};
				string dat = string.Join("/", ult_d);
				return dat;
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Digite o mês:");
			int mes = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Digite o ano:");
			int ano = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Data do último dia: {0}", UltimoDia(mes, ano));
			Console.ReadKey ();
		}
	}
}
//31 = 1, 3, 5, 7, 8, 10, 12
//30 = 4, 6, 9, 11