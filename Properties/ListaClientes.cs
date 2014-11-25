using System;

namespace _02
{
	public class ListaClientes 
	{
		private int qtd;
		private Cliente inicio;
		private Cliente fim;

		public ListaClientes ()
		{
		}

		public void AdicionarCliente(Cliente novoCliente){
			if (inicio == null) {
				inicio = novoCliente;
			} else {
				fim.SetProximo (novoCliente);
				novoCliente.SetAnterior (fim);
			}
			fim = novoCliente;
			qtd++;
		}

		public void ListarClientes(){
			Cliente a = inicio;
			for (int i = 0; i < qtd; i++) {
				Console.WriteLine ("{0} - {1} - {2} - {3}", a.GetNome (),
					a.GetCPF (),
					a.GetLimite (),
					a.GetSocio ());
				a = a.GetProximo();
			}
		}

		public void RemoverDoInicio (){
			inicio = inicio.GetProximo();
			qtd--;
		}

		public void RemoverDoFinal (){
			fim = fim.GetAnterior();
			qtd--;
		}
	}
}