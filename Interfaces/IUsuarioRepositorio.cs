using PsiicApi.Model;

namespace PsiicApi.Interfaces
{
	public interface IUsuarioRepositorio
	{
		void Add(Usuario usuario);
		List<Usuario> GetAll();
	}
}
