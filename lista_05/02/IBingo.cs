using System;

namespace Application
{
	interface IBingo {
		void Iniciar(int n);
		int Proximo();
		int[] Sorteados();
	}
}

