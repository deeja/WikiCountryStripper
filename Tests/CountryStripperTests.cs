using System.Collections.Generic;
using CountryStuff;
using HtmlAgilityPack;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    [TestFixture]
    public class CountryStripperTests
    {
        #region Text

        public const string TableNode = @"
<table border=""1"" cellspacing=""0"" cellpadding=""3"">
<tbody><tr>
<th><b>English Name</b></th>
<th><b>Other name(s) or older name(s)</b></th>
</tr>
<tr>
<td><a href=""/wiki/Jamaica"" title=""Jamaica"">Jamaica</a></td>
<td><b>Chamaica</b> (Aragonese), <b>Chamaika</b> - ?????? (Thai), <b>Gamayka</b> - ???? (Amharic), <b>Gammajka</b> (Maltese), <b>Giamaica</b> (Italian), <b>Hamayka</b> (Filipino/Tagalog), <b>Iamaika</b> - <i>??????</i> (Belarusian), <b>Jamaica</b> (<a href=""/wiki/Danish_language"" title=""Danish language"">Danish</a>, <a href=""/wiki/Dutch_language"" title=""Dutch language"">Dutch</a>, <a href=""/wiki/Estonian_language"" title=""Estonian language"">Estonian</a>, <a href=""/wiki/Hungarian_language"" title=""Hungarian language"">Hungarian</a>, <a href=""/wiki/Latin_language"" title=""Latin language"" class=""mw-redirect"">Latin</a>, <a href=""/wiki/Min_Nan"" title=""Min Nan"">Min Nan</a>, <a href=""/wiki/Norwegian_language"" title=""Norwegian language"">Norwegian</a>, <a href=""/wiki/Portuguese_language"" title=""Portuguese language"">Romanian</a>, <a href=""/wiki/Spanish_language"" title=""Spanish language"">Spanish</a>, <a href=""/wiki/Swedish_language"" title=""Swedish language"">Swedish</a>, <a href=""/wiki/V%C3%B5ro_language"" title=""Võro language"">Võro</a>, <a href=""/wiki/Welsh_language"" title=""Welsh language"">Welsh</a>), <b>Jamaika</b> (<a href=""/wiki/Acehnese_language"" title=""Acehnese language"">Acehnese</a>, <a href=""/wiki/Afrikaans"" title=""Afrikaans"">Afrikaans</a>, <a href=""/wiki/Alemannic_German"" title=""Alemannic German"">Alemannic</a>, <a href=""/wiki/Faroese_language"" title=""Faroese language"">Faroese</a>, <a href=""/wiki/Finnish_language"" title=""Finnish language"">Finnish</a>, <a href=""/wiki/German_language"" title=""German language"">German</a>, Indonesian, Inuktitut, Latvian, Lithuanian, Turkish), <b>Jamaika</b> - ??????? (Arabic, Persian), <b>Jamaika</b> - ?'?????? (Hebrew), <b>Jamaika</b> - ????? (Japanese), <b>Jamaïque</b> (French), <b>Jamajka</b> (Croatian, Czech, Polish, Slovak, Slovene), <b>Jamajka</b> - <i>???????</i> (Serbian), <b>Jamajko</b> (Esperanto), <b>J·amayica</b> (Franco-Provençal), <b>Jamayka</b> - ??????? (Armenian), <b>Jameika</b> / <b>Chameik'a</b> - ???? (Korean), <b>Semeuca</b> (Scots Gaelic), <b>Tzamáika</b> - <i>?aµa???</i> (Greek), <b>Xamaica</b> (Asturian, <a href=""/wiki/Leonese_language"" title=""Leonese language"">Leonese</a>), <b>Xamayka</b> (Aymara), <b>Xhamaijkë</b> (Albanian), <b>Yámaijia</b> - ???/??? (Mandarin Chinese), <b>Yamayka</b> (Azeri), <b>Yamayka</b> - <i>??????</i> (Bulgarian, Russian, Ukrainian)</td>
</tr>
<tr>
<td><a href=""/wiki/Japan"" title=""Japan"">Japan</a></td>
<td><b>Chapón</b> (Aragonese), <b>Gapan</b> - ??? (Amharic), <b>Gappun</b> (Maltese), <b>Giappone</b> (Italian), <b>Giapun</b> (Romansh), <b>Hapón</b> (Filipino/Tagalog), <b>Hapõñ</b> (Guarani), <b>Iapan</b> (Scots Gaelic), <b>Iaponía</b> - <i>?ap???a</i> (Greek), <b>Iaponia</b> (Latin), <b>Ilbon</b> - ??(??) (Korean), <b>Jaapan</b> (Estonian, Võro), <b>Japan</b> (Afrikaans, Alemannic, Danish, Dutch, Faroese, German, Norwegian, Swedish), <b>Japán</b> (Hungarian), <b>Japan</b> - <i>?????</i> (Serbian), <b>Japana</b> - ????? (Assamese, Bengali), <b>Japana</b> (Latvian), <b>Japani</b> (Finnish), <b>Japanio</b> (Esperanto), <b>Japanip Inuujarvik</b> (Inuktitut), <b>Japanska</b> (Lower Sorbian), <b>Japão</b> (Portuguese), <b>el Japó</b> (Catalan), <b>J·apon</b> (Franco-Provençal), <b>Japon</b> (French, Interlingua), <b>Japon</b> - ???? (Persian), <b>Japón</b> (Spanish), <b>Japonia</b> (Albanian, Polish, Romanian), <b>Japonia</b> - ??????? (Armenian), <b>Japonija</b> (Lithuanian), <b>Japonska</b> (Slovene), <b>Japonsko</b> (Czech, Slovak), <b>Japonya</b> (Turkish), <b>Jepang</b> (Indonesian), <b>Jepun</b> (Malay), <b>Jeupun</b> (Acehnese), <b>Ji?t-pún</b> (Min Nan), <b>Nh?t B?n</b>, <b>Nh?t B?n</b>, or <b>Nh?t B?n</b> (Vietnamese), <b>Nippon</b> or <b>Nihon</b> - ?? (Japanese), <b>Rìben</b> - ?? (Mandarin Chinese), <b>an tSeapáin</b> (Irish), <b>Siapan</b> (Welsh), <b>Xapón</b> (Asturian, Galician, Leonese), <b>al-Yaban</b> - ??????? (Arabic), <b>Yapan</b> - ??? (Hebrew), <b>Yapan</b> - ???????? (Yiddish), <b>Yaponiya</b> (Azeri), <b>Yaponiya</b> - <i>??o???</i> (Bashkir, Bulgarian, Russian), <b>Yaponiya</b> - <i>??o???</i> (Ukrainian), <b>Yipun</b> - ??????? (Thai)</td>
</tr>
<tr>
<td><a href=""/wiki/Jordan"" title=""Jordan"">Jordan</a></td>
<td><b>Chordania</b> (Aragonese), <b>Chord?n</b> - ??????? (Thai), <b>Giordania</b> (Italian), <b>Gordan</b> (Maltese), <b>Hordan</b> (Filipino/Tagalog), <b>Hordanan</b> - ???????? (Armenian), <b>Iardaniia</b> - <i>???????</i> (Belarusian), <b>Iok-tàn</b> (Min Nan), <b>Iòrdan</b> (Scots Gaelic), <b>Iordanía</b> - <i>???da??a</i> (Greek), <b>Iordania</b> (Romanian), <b>Iordaniya</b> - <i>????????</i> (Russian), <b>Iorddonen</b> (Welsh), <b>Jardana</b> - ?????? (Bengali), <b>Jordaania</b> (Estonian, Võro), <b>Jordan</b> (Croatian, Danish, Faroese, Malay, Norwegian), <b>Jordan</b> - <i>??????</i> (Serbian), <b>Jordania</b> (Albanian, Finnish, Interlingua, Latin, Polish, Spanish), <b>Jordánia</b> (Hungarian), <b>Jórdanía</b> - (Icelandic), <b>Jordânia</b> (Portuguese), <b>Jordanië</b> (Afrikaans, Dutch), <b>J·ordanie</b> (Franco-Provençal), <b>Jordanie</b> (French), <b>Jordanien</b> (Alemannic, German, Swedish), <b>Jordanija</b> (Latvian), <b>Jordanija</b> (Lithuanian, Slovene), <b>Jordanio</b> (Esperanto), <b>Jordánsko</b> (Czech, Slovak), <b>Jurutan</b> (Inuktitut), <b>Rjor-?ana</b> - ???????? ?? (Tibetan), <b>al-Urdun</b> - ?????? (Arabic), <b>Ürdün</b> or <b>Iordaniya</b> (Azeri), <b>Ürdün</b> (Turkish), <b>Xordania</b> (Asturian), <b>Xordaña</b> (Leonese) <b>Yarden</b> - ???? (Hebrew), <b>Yardn</b> - ???? (Yiddish), <b>Yordania</b> (Acehnese, Indonesian), <b>Yordaniya</b> - <i>????????</i> (Bulgarian), <b>Yordaniya</b> - <i>????????</i> (Ukrainian), <b>Yordanya</b> (Central Bikolano), <b>Yoreudan</b> / <b>Yorudan</b> - ??? (Korean), <b>Yorudan</b> - ???? (Japanese), <b>Yuedàn</b> - ??/?? (Chinese)
<p>Formerly <b>Mavera-i Ürdün</b> (Turkish), <b>Teuranseu Yoreudan</b> / <b>T'uransu Yorudan</b> - ??? ??? (Korean), <b>Transgiordania</b> (Italian), <b>Transjordan</b> (Danish, English, Malay, Norwegian), <b>Transjordania</b> (Finnish, Polish, Spanish), <b>Transjordânia</b> (Portuguese), <b>Transjordanië</b> (Dutch), <b>Transjordanie</b> (French), <b>Transjordanien</b> (German, Swedish), <b>Transjordánsko</b> (Czech), <b>Transyordania</b> (Indonesian), <b>Wàiyuedàn</b> - ??? (Mandarin Chinese)</p>
</td>
</tr>
</tbody></table>

";

        public const string RowNode = @"
<tr>
<td><a href=""/wiki/Jamaica"" title=""Jamaica"">Jamaica</a></td>
<td><b>Hamayka</b> (Filipino/Tagalog), <b>Iamaika</b> - <i>??????</i> (Belarusian),<b>Yamayka</b> - <i>??????</i> (Bulgarian, Russian, Ukrainian)</td>
</tr>
";


        #endregion
        
        [Test]
        public void HtmlLoads_Yay()
        {
            GetHtmlDocument();
        }

        [Test]
        public void HtmlLoads_SevenTables()
        {
            var tables = GetHtmlDocument().GetLanguageTables();
            Assert.AreEqual(7, tables.Count);
        }

        private static HtmlDocument GetHtmlDocument()
        {
            FakeHtmlService service = new FakeHtmlService(); //something aint right here
            return service.GetWebPage(string.Empty);
        }

        [Test]
        public void GetLanguageRows_Gets_The_CorrectNumberOfRows()
        {
            var tableNode = GetHtmlAsNode(TableNode);
            var rows = tableNode.GetLanguageRows();
            Assert.AreEqual(3, rows.Count);
        }

        [Test]
        public void GetLanguageName_Jamaica()
        {
            var row = GetHtmlAsNode(RowNode);
            string name = row.GetLanguageName();
            Assert.AreEqual("Jamaica", name );
        }

        [Test]
        public void GetLanguageSetText()
        {
            const string expected =
                "Hamayka (Filipino/Tagalog), Iamaika - ?????? (Belarusian),Yamayka - ?????? (Bulgarian, Russian, Ukrainian)";
            var row = GetHtmlAsNode(RowNode);
            var text = row.GetLanguageSetText();
            Assert.AreEqual(expected,text);
        }


        [Test]
        public void GetCountries_BasicallyWorks()
        {
            HtmlDocument doc = GetHtmlDocument();
            IEnumerable<Country> countries = CountryStripper.GetCountries(doc);
            Assert.AreEqual(68,countries.Count());
        }


        private static HtmlNode GetHtmlAsNode(string html)
        {
            HtmlDocument tableDoc = new HtmlDocument();
            tableDoc.LoadHtml(html);
            return tableDoc.DocumentNode;
        }
    }
}