using Microsoft.EntityFrameworkCore;
using Registro_de_Clientes.Model;

namespace Registro_de_Clientes.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public Contexto(DbContextOptions<Contexto> options): base(options)
        {
        }
    }
}
