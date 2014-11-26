using System;

namespace Application
{
	public class Pessoa:IPessoa
	{
		private string nome;
		private string matricula;
		private DateTime nascimento;

		public Pessoa(string nome, DateTime nascimento, string matricula){
			this.nome = nome;
			this.nascimento = nascimento;
			this.matricula = matricula;
		}

		public string GetNome(){
			return nome;
		}

		public DateTime GetNascimento(){
			return nascimento;
		}

	}
}

