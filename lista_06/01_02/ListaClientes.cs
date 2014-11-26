using System;

namespace questao02
{
	public class ListaClientes 
	{
		private Cliente[] listaDeClientes;
		private int qtd;

		public ListaClientes ()
		{
			listaDeClientes = new Cliente[50];
		}
		public void AdicionarCliente(Cliente x){
			if (qtd < 50) {
				listaDeClientes [qtd] = x;
				qtd++;
			} else {
				Console.WriteLine ("Capacidade Esgotada");
			}
		}
		public void ListarClientes(){
			for (int i = 0; i < qtd; i++) {
				Console.WriteLine ("{0},{1},{2},{3}", 
					listaDeClientes [i].GetNome(),
					listaDeClientes [i].GetCPF(),
					listaDeClientes [i].GetLimite (),
					listaDeClientes [i].GetSocio());
			}
		}
	}
}

