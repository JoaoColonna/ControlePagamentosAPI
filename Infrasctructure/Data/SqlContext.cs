using Microsoft.EntityFrameworkCore;
using ControlePagamentoAPI.Domain.Models;

namespace ControlePagamentoAPI.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Data") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Data").CurrentValue = DateTime.Now.ToUniversalTime();
                    if (entry.Entity is Pagamento pagamento)
                    {
                        pagamento.Status = "Pendente";
                    }
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("Data").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}
