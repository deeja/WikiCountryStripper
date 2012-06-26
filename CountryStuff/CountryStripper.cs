using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace CountryStuff
{
    public static class CountryStripper
    {
        static readonly Regex LanguageSetMatcher = new Regex(@"(.*?\(.*?\))[,]{0,1}");

        /// <summary>
        /// Gets the name of the country as well as the languages that use that name
        /// </summary>
        /// <param name="toParse"></param>
        /// <returns></returns>
        internal static NameLanguageSet GenerateLanguageSets(this string toParse)
        {
            int firstBracket = toParse.IndexOf("(", System.StringComparison.Ordinal);
            string name = toParse.Substring(0, firstBracket).Trim();
            string languageString = toParse.Substring(firstBracket).Trim(new[]{'(',')'});
            IEnumerable<string> languages = languageString.Split(',').Select(x => x.Trim());
            return new NameLanguageSet(){Name = name, Languages = languages.Select(s => new Language{Name = s}).ToList()};
        }

        /// <summary>
        /// Gets the strings that can be broken in to language sets by GenerateLanguageSets()
        /// </summary>
        /// <param name="toParse"></param>
        /// <returns></returns>
        internal static IEnumerable<string> GetCountrySets(this string toParse)
        {
            var matches = LanguageSetMatcher.Matches(toParse).Cast<Match>();
            return matches.Select(x => x.Groups[1].Value);
        }

        /// <summary>
        /// Gets the tables out of the page that contain language versions of countries
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        internal static HtmlNodeCollection GetLanguageTables(this HtmlDocument doc)
        {
            return doc.DocumentNode.SelectNodes("//table[@border=1]");
        }

        /// <summary>
        /// Gets the rows that are not languages
        /// </summary>
        /// <param name="tableNode"></param>
        /// <returns></returns>
        internal static HtmlNodeCollection GetLanguageRows(this HtmlNode tableNode)
        {
            return tableNode.SelectNodes(".//tr[not(th)]");
        }

        internal static string GetLanguageName(this HtmlNode row)
        {
            return row.SelectNodes(".//td").First().InnerText;
        }

        internal static string GetLanguageSetText(this HtmlNode row)
        {
            return row.SelectNodes(".//td").Skip(1).First().InnerText;
        }

        public static IEnumerable<Country> GetCountries(HtmlDocument document)
        {
            return document.GetLanguageTables().SelectMany(GetLanguageRows).Select(x => new Country()
                                 {
                                     EnglishName = x.GetLanguageName(),
                                     LanguageSets = x.GetLanguageSetText().GetCountrySets().Select(GenerateLanguageSets).ToList()
                                 });
        }
    }

    public class CountryContext: DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<NameLanguageSet> LanguageSets { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}