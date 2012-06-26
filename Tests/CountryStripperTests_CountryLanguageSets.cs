using System.Collections.Generic;
using CountryStuff;
using CountryStuff.Entities;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class CountryStripperTests_CountryLanguageSets
    {

        public const string SimpleCountryLanguagesSets =
            "Afeganistão (Portuguese), Afghanistan (Welsh), An Afganastáin (Irish)";

        public const string SlightlyMoreComplicated =
            " Armeeniä (Võro), Armenia (Albanian, Breton, Faroese, Finnish, Galician, Indonesian, Italian, Latin, Norwegian, Polish, Romanian, Spanish, Welsh)";

        public const string EvenMoreComplicated =
            " Bahama - Բահամա (Armenian), Bāhāmā - বাহামা (Bengali), Bahama (Estonian, Indonesian, Turkish, Võro), Bahama or Bahamasaaret (Finnish)," +
            " Bāhāmǎ - 巴哈馬 / 巴哈马 (Mandarin Chinese), Bahama - בהאמה (Hebrew), Bahama - バハマ (Japanese), Bahama / Pahama - 바하마 (Korean)," +
            " Baham adaları (Azeri), Bahamas (Afrikaans, Aragonese, Aromanian, Breton, Cebuano, Central Bikolano, Danish, Franco-Provençal, " +
            "French, German, Interlingua, Italian, Min Nan, Norwegian, Portuguese alternate, Spanish, Swedish, Romanian), Bahama's (Dutch), " +
            "Baħamas (Maltese), ";

        [Test]
        public void GetCountrySets_ThreeSetsReturned()
        {
            IEnumerable<string> sets = CountryStripper.GetCountrySets(SimpleCountryLanguagesSets);
            Assert.AreEqual(3, sets.Count());
        }

        [Test]
        public void GetCountrySets_SightyMoreComplicated_TwoSetsReturned()
        {
            IEnumerable<string> sets = CountryStripper.GetCountrySets(SlightlyMoreComplicated);
            Assert.AreEqual(2, sets.Count());
        }

        [Test]
        public void GetCountrySets_EvenMoreComplicated_TwelveSetsReturned()
        {
            IEnumerable<string> sets = CountryStripper.GetCountrySets(EvenMoreComplicated);
            Assert.AreEqual(12, sets.Count());
        }

        [Test]
        public void GetCountrySets_EvenMoreComplicated_FirstStringCorrect()
        {
            IEnumerable<string> sets = CountryStripper.GetCountrySets(EvenMoreComplicated);
            Assert.AreEqual(" Bahama - Բահամա (Armenian)", sets.First());
        }

        [Test]
        public void IntegrationOfTheTwo()
        {
            IEnumerable<string> sets = CountryStripper.GetCountrySets(EvenMoreComplicated);
            IEnumerable<Variant> nameLanguageSets = sets.Select(CountryStripper.GenerateLanguageSets);
            Assert.AreEqual(12,nameLanguageSets.Count());
        }
         
    }
}