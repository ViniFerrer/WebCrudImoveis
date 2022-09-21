using Microsoft.EntityFrameworkCore;

namespace WebCrudImoveis.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {


        }

        public DbSet<Imovel> Imoveis { get; set; }
    }
}
