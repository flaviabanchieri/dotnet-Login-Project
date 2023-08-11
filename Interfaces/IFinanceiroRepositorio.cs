using PsiicApi.Model;

namespace PsiicApi.Interfaces
{
	public interface IFinanceiroRepositorio
	{
		void Add(Financeiro usuario);
		List<Financeiro> GetAll();
	}
}
