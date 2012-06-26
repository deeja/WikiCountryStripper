using System.Collections.Generic;

namespace CountryStuff
{
    public class NameLanguageSet: DbItem
    {
        public virtual string Name { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
    }
}