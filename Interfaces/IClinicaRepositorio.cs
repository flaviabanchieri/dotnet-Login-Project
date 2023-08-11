using PsiicApi.Model;

namespace PsiicApi.Interfaces
{
	public interface IClinicaRepositorio
	{
		void Add(Clinica usuario);
		List<Clinica> GetAll();
	}
}
