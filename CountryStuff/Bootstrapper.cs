#region

using System.Data.Entity;
using System.Linq;
using CountryStuff.Entities;

#endregion

namespace CountryStuff
{
    public static class Bootstrapper
    {
        public static void Setup()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CountryContext>());
            CountryContext context = new CountryContext();

            //just load up somthing to initialise
            context.Countries.ToList();
        }
    }
}