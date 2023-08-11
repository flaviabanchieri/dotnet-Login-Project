namespace PsiicApi.Model
{
	public class Atendimento
	{
		public DateTime DataHora { get; private set; }
		public decimal Valor { get; private set; }
        public string Descricao { get; private set; }
        public int Tag { get; private set; }

        // Relacionamentos
        public int ClienteId { get; private set; }
		public int ClinicaId { get; private set; }
		public virtual Cliente Cliente { get; private set; }
		public virtual Clinica Clinica { get; private set; }
	}
}
