using System;

namespace Application
{
	public class Fibonacci:IFibonacci
	{
		private int a1 = 0;
		private int a2 = 1;
		private int next;
		private int position = 0;
		public Fibonacci ()
		{
			next = this.a1 + this.a2;
		}
		public void Iniciar(){
			a1 = 0;
			a2 = 1;
			next = 0;
		}
		public int Proximo(){
			int returno;
			if (position == 0)
				returno = a1;
			else if (position == 1)
				returno = a2;
			else
				returno = next;
			next = a1 + a2;
			a1 = a2;
			a2 = next;
			return returno;
		}
	}
}

