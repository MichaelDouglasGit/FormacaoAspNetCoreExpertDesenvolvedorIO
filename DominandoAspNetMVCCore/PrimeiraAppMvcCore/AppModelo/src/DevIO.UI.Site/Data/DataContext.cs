using Microsoft.EntityFrameworkCore;

namespace DevIO.UI.Site.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
