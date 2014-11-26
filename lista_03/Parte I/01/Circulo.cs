using System;

namespace Application
{
	public class Circulo
	{
		private double raio;
		public Circulo(double raio){
			this.raio = raio;
		}
		public double Area(){
			return Math.PI * raio * raio;
		}
		public double Circunferencia(){
			return 2 * Math.PI * raio;
		}
	}
}

