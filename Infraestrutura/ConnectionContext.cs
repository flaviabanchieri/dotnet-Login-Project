using Microsoft.EntityFrameworkCore;
using PsiicApi.Model;

namespace PsiicApi.Infraestrutura
{
	public class ConnectionContext : DbContext
	{
		public DbSet<Usuario> Usuarios { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		=>optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=myDataBase;Trusted_Connection=True;");
	}
}
