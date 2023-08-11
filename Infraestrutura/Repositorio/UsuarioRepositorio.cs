using PsiicApi.Interfaces;
using PsiicApi.Model;

namespace PsiicApi.Infraestrutura.Repositorio
{
	public class UsuarioRepositorio : IUsuarioRepositorio
	{
		private readonly ConnectionContext _context = new ConnectionContext();
		public void Add(Usuario usuario)
		{
			_context.Add(usuario);
			_context.SaveChanges();
		}

		public List<Usuario> GetAll()
		{
			return _context.Usuarios.ToList();
		}
	}
}
