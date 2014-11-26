using System;

namespace _02
{
	public class ListaClientes 
	{
		private Cliente inicio;
		private Cliente fim;

		public ListaClientes ()
		{
			inicio = null;
			fim = null;
		}

		public void AdicionarCliente(Cliente novoCliente){
			if (inicio == null) {
				inicio = novoCliente;
			} else {
				fim.SetProximo (novoCliente);
			}
			fim = novoCliente;
		}

		public void ListarClientes(){
			Cliente a = inicio;
			while(a != null) {
				Console.WriteLine ("{0} - {1} - {2} - {3}", a.GetNome (),
									a.GetCPF (),
									a.GetLimite (),
									a.GetSocio ());
									a.GetProximo();
				a = a.GetProximo ();
			}
		}

		public void RemoverDoInicio (){
			inicio = inicio.GetProximo();
		}
			
	}
}
