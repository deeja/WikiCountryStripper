using System;
using System.ComponentModel.DataAnnotations;

namespace CountryStuff
{
    public abstract class DbItem
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}