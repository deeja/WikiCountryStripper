using System.Collections.Generic;

namespace CountryStuff.Entities
{
    public class Variant: DbItem
    {
        public virtual string Name { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
    }
}