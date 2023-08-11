using PsiicApi.Model;

namespace PsiicApi.Interfaces
{
	public interface IAtendimentoRepositorio
	{
		void Add(Atendimento usuario);
		List<Atendimento> GetAll();
	}
}
