namespace PsiicApi.Model
{
	public class Financeiro : Entity<int, Financeiro>
	{
		public decimal Valor { get; private set; }
		public string? Descricao { get; private set; }
		public int Tipo { get; private set; }
		public DateTime Data { get; private set; }

		// Relacionamentos
		public int ClinicaId { get; private set; }
		public virtual Clinica Clinica { get; private set; }
		public int ClienteId { get; private set; }
		public virtual Cliente Cliente { get; private set; }
		public int AtendimentoId { get; private set; }
		public virtual Atendimento Atendimento { get; private set; }

        public override bool Validar()
        {
            throw new NotImplementedException();
        }
    }
}
