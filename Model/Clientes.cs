using System.ComponentModel.DataAnnotations;

namespace PsiicApi.Model
{
	public class Cliente
	{
		[Key]
		public int Id { get; private set; }
		public string Nome { get; private set; }
		public string Contato { get; private set; }
		public string Observacoes { get; private set; }
		public bool PacoteSemanal { get; private set; }
		public decimal ValorConsulta { get; private set; }
		public decimal SaldoDevedor { get; private set; }
		public long Telefone { get; private set; }
		public int EnderecoId { get; private set; }
		public Endereco Endereco { get; private set; }

		public Cliente(int id, string nome, string contato, string observacoes, bool pacoteSemanal, decimal valorConsulta, decimal saldoDevedor, long telefone, int enderecoId, Endereco endereco)
		{
			Id = id;
			Nome = nome;
			Contato = contato;
			Observacoes = observacoes;
			PacoteSemanal = pacoteSemanal;
			ValorConsulta = valorConsulta;
			SaldoDevedor = saldoDevedor;
			Telefone = telefone;
			Endereco = endereco;
		}
	}

}
