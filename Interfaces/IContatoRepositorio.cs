using PsiicApi.Model;

namespace PsiicApi.Interfaces
{
	public interface IContatoRepositorio
	{
		void Add(Contato usuario);
		List<Contato> GetAll();
	}
}
