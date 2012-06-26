using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CountryStuff
{
    public class Country: DbItem
    {
        public virtual string EnglishName { get; set; }
        public virtual ICollection<NameLanguageSet> LanguageSets { get; set; }
    }

    public abstract class DbItem
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}