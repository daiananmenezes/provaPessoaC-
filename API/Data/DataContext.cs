using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Pessoa> TabelaPessoas { get; set; }
    }
}