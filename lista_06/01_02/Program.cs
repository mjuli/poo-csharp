using System;

namespace questao02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Cliente cli = new Cliente ("Mario", "2992992999", 1000);
			Cliente cli2 = new Cliente ("Mari2o", "2992992999", 3000);
			Cliente cli3 = new Cliente ("Maria", "242523456346", 5000);
			Console.WriteLine (cli.GetLimite());
			cli.SetSocio (cli2);
			Console.WriteLine (cli2.GetLimite());

			ListaClientes lista = new ListaClientes();
			lista.AdicionarCliente (cli);
			lista.AdicionarCliente (cli2);
			lista.AdicionarCliente (cli3);

			lista.ListarClientes ();
			Console.ReadKey ();
		}
	}
}
