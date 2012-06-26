using System.Collections.Generic;

namespace CountryStuff.Entities
{
    public class Country: DbItem
    {
        public virtual string EnglishName { get; set; }
        public virtual ICollection<Variant> Variants { get; set; }
    }
}