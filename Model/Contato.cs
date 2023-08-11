namespace PsiicApi.Model
{
	public class Contato : Entity<int, Contato>
	{
		public string Descricao { get; private set; }
		public int Tipo { get; private set; }
		public bool Principal { get; private set; }
		public int ClinicaId { get; private set; }

		public virtual Usuario Usuario { get; private set; }
		public virtual Cliente Cliente { get; private set; }
		public virtual Clinica Clinica { get; private set; }

		public override bool Validar()
		{
			throw new NotImplementedException();
		}
	}
}
