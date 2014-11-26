using System;

namespace Application
{
	public class Racional
	{
		private int num;
		private int den;

		public Racional (int num, int den){
			this.num = num;
			this.den = den;
		}

		public override string ToString (){
			return string.Format ("{0}/{1}", num, den);
		}

		public Racional Multiplicar(Racional z){
			Racional result = new Racional (num * z.num, den * z.den);
			return result;
			// ou => return new Racional(num*z.num, den*z.den)
		}

		public static Racional Multiplicar(Racional a, Racional b){
			Racional result = new Racional (a.num * b.num, a.den * b.den);
			return result;
		}

		public static Racional operator *(Racional a, Racional b){
			Racional result = new Racional (a.num * b.num, a.den * b.den);
			return result;
		}



	}
}

