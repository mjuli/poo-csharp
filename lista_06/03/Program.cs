using System;

namespace _02
{
	class MainClass
	{
		public static void Main (string[] args){

			ListaClientes lista = new ListaClientes ();

			Cliente julia = new Cliente ("Julia", "1234", 1000);
			Cliente maria = new Cliente ("Maria", "2345", 1000);
			Cliente renato = new Cliente ("Renato", "3456", 1000);

			julia.SetSocio (maria);

			lista.AdicionarCliente (julia);
			lista.AdicionarCliente (maria);
			lista.AdicionarCliente (renato);

			lista.ListarClientes ();

			Console.ReadKey ();
		}
	}
}
