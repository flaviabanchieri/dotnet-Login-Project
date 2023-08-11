namespace PsiicApi.Model
{
	public class Endereco : Entity<int, Endereco>
	{
		public string Cep { get; private set; }
		public string Logradouro { get; private set; }
		public string Numero { get; private set; }
		public string Bairro { get; private set; }
		public string Cidade { get; private set; }
		public string Estado { get; private set; }
		public string Pais { get; private set; }

		public virtual Usuario Usuario { get; private set; }
		public virtual Cliente Cliente { get; private set; }
		public virtual Clinica Clinica { get; private set; }


		public override bool Validar()
		{
			throw new NotImplementedException();
		}
	}
}
