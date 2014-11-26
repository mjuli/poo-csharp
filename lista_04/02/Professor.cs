using System;

namespace Application
{
	public class Professor:Pessoa
	{
		private string diretoria;

		public Professor(string nome, DateTime nascimento, string matricula, string diretoria): base(nome, nascimento, matricula){
			this.diretoria = diretoria;
		}
	}
}

