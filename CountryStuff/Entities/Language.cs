using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CountryStuff.Entities
{
    public class Language: DbItem
    {
        public ICollection<NameLanguageSet> LanguageSets { get; set; }
        public string Name { get; set; }
    }
}