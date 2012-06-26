using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CountryStuff
{
    public static class Bootstrapper
    {
        public static void Setup()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CountryContext>());
            CountryContext context = new CountryContext();
            //just load up somthing to initialise

            List<Country> coun = context.Countries.ToList();
          }
         
    }
}