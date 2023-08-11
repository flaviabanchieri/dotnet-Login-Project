using System.ComponentModel.DataAnnotations;

namespace PsiicApi.Model
{
	public class Clinica
	{
		public string Nome { get; private set; }
		public string Logo { get; private set; }
		public string? Cnpj { get; private set; }
		public int? TipoId { get; private set; }


		// Relacionamentos
		public virtual List<Contato> Contatos { get; private set; } = new List<Contato>();
		public virtual Usuario Usuarios { get; private set; }
		public virtual List<Endereco> Endereco { get; private set; } = new List<Endereco>();
		public virtual List<Cliente> Clientes { get; private set; }
		public virtual List<Financeiro> Financeiro { get; private set; }

	}
}
