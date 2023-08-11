using System.ComponentModel.DataAnnotations;

namespace PsiicApi.Model
{
	public class Cliente : Entity<int, Cliente>
	{
		public string Nome { get; private set; }
		public string Sobrenome { get; private set; }
		public string Observacoes { get; private set; }
		public DateTime? DataNascimento { get; private set; }
		public bool PacoteSemanal { get; private set; }
		public decimal ValorConsulta { get; private set; }
		public decimal SaldoDevedor { get; private set; }
		public long Telefone { get; private set; }
		public int SituacaoId { get; private set; }


		//Consultas
		public DayOfWeek? DiaSemanaAtendimentoSemanal { get; private set; }
		public List<DateTime> DatasAtendimentoAvulso { get; private set; } = new List<DateTime>();

		// Relacionamentos
		public int ClinicaId { get; private set; }
		public Clinica Clinica { get; private set; }
		public List<Atendimento> Atendimentos { get; private set; } = new List<Atendimento>();
		public virtual List<Contato> Contatos { get; private set; } = new List<Contato>();
		public virtual List<Financeiro> Financeiros { get; private set; } = new List<Financeiro>();
		public int EnderecoId { get; private set; }
		public virtual Endereco Endereco { get; private set; }


		public override bool Validar()
		{
			throw new NotImplementedException();
		}
	}

}
