using PsiicApi.Model;

namespace PsiicApi.Interfaces
{
	public interface IEnderecoRepositorio
	{
		void Add(Endereco usuario);
		List<Endereco> GetAll();
	}
}
