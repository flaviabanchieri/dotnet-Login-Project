using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PsiicApi.Model 
{ 
	public abstract class Entity<TId, TEntity>
	{
		public TId Id { get; protected set; }
		public string UsuarioInclusao { get; protected set; }
		public DateTime DataInclusao { get; protected set; }
		public string UsuarioAlteracao { get; protected set; }
		public DateTime? DataAlteracao { get; protected set; }
		[NotMapped]
		public ValidationResult ValidationResult { get; protected set; }

		public abstract bool Validar();


		public void AlterarDataAlteracao(DateTime dataAlteracao)
		{
			DataAlteracao = dataAlteracao;
		}

		public void AlterarUsuarioAlteracao(string usuarioAlteracao)
		{
			UsuarioAlteracao = usuarioAlteracao;
		}

		public override int GetHashCode() => (GetType().GetHashCode() * 907) + Id.GetHashCode();

		public override string ToString() => GetType().Name + " [Id=" + Id + "]";
	}
}

