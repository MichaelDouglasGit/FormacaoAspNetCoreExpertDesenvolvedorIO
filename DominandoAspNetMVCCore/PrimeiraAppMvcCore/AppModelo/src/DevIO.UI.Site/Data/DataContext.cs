using DevIO.UI.Site.Models;
using Microsoft.EntityFrameworkCore;

namespace DevIO.UI.Site.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
