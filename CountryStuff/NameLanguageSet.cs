using System.Collections.Generic;

namespace CountryStuff
{
    public class NameLanguageSet: DbItem
    {
        public virtual string Name { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
    }

    public class Language: DbItem
    {
        public string Name { get; set; }
    }
}