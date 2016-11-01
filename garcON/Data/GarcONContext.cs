using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using garcON.Model;

namespace garcON.Data
{
    public class GarcONContext : DbContext
    {
        public GarcONContext() : base("garcON")
        {

        }


        public DbSet<Pessoa> Pessoas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
