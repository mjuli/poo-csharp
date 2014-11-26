using System;

namespace Application
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double r;
			Console.WriteLine ("Informe o raio do círculo");
			r = double.Parse (Console.ReadLine ());
			Circulo c = new Circulo (r);
			Console.WriteLine ("Área = {0:0.00}", c.Area ());
			Console.WriteLine ("Circunferência = {0:0.00}", c.Circunferencia ());
			Console.ReadKey ();
		}
	}
}
