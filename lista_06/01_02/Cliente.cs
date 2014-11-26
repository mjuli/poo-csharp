using System;

namespace questao02
{
	public class Cliente
	{
		private string nome;
		private string cpf;
		private Cliente socio;
		private double limite;

		public Cliente (string nome, string cpf, double limite)
		{
			this.nome = nome;
			this.cpf = cpf;
			this.limite = limite;
		}

		public void SetSocio(Cliente C){
			this.socio = C;
			C.socio = this;
		}
		public double GetLimite(){
			if (socio != null) {
				return limite + socio.limite;
			} else {
				return limite;
			}

		}
		public	string GetNome(){
			return nome;
		}
		public	string GetCPF(){
			return cpf;
		}
		public	string GetSocio(){
			if (socio != null) {
				return socio.nome;
			} else {
				return "Não tem socio";
			}
		}
	}
}

