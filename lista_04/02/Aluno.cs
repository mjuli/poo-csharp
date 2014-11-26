using System;

namespace Application
{
	public class Aluno:Pessoa
	{
		private string curso;

		public Aluno(string nome, DateTime nascimento, string matricula, string curso): base(nome, nascimento, matricula){
			this.curso = curso;
		}
	}
}

