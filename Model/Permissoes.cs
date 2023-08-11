namespace PsiicApi.Model
{
	public class Permissoes
	{
        public int Id { get; private set; }
		public string Descricao { get; private set; }
		public virtual Usuario Usuario { get; private set; }
	}
}
