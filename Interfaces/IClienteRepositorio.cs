using PsiicApi.Model;

namespace PsiicApi.Interfaces
{
	public interface IClienteRepositorio
	{
		void Add(Cliente usuario);
		List<Cliente> GetAll();
	}
}
