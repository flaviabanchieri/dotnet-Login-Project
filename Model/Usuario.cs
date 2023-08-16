using System.ComponentModel.DataAnnotations;

namespace PsiicApi.Model
{
	public class Usuario : Entity<int, Usuario>
	{

		[Required]
		[MaxLength(50)]
		public string NomeUsuario { get; private set; }

		[Required]
		[MaxLength(100)]
		public string Senha { get; private set; }

		[MaxLength(100)]
		public string Email { get; private set; }

		// Informações do perfil do usuário
		[MaxLength(50)]
		public string Nome { get; private set; }
		public string Sobrenome { get; private set; }

		[MaxLength(100)]
		public string FotoPerfil { get; private set; }

		[MaxLength(200)]
		public string Biografia { get; private set; }
		public DateTime DataNascimento { get; private set; }

		// Propriedades de controle de acesso e permissões
		public bool Ativo { get; private set; }
		public DateTime? DataUltimoLogin { get; private set; }


		// Relacionamentos
		public virtual List<Contato> Contatos { get; private set; } = new List<Contato>();
		public virtual List<Clinica> Clinicas { get; private set; } = new List<Clinica>();
		public virtual int ClinicaId { get; private set; }
		public virtual Clinica Clinica { get; private set; }
		public int PermissaoId { get; private set; }
		public virtual Permissoes Permissoes { get; private set; }
		public int EnderecoId { get; private set; }
		public virtual Endereco Endereco { get; private set; }

		public Usuario(string nomeUsuario, string senha, string email, string nome, string sobrenome, string fotoPerfil, string biografia, DateTime dataNascimento, bool ativo, DateTime? dataUltimoLogin, List<Contato> contatos, List<Clinica> clinicas, int clinicaId, Clinica clinica, int permissaoId, Permissoes permissoes, int enderecoId, Endereco endereco)
        {
            NomeUsuario = nomeUsuario;
            Senha = senha;
            Email = email;
            Nome = nome;
            Sobrenome = sobrenome;
            FotoPerfil = fotoPerfil;
            Biografia = biografia;
            DataNascimento = dataNascimento;
            Ativo = ativo;
            DataUltimoLogin = dataUltimoLogin;
            Contatos = contatos;
            Clinicas = clinicas;
            ClinicaId = clinicaId;
            Clinica = clinica;
            PermissaoId = permissaoId;
            Permissoes = permissoes;
            EnderecoId = enderecoId;
            Endereco = endereco;
        }

		public Usuario(string nome, string nomeUsuario)
		{
			Nome = nome;
			NomeUsuario = nomeUsuario;
		}

        public override bool Validar()
		{
			throw new NotImplementedException();
		}
	}
}
