using System.Data.Entity;

namespace CountryStuff.Entities
{
    public class CountryContext: DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Variant> LanguageSets { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}