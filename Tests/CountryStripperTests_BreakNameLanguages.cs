using System.Linq;
using CountryStuff;
using CountryStuff.Entities;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CountryStripperTests_BreakNameLanguages
    {
        public const string NameSingleLanguageEntryExample =
            "Albanien (Alemannic)";

        public const string NameMultipleLanguageEntryExample =
            "Albanien (Alemannic, Austro-Bavarian, Danish, German, Low Saxon, Luxembourgish, Swedish)";

        [Test]
        public void BreakNameLaguages_CorrectName()
        {
            Variant set = NameSingleLanguageEntryExample.GenerateLanguageSets();

            Assert.AreEqual("Albanien", set.Name);
        }

        [Test]
        public void BreakNameLanguages_ReturnsOneLanguage()
        {
            Variant set = NameSingleLanguageEntryExample.GenerateLanguageSets();
            Assert.AreEqual(1, set.Languages.Count());
        }

        [Test]
        public void BreakNameLanguages_ReturnsOneCorrectlyNamedLanguage()
        {
            Variant set = NameSingleLanguageEntryExample.GenerateLanguageSets();
            Assert.AreEqual("Alemannic", set.Languages.First().Name);
        }

        [Test]
        public void BreakNameLanguages_ReturnsSevenLanguages()
        {
            Variant set = NameMultipleLanguageEntryExample.GenerateLanguageSets();
            Assert.AreEqual(7, set.Languages.Count());
        }

        [Test]
        public void BreakNameLanguages_ContainsCorrectName()
        {
            Variant set = NameMultipleLanguageEntryExample.GenerateLanguageSets();
            Assert.IsTrue(set.Languages.Any(x => x.Name == "Austro-Bavarian"));
        }
    }
}