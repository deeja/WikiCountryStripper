using System.IO;
using HtmlAgilityPack;

namespace CountryStuff
{
    public class FakeHtmlService : IHtmlService
    {
        public HtmlDocument GetWebPage(string url)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(Html);
            return doc;
        }

        public const string Html = @"
<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html lang=""en"" dir=""ltr"" class=""client-nojs"" xmlns=""http://www.w3.org/1999/xhtml"">
<head>
<title>List of country names in various languages (J–P) - Wikipedia, the free encyclopedia</title>
<meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
<meta http-equiv=""Content-Style-Type"" content=""text/css"" />
<meta name=""generator"" content=""MediaWiki 1.19wmf1"" />
<link rel=""canonical"" href=""/wiki/List_of_country_names_in_various_languages_(J%E2%80%93P)"" />
<link rel=""alternate"" type=""application/x-wiki"" title=""Edit this page"" href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit"" />
<link rel=""edit"" title=""Edit this page"" href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit"" />
<link rel=""apple-touch-icon"" href=""//en.wikipedia.org/apple-touch-icon.png"" />
<link rel=""shortcut icon"" href=""/favicon.ico"" />
<link rel=""search"" type=""application/opensearchdescription+xml"" href=""/w/opensearch_desc.php"" title=""Wikipedia (en)"" />
<link rel=""EditURI"" type=""application/rsd+xml"" href=""//en.wikipedia.org/w/api.php?action=rsd"" />
<link rel=""copyright"" href=""//creativecommons.org/licenses/by-sa/3.0/"" />
<link rel=""alternate"" type=""application/atom+xml"" title=""Wikipedia Atom feed"" href=""/w/index.php?title=Special:RecentChanges&amp;feed=atom"" />
<link rel=""stylesheet"" href=""//bits.wikimedia.org/en.wikipedia.org/load.php?debug=false&amp;lang=en&amp;modules=ext.gadget.teahouse%7Cext.wikihiero%7Cmediawiki.legacy.commonPrint%2Cshared%7Cskins.vector&amp;only=styles&amp;skin=vector&amp;*"" type=""text/css"" media=""all"" />
<meta name=""ResourceLoaderDynamicStyles"" content="""" />
<link rel=""stylesheet"" href=""//bits.wikimedia.org/en.wikipedia.org/load.php?debug=false&amp;lang=en&amp;modules=site&amp;only=styles&amp;skin=vector&amp;*"" type=""text/css"" media=""all"" />
<style type=""text/css"" media=""all"">a:lang(ar),a:lang(ckb),a:lang(fa),a:lang(kk-arab),a:lang(mzn),a:lang(ps),a:lang(ur){text-decoration:none}a.new,#quickbar a.new{color:#ba0000}

/* cache key: enwiki:resourceloader:filter:minify-css:7:c88e2bcd56513749bec09a7e29cb3ffa */</style>

<script src=""//bits.wikimedia.org/en.wikipedia.org/load.php?debug=false&amp;lang=en&amp;modules=startup&amp;only=scripts&amp;skin=vector&amp;*"" type=""text/javascript""></script>
<script type=""text/javascript"">if(window.mw){
mw.config.set({""wgCanonicalNamespace"":"""",""wgCanonicalSpecialPageName"":false,""wgNamespaceNumber"":0,""wgPageName"":""List_of_country_names_in_various_languages_(J–P)"",""wgTitle"":""List of country names in various languages (J–P)"",""wgCurRevisionId"":476812101,""wgArticleId"":2922628,""wgIsArticle"":true,""wgAction"":""view"",""wgUserName"":null,""wgUserGroups"":[""*""],""wgCategories"":[""Countries-languages-related lists"",""Lists of country names"",""Language comparison""],""wgBreakFrames"":false,""wgPageContentLanguage"":""en"",""wgSeparatorTransformTable"":["""",""""],""wgDigitTransformTable"":["""",""""],""wgRelevantPageName"":""List_of_country_names_in_various_languages_(J–P)"",""wgRestrictionEdit"":[],""wgRestrictionMove"":[],""wgSearchNamespaces"":[0],""wgRedirectedFrom"":""List_of_country_names_in_various_languages_(J-P)"",""wgVectorEnabledModules"":{""collapsiblenav"":true,""collapsibletabs"":true,""editwarning"":true,""expandablesearch"":false,""footercleanup"":false,""sectioneditlinks"":false,""simplesearch"":true,""experiments"":true},""wgWikiEditorEnabledModules"":{""toolbar"":true,""dialogs"":true,""hidesig"":true,""templateEditor"":false,""templates"":false,""preview"":false,""previewDialog"":false,""publish"":false,""toc"":false},""wgTrackingToken"":""8e5a46eacbb5bfe4308c5e5284aa9bec"",""wikilove-recipient"":"""",""wikilove-edittoken"":""+\\"",""wikilove-anon"":0,""mbEmailEnabled"":true,""mbUserEmail"":false,""mbIsEmailConfirmationPending"":false,""wgFlaggedRevsParams"":{""tags"":{""status"":{""levels"":1,""quality"":2,""pristine"":3}}},""wgStableRevisionId"":null,""wgCategoryTreePageCategoryOptions"":""{\""mode\"":0,\""hideprefix\"":20,\""showcount\"":true,\""namespaces\"":false}"",""Geo"":{""city"":"""",""country"":""""},""wgNoticeProject"":""wikipedia""});
}</script><script type=""text/javascript"">if(window.mw){
mw.loader.implement(""user.options"",function($){mw.user.options.set({""ccmeonemails"":0,""cols"":80,""date"":""default"",""diffonly"":0,""disablemail"":0,""disablesuggest"":0,""editfont"":""default"",""editondblclick"":0,""editsection"":1,""editsectiononrightclick"":0,""enotifminoredits"":0,""enotifrevealaddr"":0,""enotifusertalkpages"":1,""enotifwatchlistpages"":0,""extendwatchlist"":0,""externaldiff"":0,""externaleditor"":0,""fancysig"":0,""forceeditsummary"":0,""gender"":""unknown"",""hideminor"":0,""hidepatrolled"":0,""highlightbroken"":1,""imagesize"":2,""justify"":0,""math"":0,""minordefault"":0,""newpageshidepatrolled"":0,""nocache"":0,""noconvertlink"":0,""norollbackdiff"":0,""numberheadings"":0,""previewonfirst"":0,""previewontop"":1,""quickbar"":5,""rcdays"":7,""rclimit"":50,""rememberpassword"":0,""rows"":25,""searchlimit"":20,""showhiddencats"":false,""showjumplinks"":1,""shownumberswatching"":1,""showtoc"":1,""showtoolbar"":1,""skin"":""vector"",""stubthreshold"":0,""thumbsize"":4,""underline"":2,""uselivepreview"":0,""usenewrc"":0,""watchcreations"":1,""watchdefault"":0,
""watchdeletion"":0,""watchlistdays"":3,""watchlisthideanons"":0,""watchlisthidebots"":0,""watchlisthideliu"":0,""watchlisthideminor"":0,""watchlisthideown"":0,""watchlisthidepatrolled"":0,""watchmoves"":0,""wllimit"":250,""flaggedrevssimpleui"":1,""flaggedrevsstable"":0,""flaggedrevseditdiffs"":true,""flaggedrevsviewdiffs"":false,""vector-simplesearch"":1,""useeditwarning"":1,""vector-collapsiblenav"":1,""usebetatoolbar"":1,""usebetatoolbar-cgd"":1,""wikilove-enabled"":1,""variant"":""en"",""language"":""en"",""searchNs0"":true,""searchNs1"":false,""searchNs2"":false,""searchNs3"":false,""searchNs4"":false,""searchNs5"":false,""searchNs6"":false,""searchNs7"":false,""searchNs8"":false,""searchNs9"":false,""searchNs10"":false,""searchNs11"":false,""searchNs12"":false,""searchNs13"":false,""searchNs14"":false,""searchNs15"":false,""searchNs100"":false,""searchNs101"":false,""searchNs108"":false,""searchNs109"":false,""gadget-teahouse"":1,""gadget-mySandbox"":1});;},{},{});mw.loader.implement(""user.tokens"",function($){mw.user.tokens.set({""editToken"":""+\\"",""watchToken"":false});;
},{},{});

/* cache key: enwiki:resourceloader:filter:minify-js:7:ecf8688ef3caaee08a2939104d260ddb */
}</script>
<script type=""text/javascript"">if(window.mw){
mw.loader.load([""mediawiki.page.startup"",""mediawiki.legacy.wikibits"",""mediawiki.legacy.ajax""]);
}</script>
<!--[if lt IE 7]><style type=""text/css"">body{behavior:url(""/w/skins-1.19/vector/csshover.min.htc"")}</style><![endif]--></head>
<body class=""mediawiki ltr sitedir-ltr ns-0 ns-subject page-List_of_country_names_in_various_languages_J–P skin-vector action-view"">
		<div id=""mw-page-base"" class=""noprint""></div>
		<div id=""mw-head-base"" class=""noprint""></div>
		<!-- content -->
		<div id=""content"" class=""mw-body"">
			<a id=""top""></a>
			<div id=""mw-js-message"" style=""display:none;""></div>
						<!-- sitenotice -->
			<div id=""siteNotice""><!-- centralNotice loads here --></div>
			<!-- /sitenotice -->
						<!-- firstHeading -->
			<h1 id=""firstHeading"" class=""firstHeading"">
				<span dir=""auto"">List of country names in various languages (J–P)</span>
			</h1>
			<!-- /firstHeading -->
			<!-- bodyContent -->
			<div id=""bodyContent"">
								<!-- tagline -->
				<div id=""siteSub"">From Wikipedia, the free encyclopedia</div>
				<!-- /tagline -->
								<!-- subtitle -->
				<div id=""contentSub"">  (Redirected from <a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J-P)&amp;redirect=no"" title=""List of country names in various languages (J-P)"">List of country names in various languages (J-P)</a>)</div>
				<!-- /subtitle -->
																<!-- jumpto -->
				<div id=""jump-to-nav"" class=""mw-jump"">
					Jump to: <a href=""#mw-head"">navigation</a>,
					<a href=""#p-search"">search</a>
				</div>
				<!-- /jumpto -->
								<!-- bodycontent -->
				<div id=""mw-content-text"" lang=""en"" dir=""ltr"" class=""mw-content-ltr""><p>Most <b>countries of the world</b> have <b>different names</b> in different languages. Some countries have also undergone name changes for political or other reasons. This article attempts to give all known alternative names for all nations, countries and sovereign states. It does not offr any opinion about what the ""original"", ""official"", ""real"", or ""correct"" name of any country is or was.</p>
<p>Countries are listed alphabetically by their <b>current best-known name in English</b>. Each English name is followed by its currently best-known equivalents in other languages, listed in English alphabetical order (ignoring accents) by name and by language. Historical and/or alternative versions, where included, are noted as such. Foreign names that are the same as their English equivalents are listed, to provide an answer to the question ""What is that name in...""?. See also: <a href=""/wiki/List_of_alternative_country_names"" title=""List of alternative country names"">List of alternative country names</a></p>
<p>Please format entries as follows: for languages written in the Latin alphabet, write ""<b>Name</b> (language)"", for example, ""<b>Afeganistão</b> (Portuguese)"", and alphabetize it in the list according to English rules of alphabetical order. For languages written in other <a href=""/wiki/Writing_system"" title=""Writing system"">writing systems</a>, write ""<b>Romanization</b> - native script (language)"", for example ""<b>Argentine</b> - ?????????? (Yiddish)"", and alphabetize it in the list by the romanized form.</p>
<p>For reasons of size, this article is broken into four parts:</p>
<ul>
<li><a href=""/wiki/List_of_country_names_in_various_languages_(A%E2%80%93C)"" title=""List of country names in various languages (A–C)"">List of country names in various languages (A–C)</a></li>
<li><a href=""/wiki/List_of_country_names_in_various_languages_(D%E2%80%93I)"" title=""List of country names in various languages (D–I)"">List of country names in various languages (D–I)</a></li>
<li><b>List of country names in various languages (J–P)</b></li>
<li><a href=""/wiki/List_of_country_names_in_various_languages_(Q%E2%80%93Z)"" title=""List of country names in various languages (Q–Z)"">List of country names in various languages (Q–Z)</a></li>
</ul>
<p><br />
<b>Table of contents:</b> <a href=""#J"">J</a> — <a href=""#K"">K</a> — <a href=""#L"">L</a> — <a href=""#M"">M</a> — <a href=""#N"">N</a> — <a href=""#O"">O</a> — <a href=""#P"">P</a></p>
<h2><span class=""editsection"">[<a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit&amp;section=1"" title=""Edit section: J"">edit</a>]</span> <span class=""mw-headline"" id=""J"">J</span></h2>
<table border=""1"" cellspacing=""0"" cellpadding=""3"">
<tr>
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
</table>
<h2><span class=""editsection"">[<a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit&amp;section=2"" title=""Edit section: K"">edit</a>]</span> <span class=""mw-headline"" id=""K"">K</span></h2>
<table border=""1"" cellspacing=""0"" cellpadding=""3"">
<tr>
<th><b>English Name</b></th>
<th><b>Other name(s) or older name(s)</b></th>
</tr>
<tr>
<td><a href=""/wiki/Kazakhstan"" title=""Kazakhstan"">Kazakhstan</a></td>
<td><b>Casachia</b> (Latin), <b>Casachstan</b> (Scots Gaelic, Welsh), <b>Casaquistão</b> (Portuguese variant), <b>Cazaquistán</b> (Aragonese), <b>Cazaquistão</b> (Portuguese), <b>an Chasacstáin</b> (Irish), <b>Ghazaghestan</b> - ???????? (Persian), <b>Ghazakhstan</b> - ????????? (Armenian), <b>Hasàkè</b> - ???/??? (Mandarin Chinese variant), <b>Hasàkèsitan</b> - ?????/????? (Mandarin Chinese), <b>Kajaheuseutan</b> / <b>K'ajahusut'an</b> - ????? (Korean), <b>Kajakhastana</b> - ?????????? (Assamese, Bengali), <b>Kasachstan</b> (Alemannic, German), <b>Kasahstan</b> (Estonian), <b>Kasakhstan</b> (Danish, Norwegian), <b>Kasakstan</b> (Afrikaans, Faroese, Icelandic), <b>Kasastan</b> (Võro), <b>Kazachstán</b> (Czech), <b>Kazachstan</b> (Dutch, Polish, Slovak), <b>Kazachstan</b> - ?????? (Hebrew), <b>Kazachstanas</b> (Lithuanian), <b>Kazacstan</b> (Franco-Provençal), <b>Kazafusutan</b> - ?????? (Japanese), <b>Kazahio</b> (Esperanto), <b>Kazahstan</b> (Aromanian, Romanian, Slovene), <b>Kazahstan</b> - <i>?????????</i> (Bulgarian, Serbian), <b>Kazahstana</b> (Latvian), <b>Kazahsztán</b> (Hungarian), <b>Kazajistán</b> (Guaraní), <b>Kazajistán</b> or <b>Kazajstán</b> (Spanish), <b>Kazakhistán</b> (Asturian), <b>Kazakhstan</b> (Acehnese, French, Min Nan), <b>Kazakhstan</b> - ????????? (Arabic, Urdu), <b>Kazakhstan</b> - <i>?????????</i> (Russian, Ukrainian), <b>Kazakistan</b> (Italian, Turkish), <b>Kazakistan</b> (Maltese), <b>Kazakistani</b> (Albanian), <b>Kazakhstan</b> (Swedish), <b>Kazakstan</b> (Finnish), <b>Kazakstán</b> - <i>?a?a?st??</i> (Greek), <b>Khasakhsthan</b> - ????????? (Thai), <b>Qasaqsitan</b> (Inuktitut), <b>Qazakheti</b> - ???????? (Georgian), <b>Qazaqstan</b> - <i>?????????</i> (Kazakh), <b>Qazaxistan</b> (Azeri)</td>
</tr>
<tr>
<td><a href=""/wiki/Kenya"" title=""Kenya"">Kenya</a></td>
<td><b>Cèinia</b> (Scots Gaelic), <b>Cenia</b> or <b>Cenya</b> (Welsh), <b>Keenia</b> (Estonian alternate), <b>Keeniä</b> (Võro), <b>Keña</b> (Asturian), <b>Kena</b> (Czech), <b>Kenia</b> (Afrikaans, Alemannic, Aragonese, Dutch, Finnish, Franco-Provençal, German, Polish, Romanian alternative, Spanish), <b>Kenia</b> - ??? (Japanese), <b>K'enia</b> - ??? (North Korean alternate), <b>Keniia</b> - <i>?????</i> (Belarusian, Ukrainian), <b>Kenija</b> (Latvian, Lithuanian, Slovene), <b>Kenija</b> - <i>??????</i> (Serbian), <b>Keniya</b> (Azeri), <b>Keni?a</b> - ??????? (Bengali), <b>Keniya</b> - <i>?????</i> (Bulgarian, Russian), <b>Kenja</b> (Faroese, Maltese), <b>Kenjo</b> (Esperanto), <b>Kenníyà</b> - ???/??? (Mandarin Chinese), <b>Kenya</b> (Acehnese, Bambara, Danish, Estonian, French, Hungarian, Indonesian, Italian, Malay, Min Nan, Norwegian, Romanian, Swedish, Turkish), <b>Kénya</b> - ??? (Amharic), <b>Kenya</b> - ????? (Armenian), <b>Kenya</b>, <b>Kenië</b> or <b>Kenyë</b> (Dutch alternates), <b>Kénya</b> - <i>????a</i> (Greek), <b>Kenya</b> - ???? (Hebrew), <b>Kenya</b> / <b>K'enya</b> - ?? (Korean), <b>Kenya</b> - ???? (Persian), <b>Keyà</b> - ??/?? (Mandarin Chinese variant), <b>Khenya</b> - ????? (Thai), <b>Kinia</b> (Inuktitut), <b>Kiniya</b> - ????? (Arabic), <b>Quênia</b> (Brazilian Portuguese), <b>Quénia</b> (European Portuguese)</td>
</tr>
<tr>
<td><a href=""/wiki/Kiribati"" title=""Kiribati"">Kiribati</a></td>
<td><b>Ciribati</b> (Scots Gaelic), <b>Jilibasi</b> - ???? (Mandarin Chinese), <b>Jílibasi</b> - ???? (Mandarin Chinese variant), <b>Khiribat</b> - ??????? (Thai), <b>Kiribasa</b> - ??????? (Bengali), <b>Kiribasi</b> / <b>K'iribasi</b> - ???? (Korean), <b>Kiribasu</b> - ???? (Japanese), <b>Kiribati</b> (Acehnese, Afrikaans, Aragonese, Asturian, Azeri, Central Bikolano, Czech, Danish, Dutch, Estonian, Faroese, Finnish, Franco-Provençal, French, German, Hungarian, Italian, Latvian, Maltese, Min Nan, Norwegian, Polish, Portuguese variant, Romanian, Slovene, Spanish, Swedish, Turkish, Võro), <b>Kiribati</b> - ???????? (Arabic), <b>Kiribati</b> - <i>????????</i> (Bulgarian, Russian, Serbian), <b>Kiribati</b> - ??????? (Hebrew), <b>Ki-ri-ba-ti</b> - ??????????? (Tibetan), <b>Kiribatis</b> (Lithuanian), <b>Kiribato</b> (Esperanto), <b>Kirimpáti</b> - <i>????µp?t?</i> (Greek), <b>Kiripasi</b> (Inuktitut), <b>Kirybati</b> - <i>????????</i> (Ukrainian), <b>Kirybatsi</b> - <i>????????</i> (Belarusian), <b>Quiribati</b> (Portuguese)</td>
</tr>
<tr>
<td><a href=""/wiki/Korea"" title=""Korea"">Korea</a></td>
<td><b>Chaoxian</b> - ?? / ?? (Chinese - usually North Korea), <b>Choson</b> - ?? (Korean - North Korea), <b>Coiria</b> (Scots Gaelic), <b>Corea</b> (Asturian, Galician, Italian, Spanish, Welsh), <b>Corée</b> (French), <b>Coréia</b> (Brazilian Portuguese), <b>Coreia</b> (European Portuguese), <b>Hanguk</b> / <b>Han'guk</b> - ?? (Korean - South Korea), <b>Hánguó</b> - ?? / ?? (Chinese - usually South Korea), <b>Hân-kok</b> (Min Nan), <b>Hàn Qu?c</b> or <b>Nam Tri?u Tiên</b> (Vietnamese), <b>Kankoku</b> - ?? or <b>Daikanminkoku</b> - ???? (Japanese - South Korea), <b>Kaoli</b> - ?????? (Thai), <b>Kita-Chosen</b> - ??? or <b>Chosen Minshushugi Jinmin Kyowakoku</b> - ??????????? (Japanese - North Korea), <b>Kore</b> - ??? (Persian), <b>Kore</b> (Turkish), <b>Korea</b> (Afrikaans, Basque, Breton, Czech, Danish, Dutch, Estonian, Faroese, Filipino/Tagalog, Finnish, German, Hungarian, Indonesian, Javanese, Malay, Maltese, Norwegian, Polish, Swahili, Swedish, Võro), <b>Korea</b> - ????? (Armenian), <b>Koréa</b> - <i>????a</i> (Greek), <b>Korea</b> - ?????? (Hebrew), <b>Korei</b> - <i>?????</i> (Ossetic), <b>Koreio</b> (Esperanto), <b>Koreja</b> (Bosnian, Croatian, Latvian, Slovene), <b>Kòreja</b> (Kashubian), <b>Koreja</b> (Lithuanian), <b>Koreja</b> - <i>??????</i> (Serbian), <b>Koreya</b> - <i>?????</i> (Bulgarian, Russian, Ukrainian), <b>Koriya</b> - ?????? (Hindi), , <b>Coreea</b> (Romanian), <b>Kuria</b> (Inuktitut), <b>Solongos</b> - <i>????????</i> (Mongolian)<br />
<small>Note: In East Asian languages, ?? normally refers to North Korea and ?? to South Korea, but expressions along the lines of <b>Nán Chaoxian</b> (???) for South Korea and <b>Bei Hán</b> (??) for North Korea are also found in Chinese. Vietnamese also uses Nam Tri?u Tiên for South Korea. See also <a href=""/wiki/Names_of_Korea"" title=""Names of Korea"">Names of Korea</a>.</small><br /></td>
<td></td>
</tr>
<tr>
<td><a href=""/wiki/Kuwait"" title=""Kuwait"">Kuwait</a></td>
<td><b>Coveite</b> (Portuguese variant), <b>Cuibhèit"" (Scots Gaelic),</b> Keweitè <b>- ??? (Mandarin Chinese),</b> Khuwet <b>- ????? (Thai),</b> Khu-wi-thi <b>- ????????? (Tibetan),</b> Koeweit <b>(Afrikaans, Dutch),</b> Kouvéit <b>- <i>???ß??t</i> (Greek),</b> Koveyit <b>(Franco-Provençal),</b> Koweït <b>(French),</b> Koweit <b>(Portuguese),</b> Kuvaat <b>(Inuktitut),</b> Kuvait <b>(Hungarian),</b> Kuvajt <b>(Czech, Slovene),</b> Kuvajt <b>- <i>??????</i> (Serbian),</b> Kuvajto <b>(Esperanto),</b> Kuveit <b>- <i>??????</i> (Belarusian),</b> Kuveit <b>(Estonian, Võro),</b> Kuveit <b>- ????? (Hebrew),</b> Kuveita <b>(Latvian),</b> Kuveitas <b>(Lithuanian),</b> Kuveiti <b>- ??????? (Georgian),</b> Küveyt <b>(Azeri),</b> Kuveyt <b>- <i>??????</i> (Bulgarian, Russian, Ukrainian),</b> Kuveyt <b>(Turkish),</b> Kuwait <b>(Acehnese, Alemannic, Aragonese, Asturian, Central Bikolano, Danish, Dutch, German, Finnish, Indonesian, Italian, Malay, Min Nan, Norwegian, Portuguese variant, Spanish, Swedish),</b> Kuwajt <b>(Maltese),</b> al-Kuwayt <b>- ?????? (Arabic),</b> Kuweiteu <b>/</b> K'uweit'u <b>- ???? (Korean),</b> Kuwejt <b>(Polish),</b> Kuweto <b>- ????? (Japanese),</b> Ku?eta <b>- ?????? (Bengali),</b> Quveit <b>- ??????? (Armenian),</b> Kuweit <b>(Romanian)</b></td>
</tr>
<tr>
<td><a href=""/wiki/Kyrgyzstan"" title=""Kyrgyzstan"">Kyrgyzstan</a></td>
<td><b>Chirgisia</b> (Latin), <b>Ciorgastan</b> (Scots Gaelic), <b>Cirgistan</b> (Welsh alternative), <b>Cyrgystan</b> (Welsh), <b>Gherghizestan</b> - ????????? (Persian), <b>Ghrghstan</b> - ??????? (Armenian), <b>Jí'erjísi</b> - ????/???? (Mandarin Chinese variant), <b>Jí'erjísisitan</b> - ??????/?????? (Mandarin Chinese), <b>Khirkit</b> - ??????? (Thai), <b>Kiragijistana</b> - ???????????? (Assamese), <b>Kiragijistana</b> - ???????????? (Bengali), <b>Kireugiseuseutan</b> / <b>K'irugisusut'an</b> - ?????? (Korean), <b>Kirghizia</b> (English variant, Italian variant), <b>Kirghizistan</b> (French, Italian), <b>Kirghizistán</b> - <i>???????st??</i> (Greek), <b>Kirgisia</b> (Faroese, Finnish), <b>Kirgisië</b> (Afrikaans), <b>Kirgisien</b> (Danish variant), <b>Kirgisistan</b> (Alemannic, Danish, German, Norwegian), <b>Kirgistan</b> (Croatian, Danish variant, former Finnish, Indonesian, Polish), <b>Kirgistan</b> - <i>?????????</i> or <b>Kirgizija</b> - <i>?????????</i> (Serbian), <b>Kirgistani</b> (Albanian), <b>Kirgizië</b> (Dutch), <b>Kirgizija</b> (Lithuanian, Slovene variant), <b>Kirgizio</b> (Esperanto), <b>Kirgizistan</b> (Slovene, Swedish), <b>Kirgizistan</b> (Turkish), <b>Kirgizisztán</b> (Hungarian), <b>Kirgizsko</b> (Slovak), <b>Kirgizstan</b> - <i>??????????</i> (Bulgarian), <b>Kirgizstana</b> (Latvian), <b>Kirgiztan</b> (Acehnese), <b>Kirguistán</b> (Asturian), <b>Kirguistán</b>, <b>Kirguizistán</b> or <b>Kirguisia</b> (Spanish), <b>Kirguizistan</b> (Franco-Provençal), <b>Kirjistan</b> - ????'???? (Hebrew), <b>Kirugisu</b> - ???? (Japanese), <b>Kõrgõstan</b> (Võro), <b>Kõrgõzstan</b> (Estonian), <b>Kyrgyzstán</b> (Czech), <b>Kyrgyzstan</b> - <i>??????????</i> (Kirghiz, Russian), <b>Kyrgyzstan</b> - <i>??????????</i> (Ukrainian), <b>Kyrgyzstan</b> (Min Nan), <b>Qirghizstan</b> - ????????? (Arabic), <b>Qirgizeti</b> - ????????? (Georgian), <b>Qirgizistan</b> (Azeri), <b>Qirugisitan</b> (Inuktitut), <b>Quirguisistán</b> (Aragonese), <b>Quirguistão</b> (Portuguese variant), <b>Quirguízia</b> (Portuguese variant), <b>Quirguizistão</b> (Portuguese variant), <b>Qyrghythstan</b> - <i>??????????</i> (Bashkir), <b>,</b> Kîrgîzstan <b>or <i>Republica Kîrgîza</i> (Romanian)</b></td>
</tr>
</table>
<h2><span class=""editsection"">[<a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit&amp;section=3"" title=""Edit section: L"">edit</a>]</span> <span class=""mw-headline"" id=""L"">L</span></h2>
<table border=""1"" cellspacing=""0"" cellpadding=""3"">
<tr>
<th><b>English Name</b></th>
<th><b>Other name(s) or older name(s)</b></th>
</tr>
<tr>
<td><a href=""/wiki/Laos"" title=""Laos"">Laos</a></td>
<td><b>Lao</b> - ??? (Lao), <b>Lao</b> - ??? (Thai), <b>Lào</b> (Vietnamese), <b>Lao-kok</b> (Min Nan), <b>Laos</b> (Acehnese, Afrikaans, Alemannic, Aragonese, Asturian, Azeri, Central Bikolano, Czech, Danish, Dutch, Estonian, Faroese, Finnish, Franco-Provençal, French, German, Indonesian, Italian, Malay, Maltese, Polish, Portuguese, Romanian, Slovene, Spanish, Turkish), <b>Làos</b> (Scots Gaelic), <b>Laos</b> - ???? (Armenian), <b>Laos</b> - <i>????</i> (Belarusian, Bulgarian, Russian, Serbian, Ukrainian), <b>Láos</b> - <i>????</i> (Greek), <b>Laos</b> - ???? (Hebrew), <b>Laos</b> - ????? (Persian), <b>Laosa</b> - ???? (Bengali), <b>Laosa</b> (Latvian), <b>Laosas</b> (Lithuanian), <b>Laoso</b> (Esperanto), <b>Laosz</b> (Hungarian), <b>Laowo</b> - ?? (Mandarin Chinese), <b>Lausi</b> (Inuktitut), <b>Liáoguó</b> - ?? (Mandarin Chinese - Taiwan), <b>Raoseu</b> / <b>Raosu</b> - ??? (Korean), <b>Raosu</b> - ??? (Japanese)</td>
</tr>
<tr>
<td><a href=""/wiki/Latvia"" title=""Latvia"">Latvia</a></td>
<td><b>Laitbhia</b> (Scots Gaelic alternative), <b>an Laitvia</b> (Irish), <b>Latbhia</b> (Scots Gaelic), <b>Latfia</b> (Welsh), <b>Läti</b> (Estonian, Võro), <b>Latuowéiyà</b> - ????/???? (Mandarin Chinese), <b>Latupia</b> (Inuktitut), <b>Latvia</b> (Acehnese, Finnish, Malay, Min Nan, Norwegian), <b>Latvia</b> - ?????? (Armenian), <b>Látvia</b> - <i>??tß?a</i> (Greek variant), <b>Latvija</b> (Latvian, Lithuanian, Slovene), <b>Latvio</b> (Esperanto), <b>Latviya</b> ???? (Amharic), <b>Latviya</b> (Azeri), <b>Latviya</b> - <i>??????</i> (Belarusian, Ukrainian), <b>Latviya</b> - <i>??????</i> (Bulgarian, Russian), <b>Latviya</b> - ????? (Hebrew), <b>Latvja</b> (Maltese), <b>Latwia</b> - ??????? (Thai), <b>Letland</b> (Afrikaans, Danish, Dutch, Norwegian alternate), <b>Letland</b> - ???????? (Yiddish), <b>Letoña</b> (Guaraní), <b>Letonia</b> (Albanian, Aragonese, Aromanian, Asturian, Basque, Romanian, Spanish), <b>Letônia</b> (Brazilian Portuguese), <b>Letònia</b> (Catalan), <b>Letonía</b> - <i>?ett???a</i> (Greek), <b>Letónia</b> (European Portuguese), <b>Lètonie</b> (Franco-Provençal), <b>Letonija</b> - <i>????????</i> (Macedonian, Serbian), <b>Letonya</b> (Turkish), <b>Lettland</b> (Alemannic, Faroese, German, Icelandic, Low Saxon, Norwegian alternate, Swedish), <b>Lettonia</b> (Italian, Latin, Romansh), <b>Lettonie</b> (French), <b>Lettország</b> (Hungarian), <b>Lotwa</b> (Polish), <b>Lotyšsko</b> (Czech, Slovak), <b>Rateubia</b> / <b>Rat'ubia</b> - ???? (Korean), <b>Ratobia</b> - ???? (Japanese)</td>
</tr>
<tr>
<td><a href=""/wiki/Lebanon"" title=""Lebanon"">Lebanon</a></td>
<td><b>Leabanon</b> (Scots Gaelic), <b>Lebanana</b> - ?????? (Bengali), <b>Lebanon</b> (Acehnese, Central Bikolano, Indonesian), <b>Lebanon</b> - ??????? (Thai), <b>Le-pa-nona</b> ????????? (Tibetan), <b>Levanon</b> - ????? (Hebrew), <b>Levonon</b> - ?????? (Yiddish), <b>Liban</b> - <i>?????</i> (Belarusian), <b>Liban</b> (Franco-Provençal, French, Polish, Romanian), <b>Liban</b> - <i>?????</i> (Macedonian, Serbian), <b>Libana</b> (Latvian), <b>Libanan</b> - ??????? (Armenian), <b>Libanas</b> (Lithuanian), <b>Líbanèn</b> - ??? (Mandarin Chinese), <b>Libani</b> (Albanian), <b>Libani</b> - ?????? (Georgian), <b>Libano</b> (Aragonese, Esperanto, Italian), <b>Líbano</b> (Asturian, Portuguese, Spanish), <b>Libanon</b> (Afrikaans, Alemannic, Czech, Danish, Dutch, Faroese, Finnish, German, Hungarian, Indonesian alternate, Norwegian, Romansh, Slovak, Slovene, Swedish), <b>Líbanon</b> - (Icelandic), <b>Libanu</b> (Maltese), <b>Libanus</b> (Latin, Welsh), <b>Liibanon</b> (Estonian, Võro), <b>an Liobáin</b> (Irish), <b>Li-pa-lùn</b> (Min Nan), <b>Lipanun</b> (Inuktitut), <b>Livan</b> (Azeri alternate), <b>Livan</b> - <i>???a?</i> (Bulgarian, Russian, Ukrainian), <b>Lívanos</b> - <i>??ßa???</i> (Greek), <b>Lubnan</b> - ????? (Arabic), <b>Lübnan</b> (Azeri, Turkish), <b>Lubnan</b> (Malay), <b>Rebanon</b> - ???? (Japanese), <b>Rebanon</b> - ??? (Korean)</td>
</tr>
<tr>
<td><a href=""/wiki/Lesotho"" title=""Lesotho"">Lesotho</a></td>
<td><b>Láisuotuo</b> - ???/??? (Mandarin Chinese), <b>Lesota</b> - <i>??????</i> (Belarusian), <b>Lesotas</b> (Lithuanian), <b>Lesotho</b> (Acehnese, Afrikaans, Alemannic, Asturian, Breton, Catalan, Cebuano, Czech, Danish, Dutch, Estonian, Finnish, French, German, Italian, Min Nan, Polish, Romanian, Spanish variant, Welsh), <b>Lesotho</b> - ?????? (Bengali), <b>Lesothô</b> (Franco-Provençal), <b>Lesótho</b> - <i>?es???</i> (Greek), <b>Lesotho</b> - ?????? (Thai), <b>Le-so-tho</b> - ????????? (Tibetan), <b>Lésoto</b> - ??? (Amharic), <b>Lesoto</b> (Aragonese, Azeri, Bambara, Bosnian, Central Bikolano, Esperanto, Faroese, Latvian, Maltese, Polish variant, Portuguese, Scots Gaelic, Slovene, Spanish variant), <b>Lesoto</b> - <i>??????</i> (Bulgarian, Chuvash, Russian, Serbian, Ukrainian), <b>Lesoto</b> - ?????? (Divehi), <b>Lesoto</b> - ????? (Hebrew), <b>Lesótó</b> (Icelandic), <b>Lisusu</b> (Inuktitut), <b>Resoto</b> - ??? (Japanese), <b>Resoto</b> / <b>Resot'o</b> - ??? (Korean)</td>
</tr>
<tr>
<td><a href=""/wiki/Liberia"" title=""Liberia"">Liberia</a></td>
<td><b>Laiberi?a</b> - ?????????? (Bengali), <b>Laibiria</b> - ???????? (Thai), <b>Laybériya</b> - ????? (Amharic), <b>Libeeria</b> (Estonian), <b>Libeeriä</b> (Võro), <b>Libèiria</b> (Scots Gaelic), <b>Liberia</b> (Acehnese, Alemannic, Aragonese, Asturian, Bambara, Danish, Dutch, Faroese, Finnish, French, German, Italian, Min Nan, Polish, Romanian, Spanish), <b>Liberia</b> - ??????? (Armenian), <b>Libèria</b> (Franco-Provençal), <b>Liberia</b> - ?????? (Hebrew), <b>Libéria</b> (Hungarian, Portuguese), <b>Liberië</b> (Afrikaans), <b>Libérie</b> (Czech), <b>Liberija</b> (Latvian), <b>Liberija</b> (Lithuanian, Slovene), <b>Liberija</b> - <i>????????</i> (Serbian), <b>Liberio</b> (Esperanto), <b>Liberiya</b> (Azeri), <b>Liberiya</b> - <i>???????</i> (Bulgarian, Russian, Ukrainian), <i><b>Liberja</b> (Maltese), <b>Liberya</b> (Turkish), <b>Lìbiliyà</b> - ????/???? (Mandarin Chinese), <b>Lipiria</b> (Inuktitut), <b>Livería</b> -</i> ??ße??a <i>(Greek), <b>Raiberia</b> - ????? (Korean), <b>Riberia</b> - ???? (Japanese)</i></td>
</tr>
<tr>
<td><a href=""/wiki/Libya"" title=""Libya"">Libya</a></td>
<td><b>Libia</b> (Albanian, Aragonese, Aromanian, Asturian, Basque, Catalan, Italian, Polish, Romanian, Romansh, Scots Gaelic, Spanish, Welsh), <b>Libia</b> - ????? (Armenian), <b>Líbia</b> (Hungarian, Portuguese), <b>an Libia</b> (Irish), <b>Libia</b> - ?????? (Thai), <b>Libië</b> (Afrikaans, Dutch), <b>Libie</b> (Franco-Provençal), <b>Libija</b> (Latvian), <b>Libija</b> (Lithuanian, Slovene), <b>Libija</b> - <i>??????</i> (Serbian), <b>Libio</b> (Esperanto), <b>Libiya</b> - ??? (Amharic), <b>Libi?a</b> - ??????? (Bengali), <b>Libiya</b> - <i>?????</i> (Bulgarian), <b>Lìbiyà</b> - ???/??? (Mandarin Chinese), <b>Libja</b> (Maltese), <b>Libya</b> (Acehnese, Bambara, Faroese, Finnish, Latin, Turkish), <b>Líbya</b> (Slovak), <b>Libye</b> (Alemannic, Czech, French), <b>Libyen</b> (Danish, German, Swedish), <b>Liibüa</b> (Estonian), <b>Liibüä</b> (Võro), <b>Lipia</b> (Inuktitut), <b>Liviya</b> (Azeri), <b>Liviya</b> - <i>?????</i> (Russian, Ukrainian), <b>Livýi</b> - <i>??ß??</i> (Greek), <b>Luv</b> - ??? (Hebrew), <b>Ribia</b> - ??? (Japanese), <b>Ribia</b> - ??? (Korean)</td>
</tr>
<tr>
<td><a href=""/wiki/Liechtenstein"" title=""Liechtenstein"">Liechtenstein</a></td>
<td><b>Liachtaschta</b> (Alemannic), <b>Liachtnstoa</b> (Austro-Bavarian), <b>Lichtenshtein</b> - ??????????? (Armenian), <b>Lichtenshtein</b> - ?????????? (Hebrew), <b>Líchtenstain</b> - <i>???te?sta??</i> (Greek), <b>Lichtenštajnsko</b> (Slovak), <b>Lichtenstein</b> (Indonesian alternate), <b>Lichtenšteinas</b> (Lithuanian), <b>Lichtenštejnsko</b> (Czech), <b>Lichtenstenum</b> (Latin), <b>Liechtenstein</b> (Acehnese, Afrikaans, Aragonese, Asturian, Breton, Danish, Dutch, Estonian, Finnish, Franco-Provençal, French, German, Icelandic, Italian, Maltese, Min Nan, Norwegian, Polish, Portuguese, Romanian, Scots Gaelic, Spanish, Swedish, Võro, Welsh), <b>Lièzhidunshìdeng</b> - ????? (Mandarin Chinese), <b>Lièzhidunsideng</b> - ????? (Mandarin Chinese variant), <b>Lihtenshtajn</b> (Albanian), <b>Lihtenshtayn</b> - <i>??????????</i> (Bulgarian), <b>Lihtenštajn</b> (Bosnian, Croatian, Slovene), <b>Lihtenštajn</b> - <i>???????????</i> (Serbian), <b>Lihtenstayn</b> (Turkish), <b>Lihtenšteina</b> (Latvian), <b>Lihtenstejno</b> (Esperanto), <b>Likhtenshteyn</b> - <i>???????????</i> (Russian), <b>Likhtenshteyn</b> - <i>???????????</i> (Ukrainian), <b>Liktenstain</b> - ??????????? (Thai), <b>Liktinstein</b> (Faroese), <b>Lisitinsutain</b> (Inuktitut), <b>Listenstaina</b> (Brazilian Portuguese variant), <b>Listenstaine</b> (Portuguese variant), <b>Lixtensteyn</b> (Azeri), <b>Rihitenshutain</b> - ????????? (Japanese), <b>Rihitensyutain</b> / <b>Rihit'ensyut'ain</b> - ?????? (Korean)</td>
</tr>
<tr>
<td><a href=""/wiki/Lithuania"" title=""Lithuania"">Lithuania</a></td>
<td><b>Leedu</b> (Estonian, Võro), <b>Liettua</b> (Finnish), <b>Lietuva</b> (Latvian, Lithuanian, Min Nan), <b>an Liotuáin</b> (Irish), <b>Lita</b> - ????,???? (Hebrew), <b>Lìtáowan</b> - ??? (Mandarin Chinese), <b>Litaue</b> (Afrikaans, Alemannic), <b>Litauen</b> (Danish, German, Low Saxon, Norwegian, Swedish), <b>Litava</b> (Faroese), <b>Litawska</b> (Lower Sorbian), <b>Lite</b> - ???? (Yiddish), <b>Litháen</b> (Icelandic), <b>Lithouanía</b> - <i>?????a??a</i> (Greek), <b>Lithuania</b> (Acehnese), <b>Lithuania</b> - ????????? (Thai), <b>Lithwania</b> (Welsh), <b>Litouwen</b> (Dutch), <b>Litovio</b> (Esperanto), <b>Lituàinia</b> (Scots Gaelic), <b>Lituaña</b> (Aymara, Guaraní), <b>Lituania</b> (Albanian, Aragonese, Asturian, Basque, Inuktitut, Italian, Latin, Romanian, Romansh, Spanish), <b>Lituània</b> (Catalan), <b>Lituânia</b> (Portuguese), <b>Lituanie</b> (Franco-Provençal, French), <b>Lituanie</b> - ??????? (Persian), <b>Litva</b> - ????? (Armenian), <b>Litva</b> (Aromanian, Azeri, Czech, Slovak, Slovene), <b>Litva</b> - <i>?????</i> (Belarusian), <b>Litva</b> - <i>?????</i> (Bulgarian, Russian, Ukrainian), <b>Litvánia</b> (Hungarian), <b>Litvanija</b> - <i>?????????</i> (Serbian), <b>Litvanya</b> (Turkish), <b>Litwa</b> (Polish), <b>Litwaniya</b> (Filipino/Tagalog), <b>Litwanja</b> (Maltese), <b>Lytva</b> - <i>?????</i> (Ukrainian), <b>Ritoania</b> - ????? (Japanese), <b>Rituania</b> / <b>Rit'uania</b> - ????? (Korean)</td>
</tr>
<tr>
<td><a href=""/wiki/Luxembourg"" title=""Luxembourg"">Luxembourg</a></td>
<td><b>Laksembirk</b> - ???????????? (Thai), <b>Lëtzebuerg</b> (Luxembourgish), <b>Liuksemburgas</b> (Lithuanian), <b>Ljuksemburh</b> - <i>???ce???p?</i> (Ukrainian), <b>Louxemvoúrgo</b> - <i>????eµß?????</i> (Greek), <b>Lucembursko</b> (Czech), <b>Lucsamburg</b> (Irish, Scots Gaelic), <b>L?c Xâm B?o</b> (Vietnamese), <b>Lugsamburg</b> (Scots Gaelic variant), <b>Luhemburgo</b> (Central Bikolano), <b>Luksemboarch</b> (Frisian), <b>Luksèmburg</b> (Acehnese), <b>Luksemburg</b> (Croatian, Estonian, Faroese, Indonesian, Macedonian, Polish, Slovene), <b>Luksemburg</b> - <i>??????????</i> (Serbian), <b>Lüksemburg</b> (Turkish), <b>Luksemburga</b> (Latvian), <b>Luksemburgo</b> (Esperanto), <b>Lüksemburq</b> (Azeri), <b>Luksenburgu</b> (Albanian), <b>Luksimpuuku</b> (Inuktitut), <b>Luksõmburk</b> (Võro), <b>Lukzamburg</b> - ?????????? (Persian), <b>Lusemburgo</b> (Aragonese), <b>Lúsenbao</b> - ???/??? (Mandarin Chinese), <b>Lussemburgo</b> (Italian), <b>Lussemburgu</b> (Maltese), <b>Lussimbork</b> (Walloon), <b>Lussimbourq</b> (Picard) , <b>Luxeburi</b> (Alemannic), <b>Luxemborg</b> (Danish variant), <b>Luxembôrg</b> (Franco-Provençal), <b>Lúxemborg</b> (Icelandic), <b>Luxembourg</b> (Danish, French, Min Nan, Norwegian), <b>Luxemburg</b> (Afrikaans, Aromanian, Basque variant, Catalan, Danish variant, Dutch, English variant, Finnish, German, Hungarian, Indonesian variant, Romanian, Romansh, Swedish), <b>Luxemburg</b> - ????????? (Hebrew), <b>Luxemburgia</b> (Latin variant), <b>Luxemburgo</b> (Guaraní, Portuguese, Spanish), <b>Luxemburgu</b> (Asturian), <b>Luxemburgum</b> (Latin), <b>Luxembursko</b> (Slovak), <b>Luxenburgo</b> (Basque), <b>Lwcsembwrg</b> (Welsh), <b>Lyuksemburg</b> - ????????????? (Armenian), <b>Lyuksemburg</b> - <i>???ce???p?</i> (Bulgarian, Russian), <b>Ruksembureukeu</b> / <b>Ruksemburuk'u</b> - ????? (Korean), <b>Rukusenburuku</b> - ??????? (Japanese)</td>
</tr>
</table>
<h2><span class=""editsection"">[<a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit&amp;section=4"" title=""Edit section: M"">edit</a>]</span> <span class=""mw-headline"" id=""M"">M</span></h2>
<table border=""1"" cellspacing=""0"" cellpadding=""3"">
<tr>
<th><b>English Name</b></th>
<th><b>Other name(s) or older name(s)</b></th>
</tr>
<tr>
<td><a href=""/wiki/Macau"" title=""Macau"">Macau</a></td>
<td><b>Aomen</b> (Estonian), <b>Àomén</b> - ?? (Mandarin Chinese), <b>Áo Môn</b> (Vietnamese), <b>Macao</b> (Austro-Bavarian, Czech, Finnish, Spanish, Polish variant, Romanian), <b>Macau</b> (Acehnese, Afrikaans, Aragonese, Catalan, Central Bikolano, Estonian alternate, Indonesian alternate, Portuguese, Scots Gaelic), <b>Makao</b> - <i>?????</i> (Belarusian, Bulgarian, Serbian, Ukrainian), <b>Makao</b> (Bosnian, Breton, Latvian, Lithuanian), <b>Makao</b> - ??? (Japanese), <b>Makao</b> / <b>Mak'ao</b> - ??? (Korean), <b>Makao</b> - ?????? (Thai), <b>Makau</b> (Faroese, Inuktitut), <b>Makáu</b> - <i>?a????</i> (Greek), <b>Makau</b> - ???? (Hebrew), <b>Makau</b> (Indonesian, Polish), <b>Makáw</b> (Filipino), <b>Ò-mn^g</b> (Min Nan)</td>
</tr>
<tr>
<td><a href=""/wiki/Republic_of_Macedonia"" title=""Republic of Macedonia"">Macedonia</a></td>
<td><b>Macédoine</b> (French), <b>Macedônia</b> (Brazilian Portuguese), <b>Macedonia</b> (Aragonese, Asturian, Italian, Latin, Polish, Romanian, Spanish, Welsh), <b>Macedònia</b> (Catalan), <b>Macedónia</b> (Hungarian, European Portuguese), <b>Macedonië</b> (Dutch), <b>Macèdonie</b> (Franco-Provençal), <b>Macedonja</b> (Maltese), <b>Macedónsko</b> (Slovak), <b>Machedonia</b> (Aromanian), <b>Maghdounieh</b> - ??????? (Persian), <b>Makedonia</b> – ????????? (Armenian), <b>Makedónia</b> (Faroese), <b>Makedonia</b> (Finnish, Indonesian, Norwegian), <b>Makedonia</b> - ??????? (Hebrew), <b>Makedónía</b> (Icelandic), <b>Makedonia</b> - ????? (Japanese), <b>Makedonia</b> / <b>Mak'edonia</b> - ????? (Korean), <b>Makedonie</b> (Czech), <b>Makedonien</b> (Danish, Swedish), <b>Makedonija</b> (Latvian), <b>Makedonija</b> (Lithuanian, Min Nan, Slovene), <b>Makedonija</b> - <i>??????????</i> (Macedonian, Serbian), <b>Makedonio</b> (Esperanto), <b>Makedoniya</b> (Azeri), <b>Makedoniya</b> - <i>?????????</i> (Bulgarian, Russian), <b>Makedoniya</b> - <i>?????????</i> (Ukrainian), <b>Makedonya</b> (Turkish), <b>Makedoonia</b> (Estonian), <b>Makitunia</b> (Inuktitut), <b>Makõdoonia</b> (Võro), <b>Maqedoni</b> (Albanian), <b>Maqídùn</b> - ???/??? (Mandarin Chinese), <b>Masadòinia</b> (Scots Gaelic), <b>Masèdonia</b> (Acehnese), <b>Masedonië</b> (Afrikaans), <b>Masedonya</b> (Central Bikolano, Filipino), <b>Masendoña</b> (Guaraní), <b>Masidonia</b> - ?????????? (Thai), <b>Mazedonia</b> (Basque), <b>Mazedonie</b> (Alemannic), <b>Mazedonien</b> (German, Low Saxon), <b>an Mhacadóin</b> (Irish), <b>Proén Yugoslaviki Democratia tis Macedonias</b> – <i>p???? G??????s?aß??? ??µ???at?a t?? ?a?ed???a?</i> (Greek <small>[Former Yugoslav Republic of Macedonia, where Macedonia refers to the historical area of the ancient Hellenic Kingdom of Macedonia]</small>)<br />
<small>Note: The use of the name ""Macedonia"" is disputed by <a href=""/wiki/Greece"" title=""Greece"">Greece</a>. Local translations of the provisional appellation <i>Former Yugoslav Republic of Macedonia</i> are common in several languages.</small><br /></td>
</tr>
<tr>
<td><a href=""/wiki/Madagascar"" title=""Madagascar"">Madagascar</a></td>
<td><b>Madagascar</b> (Aragonese, Asturian, Brazilian Portuguese, French, Italian, Romanian, Scots Gaelic, Spanish), <b>Madagascâr</b> (Franco-Provençal), <b>Madagáscar</b> (Portuguese), <b>Madagascaria</b> (Latin), <b>Madagaseukareu</b> / <b>Madagasuk'aru</b> - ?????? (Korean), <b>Madagasgar</b> (Scots Gaelic variant), <b>Madagasikara</b> (Malagasy, Min Nan), <b>Madagaskar</b> (Afrikaans, Alemannic, Bambara, Breton, Bosnian, Central Bikolano, Czech, Danish, Dutch, Estonian, Faroese, Finnish, Filipino/Tagalog, German, Icelandic, Indonesian, Norwegian, Polish, Slovak, Slovene, Swedish, Turkish, Võro), <b>Madagaskar</b> - ?????????? (Armenian), <b>Madagaskar</b> - <i>??????????</i> (Bulgarian, Russian, Serbian, Ukrainian), <b>Madagaskara</b> (Latvian), <b>Madagaskaras</b> (Lithuanian), <b>Madagaskári</b> - <i>?ada?as????</i> (Greek), <b>Madagaskaro</b> (Esperanto), <b>Madagasskar</b> (Maltese) <b>Madagasukaru</b> - ?????? (Japanese), <b>Madagaszkár</b> (Hungarian), <b>Madájiasijia</b> - ?????/????? (Mandarin Chinese), <b>Madakaska</b> - ??????????? (Thai), <b>Madaqaskar</b> (Azeri), <b>Madegaskar</b> - ?????? (Hebrew), <b>Malagasi</b> (Indonesian variant), <b>Malagaskar</b> (Filipino alternate), <b>Malagasy</b> (Indonesian variant), <b>Matagasuqaru</b> (Inuktitut)</td>
</tr>
<tr>
<td><a href=""/wiki/Malawi"" title=""Malawi"">Malawi</a></td>
<td><b>Maláoui</b> - <i>?a?????</i> (Greek), <b>Malaui</b> (Asturian, Inuktitut, Portuguese, Scots Gaelic), <b>Maláui</b> or <b>Malauí</b> (Portuguese variants), <b>Malavi</b> (Azeri, Bosnian, Faroese, Franco-Provençal, Portuguese variant, Slovene, Turkish), <b>Malavi</b> - <i>??????</i> (Bulgarian, Russian, Serbian, Ukrainian),<b>Malávia</b> (Portuguese variant), <b>Malavija</b> (Latvian), <b>Malavio</b> (Esperanto), <b>Malavis</b> (Lithuanian), <b>Malawéi</b> - ???/??? (Mandarin Chinese), <b>Malawei</b> - ???/??? (Mandarin Chinese variant), <b>Malawi</b> (Afrikaans, Alemannic, Aragonese, Bambara, Breton, Catalan, Czech, Danish, Dutch, Estonian, Filipino, Finnish, French, German, Indonesian, Italian, Malay, Maltese, Polish, Portuguese, Romanian, Spanish, Turkish variant), <b>Malawi</b> (Chichewa, Min Nan), <b>Malawi</b> - ?????? (Hebrew), <b>Malawi</b> - ?????? (Thai), <b>Mallawi</b> - ??? (Korean), <b>Maraui</b> - ???? (Japanese)</td>
</tr>
<tr>
<td><a href=""/wiki/Malaysia"" title=""Malaysia"">Malaysia</a></td>
<td><b>Dàma</b> - ??/?? (Mandarin Chinese, informal), <b>Malaesia</b> (Latin), <b>Malaezia</b> (Romanian), <b>Mã Lai</b> or <b>Mã Lai Á</b> (Vietnamese), <b>Má-lâi-se-a</b> (Min Nan), <b>Malaisia</b> (Aragonese, Estonian, Inuktitut, Võro), <b>Malaísia</b> (Brazilian Portuguese), <b>Malaisía</b> - <i>?a?a?s?a</i> (Greek), <b>Malaisie</b> (French), <b>Maláixiyà</b> - ????/???? (Mandarin Chinese), <b>Malaizija</b> (Latvian, Lithuanian), <b>Malajsie</b> (Czech), <b>Malajzia</b> (Hungarian, Slovak), <b>Malajzio</b> (Esperanto), <b>Malasia</b> (Asturian, Guarani, Spanish), <b>Malasía</b> - (Icelandic), <b>Malásia</b> (Portuguese), <b>Malasja</b> (Maltese), <b>Malasya</b> (Central Bikolano), <b>Malaya</b> (Filipino), <b>Malaysia</b> (Acehnese, Alemannic, Banyumasan, Danish, German, Indonesian, Italian, Malay, Swedish), <b>Malayziya</b> (Azeri), <b>Malayziya</b> - <i>????????</i> (Bulgarian, Russian), <b>Malayziya</b> - <i>????????</i> (Ukrainian), <b>Malayzye</b> - ????????? (Yiddish), <b>Malazia</b> - ??????? (Armenian), <b>Maleciya</b> - ??????? (Tamil), <b>Maleisia</b> (Faroese), <b>Malèisia</b> (Scots Gaelic), <b>Maleisië</b> (Afrikaans, Dutch), <b>Malesia</b> (Finnish, Italian variant), <b>Malesia</b> - ???????? (Thai), <b>Malèsie</b> (Franco-Provençal), <b>Malezi</b> - ????? (Persian), <b>Malezija</b> (Bosnian, Croatian, Slovene), <b>Malezija</b> - <i>????????</i> (Serbian), <b>Maleziya</b> - ????? (Hebrew), <b>Malezja</b> (Polish, Slovene), <b>Malezya</b> (Turkish), <b>Maliziya</b> - ??????? (Arabic), <b>Malleisia</b> - ????? (Korean), <b>Mareshia</b> - ????? (Japanese)</td>
</tr>
<tr>
<td><a href=""/wiki/Maldives"" title=""Maldives"">Maldives</a></td>
<td><b>Eiyim maldivim</b> - ???? ??????? (Hebrew), <b>Ma'erdàifu</b> - ????/???? (Mandarin Chinese - PRC), <b>Ma'erdìfu</b> - ????/???? (Mandarin Chinese - Taiwan), <b>Maladewa</b> (Acehnese, Indonesian), <b>Maldibas</b> (Central Bikolano), <b>Maldifs</b> (Welsh), <b>Maldiivid</b> (Estonian), <b>Maldiiviq</b> (Võro), <b>Maldip</b> - ???????? (Thai), <b>Maldiv adalari</b> (Azeri), <b>Maldivas</b> (Aragonese, Portuguese, Spanish), <b>Maldive</b> (Italian, Romanian), <b>Maldiven</b> (Dutch), <b>Maldivene</b> (Norwegian), <b>Maldiverna</b> (Swedish), <b>Maldiverne</b> (Danish), <b>Maldives</b> (Asturian, Catalan, Franco-Provençal, French, Malay, Min Nan, Scots Gaelic), <b>Maldíves</b> - <i>?a?d?ße?</i> (Greek), <b>Maldivi</b> (Bosnian, Maltese, Slovene), <b>Maldivi</b> - <i>???????</i> (Serbian), <b>Maldivija</b> (Latvian), <b>Maldivler</b> (Turkish), <b>Maldivoj</b> (Esperanto), <b>Maldivski ostrovi</b> - <i>????????? ???????</i> (Bulgarian), <b>Maldív-szigetek</b> (Hungarian), <b>Maldivy</b> - <i>????????</i> (Russian), <b>Maldivy</b> - <i>????????</i> (Ukrainian), <b>Maldyvai</b> (Lithuanian), <b>Malediivit</b> (Finnish), <b>Maledive</b> (Afrikaans), <b>Malediven</b> (Alemannic, German), <b>Maledivy</b> (Czech, Slovak), <b>Malediwy</b> (Polish), <b>Maltipusi</b> (Inuktitut), <b>Moldibeu</b> / <b>Moldibu</b> - ??? (Korean), <b>Morujibu</b> - ???? or <b>Morudibu</b> - ????? (Japanese), <b>Maldibs</b> (Filipino)</td>
</tr>
<tr>
<td><a href=""/wiki/Mali"" title=""Mali"">Mali</a></td>
<td><b>Maali</b> (Fula), <b>Mailí</b> (Irish), <b>Màili</b> (Scots Gaelic), <b>Malee</b> (Manx), <b>Mali</b> (Acehnese, Afrikaans, Alemannic, Aragonese, Azeri, Bambara, Basque, Bosnian, Breton, Catalan, Cebuano, Central Bikolano, Cornish, Croatian, Czech, Danish, Dutch, Estonian, Ewe, Faroese, Fiji Hindi, Finnish, Franco-Provençal, French, German, Ilokano, Indonesian, Inuktitut, Italian, Javanese, Kapampangan, Latvian, Lower Sorbian, Malay, Maltese, Min Nan, Polish, Portuguese, Romanian, Slovene, Spanish variant, Turkish, Upper Sorbian, Welsh), <b>Mali</b> - ???? (Armenian), <b>Malí</b> (Asturian, Galician, Icelandic, Spanish), <b>Mali</b> - <i>????</i> (Bulgarian, Russian, Serbian, Ukrainian)<b>Malí</b> - <i>?a??</i> (Greek), <b>Mali</b> - ???? (Hebrew), <b>Mali</b> - ??/?? (Mandarin Chinese), <b>Mali</b> - ???? (Thai), <b>Malio</b> (Esperanto), <b>Malis</b> (Lithuanian), <b>Malli</b> - ?? (Korean), <b>Maly</b> (West Frisian),<b>Máli</b> (Filipino), <b>Mari</b> - ?? (Japanese)</td>
</tr>
<tr>
<td><a href=""/wiki/Malta"" title=""Malta"">Malta</a></td>
<td><b>Ma'erta</b> - ???/??? (Mandarin Chinese), <b>Malita</b> (Inuktitut), <b>Malta</b> (Acehnese, Afrikaans, Albanian, Alemannic, Aragonese, Aromanian, Asturian, Azeri, Basque, Catalan, Central Bikolano, Bislama, Czech, Danish, Dutch, Estonian, Faroese, Filipino, Finnish, Franco-Provençal, German, Guaraní, Icelandic, Indonesian, Italian, Latvian, Lithuanian, Malay, Maltese, Min Nan, Polish, Portuguese, Romanian, Romansh, Scots Gaelic, Slovak, Slovene, Spanish, Swedish, Turkish, Welsh), <b>Malta</b> - ????? (Armenian), <b>Málta</b> - <i>???ta</i> (Greek), <b>Malta</b> - ???? (Hebrew), <b>Málta</b> (Hungarian, Irish), <b>Mal'ta</b> - <i>??????</i> (Bulgarian,Russian,Serbian,Ukrainian), <b>Malte</b> (French), <b>Malto</b> (Esperanto), <b>Maruta</b> - ??? (Japanese), <b>Melita</b> or <b>Melitta</b> (Latin), <b>Molta</b> / <b>Molt'a</b> - ?? (Korean), <b>Molta</b> - ????? (Thai)</td>
</tr>
<tr>
<td><a href=""/wiki/Marshall_Islands"" title=""Marshall Islands"">Marshall Islands</a></td>
<td><b>Eileanan Mharshall</b> (Scots Gaelic), <b>Eiyei marshal</b> - ??? ???? (Hebrew), <b>il-Gzejjer Marshall</b> (Maltese), <b>Îles Marshall</b> (French), <b>Ilhas Marshall</b> (Portuguese), <b>Illes Marshall</b> (Catalan), <b>Insulele Marshall</b> (Romanian), <b>Islas Marshall</b> (Aragonese, Spanish), <b>Islles Marshall</b> (Asturian), <b>Isole Marshall</b> (Italian), <b>Kapupud-ang Marshall</b> (Cebuano), <b>Kepulauan Marshall</b> (Indonesian), <b>Maasalli Qikiqtat</b> (Inuktitut), <b>March·al</b> (Franco-Provençal), <b>Maršala salas</b> (Latvian), <b>Marsall adalari</b> (Azeri), <b>Marsaloj</b> (Esperanto), <b>Maršalo Salos</b> (Lithuanian), <b>Maršalska Ostrva</b> (Bosnian), <b>Maršalska ostrva</b> - <i>????????? ??????</i> (Serbian), <b>Marshall</b> (French variant), <b>Marshall Adalari</b> (Turkish), <b>Marshalleilande</b> (Afrikaans), <b>Marshalleilanden</b> (Dutch), <b>Marshalleilannen</b> (West Frisian), <b>Marshallinsaaret</b> (Finnish), <b>Marshallinseln</b> (German), <b>Marshalli Saared</b> (Estonian), <b>Marshalli Saarõq</b> (Võro), <b>Marshall Kûn-tó</b> (Min Nan), <b>Marshallöarna</b> (Swedish), <b>Marshalløerne</b> (Danish), <b>Marshallove ostrovy</b> (Slovak), <b>Marshallovi otoki</b> (Slovene), <b>Marshallovi ostrovy</b> - <i>?????????? ???????</i> (Ukrainian), <b>Marshallovy ostrova</b> - <i>?????????? ???????</i> (Russian), <b>Marshallovy ostrovy</b> (Czech), <b>Marshalløyene</b> (Norwegian), <b>Marshalloyggjar</b> (Faroese), <b>Marshallsaaret</b> (Finnish variant), <b>Marshall Uharteak</b> (Basque), <b>Marshalovi ostrovi</b> - <i>????????? ???????</i> (Bulgarian), <b>Marshalyan Kghziner</b> - ????????? ??????? (Armenian), <b>Mashào'er Qúndao</b> - ?????/????? (Mandarin Chinese), <b>Masharu Shoto</b> - ??????? (Japanese), <b>Masyeol Jedo</b> / <b>Masyol Chedo</b> - ?? ?? (Korean), <b>Mu Ko Mach?n</b> - ????????????????? (Thai), <b>Nísi Mársal</b> - <i>??s?? ???sa?</i> (Greek), <b>Pulo-pulo Marshall</b> (Acehnese), <b>Wyspy Marshalla</b> (Polish), <b>Ynysoedd Marshall</b> (Welsh), <b>Mga Pulo ng Marshall</b> (Filipino), <b>Insulele Marshall</b> (Romanian)</td>
</tr>
<tr>
<td><a href=""/wiki/Martinique"" title=""Martinique"">Martinique</a></td>
<td><b>Mareutinikeu</b> / <b>Marut'inik'u</b> - ????? (Korean), <b>Martinica</b> (Aragonese, Aromanian, Asturian, Catalan, Galician, Portuguese, Romanian, Spanish), <b>Mártiník</b> (Filipino), <b>Martinik</b> (Bosnian, Breton, Czech, Faroese, Indonesian alternate), <b>Martinik</b> - ??????? (Hebrew), <b>Martinik</b> - <i>????????</i> (Serbian), <b>Martinika</b> (Azeri, Basque, Latvian, Lithuanian, Lower Sorbian), <b>Martinika</b> - <i>?????????</i> (Bulgarian), <b>Martiníka</b> - <i>?a?t????a</i> (Greek), <b>Martinique</b> (Cebuano, Danish, Estonian, Finnish, Franco-Provençal, French, German, Min-Nan, Scots Gaelic, Welsh), <b>Martynika</b> (Polish), <b>Marutiniiqquki</b> (Inuktitut), <b>Marutiniku</b> - ??????? (Japanese), <b>Matinik</b> - ????????? (Thai)</td>
</tr>
<tr>
<td><a href=""/wiki/Mauritania"" title=""Mauritania"">Mauritania</a></td>
<td><b>Máolitaníyà</b> - ?????/????? (Mandarin Chinese), <b>Máolitaníyà</b> - ?????/????? (Mandarin Chinese variant), <b>Máritanía</b> - (Icelandic), <b>Mauretania</b> (Polish), <b>Mauretanie</b> (Alemannic), <b>Mauretánie</b> (Czech till 1988), <b>Mauretanien</b> (Danish, German, Swedish), <b>Mauritaania</b> (Estonian, Võro), <b>Mauritania</b> (Acehnese, Aragonese, Asturian, Finnish, Inuktitut, Italian, Min Nan, Norwegian, Romanian, Scots Gaelic, Spanish), <b>Mauritania</b> - ????????? (Hebrew), <b>Mauritânia</b> (Portuguese), <b>Mauritanië</b> (Afrikaans, Dutch), <b>Mauritánie</b> (Czech), <b>Mauritanie</b> (French), <b>Mauritanija</b> (Bosnian, Lithuanian), <b>Mauritanija</b> (Latvian), <b>Mauritanija</b> - <i>???????????</i> (Serbian), <b>Mauritanio</b> (Esperanto), <b>Mauritanya</b> (Central Bikolano), <b>Mavretanija</b> (Slovene), <b>Mavritanía</b> - <i>?a???ta??a</i> (Greek), <b>Mavritaniya</b> (Azeri), <b>Mavritaniya</b> - <i>??????????</i> (Bulgarian, Russian), <b>Mavrytaniya</b> - <i>??????????</i> (Ukrainian), <b>Mawritanja</b> (Maltese), <b>Moritani</b> (Bambara), <b>Moritani</b> / <b>Morit'ani</b> - ???? (Korean), <b>Moritania</b> - ????????? (Armenian), <b>Móritania</b> (Faroese), <b>Moritania</b> - ?????? (Japanese), <b>Môritanie</b> (Franco-Provençal), <b>Moritanya</b> (Turkish), <b>Moritenia</b> - ?????????? (Thai), <b>Mouritani</b> - ???????? (Persian), <b>Mawritanya</b> (Filipino)</td>
</tr>
<tr>
<td><a href=""/wiki/Mauritius"" title=""Mauritius"">Mauritius</a></td>
<td><b>Máoliqiúsi</b> - ????/???? (Mandarin Chinese), <b>Maoris</b> (Breton), <b>Maurice</b> (French), <b>Maurícia</b> (Portuguese variant), <b>Maurícias</b> (Portuguese), <b>Mauricija</b> (Latvian), <b>Mauricijus</b> (Bosnian, Lithuanian), <b>Mauricijus</b> - <i>??????????</i> (Serbian), <b>Mauricio</b> (Aragonese, Asturian, Spanish), <b>Mauricio</b> (Esperanto), <b>Maurício</b> (Portuguese variant), <b>Mauricius</b> (Czech), <b>Maurisasi</b> (Inuktitut), <b>Maurisyo</b> (Central Bikolano), <b>Mauritius</b> (Afrikaans, Alemannic, Danish, Dutch, Estonian, Faroese, Finnish, German, Italian, Maltese, Min Nan, Polish, Romanian, Scots Gaelic), <b>Mauritsius</b> - ????????? (Hebrew), <b>Mavricij</b> (Slovene), <b>Mavriki</b> (Azeri), <b>Mavríkios</b> - <i>?a???????</i> (Greek), <b>Mavrikiy</b> - <i>????????</i> (Russian), <b>Mavritsiy</b> - <i>????????</i> (Bulgarian), <b>Mavrykiy</b> - <i>????????</i> (Ukrainian), <b>Mólixisi</b> - ????/???? (Mandarin Chinese variant), <b>Môris</b> (Franco-Provençal), <b>Moris</b> (Mauritian Creole), <b>Morishasu</b> - ?????? (Japanese), <b>Morisiat</b> - ????????? (Thai), <b>Morisyeoseu</b> / <b>Morisyosu</b> - ???? (Korean), <b>Mwrisiws</b> (Welsh), <b>Mawrisyus</b> (Filipino)</td>
</tr>
<tr>
<td><a href=""/wiki/Mayotte"" title=""Mayotte"">Mayotte</a></td>
<td><b>Mahore</b> (Estonian alternate), <b>Maiòta</b> (Occitan), <b>Maiotta</b> (Latin), <b>Majot</b> - <i>?????</i> (Serbian), <b>Majot</b> (West Frisian), <b>Majota</b> (Latvian), <b>Majotas</b> (Lithuanian), <b>Majoto</b> (Esperanto), <b>Majotta</b> (Polish), <b>Majotte</b> (Ligurian), <b>Mayót</b> - <i>?a???t</i> (Greek), <b>Mayot</b> - ????? (Thai), <b>Mayoteu</b> / <b>Mayot'u</b> - ??? (Korean), <b>Mayotta</b> - <i>???????</i> (Ukrainian), <b>Mayotte</b> (Afrikaans, Aragonese, Asturian, Basque, Bosnian, Breton, Catalan, Cornish, Croatian, Czech, Danish, Dutch, Estonian, Finnish, French, Galician, German, Hungarian, Icelandic, Indonesian, Italian, Javanese, Luxembourgish, Malaysian, Min Nan, Norwegian, Portuguese, Scots Gaelic, Spanish, Swahili, Welsh), <b>Mayotto</b> - ???? (Japanese), <b>Mayutti</b> (Inuktitut), <b>Mayote</b> (Filipino)</td>
</tr>
<tr>
<td><a href=""/wiki/Mexico"" title=""Mexico"">Mexico</a></td>
<td><b>Meagsago</b> (Scots Gaelic), <b>Mecsico</b> (Welsh), <b>Meejiko</b> (Yucatec Maya), <b>Mehhigo</b> (Võro), <b>Mehhiko</b> (Estonian), <b>Méhigo</b> / <b>Naakaii Bikéyah</b> (Navajo), <b>Mehika</b> (Slovene), <b>Méhiko</b> (Filipino/Tagalog), <b>Méjico</b> (Guarani, Spanish variant), <b>Mejiko</b> (Totonac, Tzotzil), <b>Mekhiko</b> - ?????? (Armenian), <b>Mekiku</b> (Huichol), <b>Mekishiko</b> - ???? (Japanese), <b>Meksika</b> (Albanian, Latvian, Lithuanian, Turkish), <b>Meksika</b> - <i>Me?c??a</i> (Russian), <b>Meksike</b> - ??????? (Yiddish), <b>Meksiko</b> (Acehnese, Afrikaans, Croatian, Esperanto, Faroese, Finnish, Indonesian), <b>Méksiko</b> - ???? (Amharic), <b>Meksiko</b> - <i>???????</i> (Bulgarian, Serbian), <b>Meksiko</b> - ?????? (Hebrew), <b>Meksiko</b> / <b>Meksik'o</b> - ??? (Korean), <b>Meksiko</b> - ???????? (Thai), <b>Meksyk</b> (Polish), <b>Meksyka</b> - <i>Me?c??a</i> (Ukrainian), <b>Mekzik</b> - ????? (Persian), <b>Messico</b> (Italian), <b>Messiku</b> (Maltese), <b>M? Tây Co</b> (Vietnamese), <b>Mèxic</b> (Catalan), <b>Mexic</b> (Romanian), <b>Mexico</b> (Danish, Dutch, Malay, Norwegian, Romansh), <b>México</b> (Portuguese, Spanish), <b>Méxicu</b> (Zapotec), <b>Mexicum</b> (Latin), <b>Mexihco</b> (Nahuatl), <b>Mexiko</b> (Afrikaans alternate, Alemannic, Czech, German, Slovak, Swedish), <b>Mexikó</b> - <i>?e????</i> (Greek), <b>Mexikó</b> (Hungarian), <b>Mexíkó</b> (Icelandic), <b>Mexique</b> (French), <b>Miksiku</b> (Inuktitut), <b>M'onda</b> (Otomí), <b>Mòxige</b> - ??? (Mandarin Chinese)</td>
</tr>
<tr>
<td><a href=""/wiki/Federated_States_of_Micronesia"" title=""Federated States of Micronesia"">Micronesia, Federated States of</a></td>
<td><b>Maikhronisia</b> - ??????????? (Thai), <b>Micronèisia</b> or <b>Stàitean Feadarailichte Mhicronèisia</b> (Scots Gaelic), <b>Micronesia</b> (Aragonese, Asturian, Cebuano, Dutch alternate, Indonesian alternate, Italian, Min Nan, Spanish), <b>Micronèsia</b> (Catalan), <b>Micronésia</b> (Portuguese), <b>Micronésie</b> (Czech, French), <b>Micronèsie</b> (Franco-Provençal), <b>Micronezia</b> (Romanian), <b>Mìkèluóníxiyà</b> - ??????/?????? (Mandarin Chinese), <b>Mikeuronesia</b> / <b>Mik'uronesia</b> - ?????? (Korean), <b>Mikroneesia</b> (Estonian), <b>Mikroneesiä</b> (Võro), <b>Mikronesia</b> (Acehnese, Faroese, Finnish, Indonesian, Norwegian), <b>Mikronesië</b> (Afrikaans, Dutch alternate), <b>Mikronesien</b> (Danish, German), <b>Mikronezia</b> - ?????????? (Armenian), <b>Mikronezia</b> (Breton), <b>Mikronezia</b> - ????????? (Hebrew), <b>Mikronezija</b> (Latvian), <b>Mikronezija</b> (Lithuanian, Slovene), <b>Mikronezija</b> - <i>???????????</i> (Serbian), <b>Mikronezio</b> (Esperanto), <b>Mikroneziya</b> (Azeri), <b>Mikroneziya</b> - <i>??????????</i> (Bulgarian, Russian, Ukrainian), <b>Mikronezja</b> (Polish), <b>Mikronezya</b> (Turkish), <b>Mikronisía</b> - <i>???????s?a</i> (Greek), <b>Mikuroneshia</b> - ?????? (Japanese), <b>Miqquunasia</b> (Inuktitut), <b>Maykronisya</b> (Filipino)</td>
</tr>
<tr>
<td><a href=""/wiki/Moldova"" title=""Moldova"">Moldova</a></td>
<td><b>Maladobha</b> - ?????? (Bengali), <b>an Mholdóiv</b> (Irish), <b>Mó'erduowa</b> - ????/???? (Mandarin Chinese), <b>Moldavia</b> (Albanian, Aragonese, Aromanian variant, Asturian, Basque, former English, Faroese variant, Indonesian variant, Italian, Latin, Spanish), <b>Moldavía</b> - <i>???daß?a</i> (Greek), <b>Moldávia</b> (Hungarian variant, Portuguese), <b>Moldavië</b> (former Afrikaans variant, Dutch), <b>Moldávie</b> (Czech), <b>Moldavie</b> (Franco-Provençal, French), <b>Moldavien</b> (Danish, Swedish), <b>Moldavija</b> (Lithuanian, Slovene), <b>Moldavija</b> - <i>?????????</i> (Serbian), <b>Moldavio</b> (Esperanto), <b>Moldaviya</b> (Azeri variant), <b>Moldaviya</b> - <i>Mo??a???</i> (Russian), <b>Moldavja</b> (Maltese), <b>Moldavsko</b> (Slovak), <b>Moldawia</b> (Polish), <b>Moldawië</b> (former Afrikaans variant), <b>Moldawien</b> (Alemannic, German), <b>Moldau</b> (German variant), <b>Moldoba</b> / <b>Moltoba</b> - ??? (Korean), <b>Moldòbha</b> (Scots Gaelic), <b>Moldofa</b> (Welsh), <b>Moldova</b> (Acehnese, Aromanian, Azeri, Danish, Estonian, Faroese, Finnish, Hungarian, Indonesian, Italian variant, Latvian, Maltese, Min Nan, Portuguese variant, Romanian, Spanish variant, Turkish, Võro), <b>Moldova</b> - ???? (Amharic), <b>Moldova</b> - ??????? (Armenian), <b>Moldova</b> - <i>???????</i> (Bashkir, Bulgarian, Ukrainian), <b>Moldova</b> - ??????? (Hebrew), <b>Moldóva</b> (Icelandic), <b>Moldovia</b> (Latin variant), <b>Moldobiya</b> (Filipino, Turkish), <b>Moldowa</b> (Afrikaans), <b>Moldowa</b> (Polish variant), <b>Moldowa</b> - ??????? (Thai), <b>Morudoba</b> - ???? (Japanese), <b>Mulitutuva</b> (Inuktitut)</td>
</tr>
<tr>
<td><a href=""/wiki/Monaco"" title=""Monaco"">Monaco</a></td>
<td><b>Manaka</b> - <i>??????</i> (Belarusian), <b>Monaco</b> (Afrikaans, Alemannic, Danish, Dutch, Estonian, Finnish, French, German, Hungarian, Italian, Min Nan, Polish variant, Romanian, Scots Gaelic, Swedish, Võro, Welsh), <b>Mónaco</b> (Asturian, Portuguese, Spanish), <b>Mônaco</b> (Brazilian Portuguese), <b>Monacô</b> (Franco-Provençal), <b>Monacó</b> (Irish), <b>Mónàge</b> - ???/??? (Mandarin Chinese), <b>Monakas</b> (Lithuanian), <b>Monakô</b> (Acehnese), <b>Monako</b> (Albanian, Azeri, Basque, Central Bikolano, Czech, Esperanto, Faroese, Filipino, Indonesian, Latvian, Maltese, Polish, Slovak, Slovene, Turkish), <b>Monako</b> - ??? (Amharic), <b>Monako</b> - ?????? (Armenian), <b>Monako</b> - <i>??????</i> (Bulgarian, Russian, Serbian, Ukrainian), <b>Monakó</b> - ???a?? (Greek), <b>Monako</b> - ????? (Hebrew), <b>Mónakó</b> (Icelandic), <b>Monako</b> - ??? (Japanese), <b>Monako</b> / <b>Monak'o</b> - ??? (Korean), <b>Monako</b> - ?????? (Thai), <b>Mónegue</b> (Aragonese), <b>Monoecus</b> (Latin), <b>Munaku</b> or <b>Munaqu</b> (Inuktitut), <b>Munegu</b> (Monegasque)</td>
</tr>
<tr>
<td><a href=""/wiki/Mongolia"" title=""Mongolia"">Mongolia</a></td>
<td><b>Mongol Uls</b> - ?????? ??? (Mongolian), <b>Menggu</b> - ?? (Mandarin Chinese), <b>Mogholestan</b> - ???????? (Persian), <b>Mogolistan</b> (Turkish), <b>Monggol</b> - ?? (Korean), <b>Mongholia</b> - ???????? (Armenian), <b>Mongkolia</b> - ????????? (Thai), <b>Mongòilia</b> (Scots Gaelic), <b>Mongolya</b> (Filipino), <b>Mongolei</b> (German), <b>Mongoleti</b> - ????????? (Georgian), <b>Mongolia</b> (Albanian, Faroese, Finnish, Indonesia, Italian, Latin, Malay, Norwegian, Polish, Romanian, Spanish, Welsh), <b>Mongolía</b> - <i>???????a</i> (Greek), <b>Mongolia</b> - ???????? (Hebrew), <b>Mongólia</b> (Hungarian, Portuguese), <b>Mongólía</b> (Icelandic), <b>Mongolië</b> (Afrikaans, Dutch), <b>Mongolie</b> (French), <b>Mongoliet</b> (Danish, Swedish), <b>Mongolija</b> (Croatian, Latvian, Lithuanian, Slovene), <b>Mongolija</b> - <i>?????????</i> (Serbian), <b>Mongolio</b> (Esperanto), <b>Mongoliya</b> - <i>????????</i> (Bulgarian, Russian, Ukrainian), <b>Mongolja</b> (Maltese), <b>Mongolska</b> (Lower Sorbian), <b>Mongolsko</b> (Czech, Slovak), <b>Mongoolia</b> (Estonian, Võro), <b>Mongoru</b> - ???? (Japanese), <b>Mongulia-Inuujarvik</b> (Inuktitut), <b>Mông C?</b> (Vietnamese)<br />
<small>Note: the independent state is also known officially as Outer Mongolia, to distinguish it from Chinese Inner Mongolia.</small></td>
</tr>
<tr>
<td><a href=""/wiki/Montenegro"" title=""Montenegro"">Montenegro</a></td>
<td><b>Cerná Hora</b> (Czech), <b>Çernoqoriya</b> (Azeri), <b>Charnahoryia</b> - <i>??????????</i> (Belarusian), <b>Cherna gora</b> - <i>????? ????</i> (Bulgarian), <b>Chernogoriya</b> - <i>?ep?o?op??</i> (Russian), <b>Chornohoriya</b> - <i>??p?o?op??</i> (Ukrainian), <b>Cierna Hora</b> (Slovak), <b>Crna Gora</b> (Bosnian, Croatian), <b>Crna Gora</b> - <i>???? ????</i> (Serbian), <b>Crna gora</b> (Slovene), <b>Czarnogóra</b> (Polish), <b>Heishan</b> - ?? (Mandarin Chinese), <b>Juodkalnija</b> (Lithuanian), <b>Karadag</b> (Turkish), <b>Mali i Zi</b> (Albanian), <b>Man?inigro</b> - ??????????? (Bengali), <b>Mavrovúnio</b> - <i>?a???ß?????</i> (Greek), <b>Melnkalne</b> (Latvian), <b>Méngtènèigeluó</b> - ?????/????? (Mandarin Chinese variant), <b>Mons Niger</b> (Latin), <b>Montainéagró</b> (Irish), <b>Montenegeuro</b> / <b>Mont'eneguro</b> - ????? (Korean), <b>Monténègrô</b> (Acehnese), <b>Montenegro</b> (Afrikaans, Alemannic, Aragonese, Basque, Catalan, Danish, Dutch, Esperanto, Estonian, Faroese, Filipino, Finnish, German, Indonesia, Italian, Malay, Maltese, Portuguese, Scots Gaelic, Spanish, Swedish, Võro, Welsh), <b>Monténégro</b> - ?????? (Amharic), <b>Montenegro</b> - ?????????? (Armenian), <b>Montènègro</b> (Franco-Provençal), <b>Monténégro</b> (French), <b>Montenegro</b> - ???????? (Hebrew), <b>Montenegró</b> (Hungarian), <b>Montenegru</b> (Asturian), <b>Monteneguro</b> - ?????? (Japanese), <b>Montenekro</b> - ?????????? (Thai), <b>Muntenegru</b> (Romanian), <b>Muntiniguru</b> (Inuktitut), <b>O?-soan</b> (Min Nan), <b>Qaradag</b> (Azeri variant), <b>Svartfjallaland</b> (Icelandic)</td>
</tr>
<tr>
<td><a href=""/wiki/Montserrat"" title=""Montserrat"">Montserrat</a></td>
<td><b>Manserat</b> - <i>????????</i> (Belarusian), <b>Méngtèsèlatè</b> - ????? (Mandarin Chinese), <b>Moncerato</b> (Esperanto), <b>Monserat</b> (Bosnian), <b>Monserat</b> - <i>????????</i> (Bulgarian, Serbian), <b>Monserrate</b> (Portuguese), <b>Monsœrat</b> - ????????????? (Thai), <b>Monteserat</b> - ??????? (Hebrew), <b>Monteuseraet</b> / <b>Mont'useraet</b> - ???? (Korean), <b>Montoserato</b> - ?????? (Japanese), <b>Montsarrat</b> (Franco-Provençal), <b>Montserrat</b> (Afrikaans, Aragonese, Asturian, Breton, Catalan, Czech, Estonian, Faroese, Finnish, Min Nan, Polish, Scots Gaelic, Welsh), <b>Montserrat</b> - <i>?????????</i> (Russian, Ukrainian), <b>Montserrát</b> - <i>???tse???t</i> (Greek), <b>Montserrata</b> (Latvian), <b>Muntusirrat</b> or <b>Muntusiqqat</b> (Inuktitut)</td>
</tr>
<tr>
<td><a href=""/wiki/Morocco"" title=""Morocco"">Morocco</a></td>
<td><b>Fas</b> (Turkish), <b>al-Maghrib</b> - ?????? (Arabic), <b>Maghribi</b> (Malay), <b>Maracó</b> (Irish), <b>Marakesh</b> - ????? (Persian), <b>Maroc</b> (Franco-Provençal, French, Romanian, Romansh), <b>Marocco</b> (Italian), <b>Marochium</b> (Latin variant), <b>Marocko</b> (Swedish), <b>Marocum</b> (Latin), <b>Maroka</b> - <i>??????</i> (Belarusian), <b>Maroka</b> (Latvian), <b>Marokas</b> (Lithuanian), <b>Marokk</b> (Maltese), <b>Marokko</b> (Afrikaans, Alemannic, Danish, Dutch, Faroese, Finnish, German, Norwegian), <b>Marokko</b> - ??????? (Bengali), <b>Marokkó</b> - (Hungarian, Icelandic), <b>Marokko</b> - <i>???????</i> (Russian, Ukrainian), <b>Maroko</b> (Acehnese, Bambara, Czech, Esperanto, Estonian, Indonesian, Polish, Slovak, Slovene, Võro), <b>Maroko</b> - <i>??????</i> (Bulgarian, Serbian), <b>Maróko</b> - <i>?a????</i> (Greek), <b>Maroko</b> - ????? (Hebrew), <b>Maroko</b> - ????????? (Yiddish), <b>Maroku</b> (Albanian), <b>el Marroc</b> (Catalan), <b>Marrocos</b> (Portuguese), <b>Marruecos</b> (Aragonese, Asturian, Spanish), <b>M?rakes</b> (Azeri), <b>Móluòge</b> - ??? (Chinese), <b>Morocco</b> (Min Nan), <b>Moroco</b> (Scots Gaelic, Welsh), <b>Morògo</b> (Scots Gaelic variant), <b>Moroko</b> (Filipino/Tagalog), <b>Morokko</b> - ???? (Japanese), <b>Morokko</b> - ???????? (Thai), <b>Moroko</b> - ??? (Amharic), <b>Mo?oko</b> - ?????? (Armenian), <b>Moroko</b> (Indonesian alternate), <b>Moroko</b> / <b>Morok'o</b> - ??? (Korean), <b>Murukku</b> or <b>Muruqqu</b> (Inuktitut)</td>
</tr>
<tr>
<td><a href=""/wiki/Mozambique"" title=""Mozambique"">Mozambique</a></td>
<td><b>Moçambique</b> (Min Nan, Portuguese, Swedish), <b>Mojambikeu</b> / <b>Mojambik'u</b> - ???? (Korean), <b>Mojamvika</b> - ????????? (Bengali), <b>Mosaimbic</b> (Scots Gaelic), <b>Mosambic</b> (Welsh), <b>Mosambiek</b> (Afrikaans), <b>Mosambiik</b> (Estonian, Võro), <b>Mosambik</b> (Alemannic, Faroese, Finnish, German, Norwegian), <b>Mósambík</b> (Icelandic), <b>Mosambik</b> - ???????? (Thai), <b>Mosambìog</b> (Scots Gaelic variant), <b>Mòsanbígei</b> - ????/???? (Mandarin Chinese variant), <b>Mòsangbikè</b> - ???? (Mandarin Chinese), <b>Mozambic</b> (Aromanian, Romanian), <b>Mozambico</b> (Italian), <b>Mozambik</b> - ????? (Amharic), <b>Mozambik</b> - ???????? (Armenian), <b>Mozambik</b> (Azeri, Czech, Indonesian, Polish, Slovak, Slovene, Turkish), <b>Mozambik</b> - <i>????????</i> (Bulgarian, Russian, Serbian), <b>Mozambik</b> - <i>????????</i> (Ukrainian), <b>Mozambik</b> - ??????? (Hebrew), <b>Mozambika</b> (Latvian), <b>Mozambikas</b> (Lithuanian), <b>Mozambiko</b> (Esperanto), <b>Mozambiku</b> (Albanian), <b>Mozambiku</b> - ?????? (Japanese), <b>Mozambique</b> (Aragonese, Asturian, Danish, Dutch, Franco-Provençal, French, Malay, Spanish), <b>Mozamvíki</b> - <i>???aµß???</i> (Greek), <b>Mozanbik</b> (Bambara), <b>Musampiqu</b> (Inuktitut)</td>
</tr>
<tr>
<td><a href=""/wiki/Myanmar"" title=""Myanmar"" class=""mw-redirect"">Myanmar</a></td>
<td><b>Ma?anamara</b> - ????????? (Bengali), <b>Miandiàn</b> - ??/?? (Mandarin Chinese), <b>M'ianma</b> - <i>?'????</i> (Belarusian), <b>Mianma</b> (Polish variant), <b>Mianmá</b> (Brazilian Portuguese variant), <b>Mianmaara</b> (Inuktitut), <b>Mianmar</b> (Afrikaans, Portuguese variant, Scots Gaelic), <b>Mianmar</b> - <i>???????</i> (Bulgarian), <b>Mianmár</b> - <i>??a?µ??</i> (Greek), <b>Mianmaras</b> (Lithuanian), <b>Mi?n Ði?n</b> (Vietnamese), <b>Mijanmar</b> (Bosnian), <b>Miyanma</b> - ??? (Korean), <b>Miyanmar</b> (Franco-Provençal), <b>Mjanma</b> (Latvian), <b>Mjanmar</b> (Faroese, Slovene), <b>Mjanmar</b> - <i>???????</i> (Serbian), <b>Mjanmarsko</b> (Slovak), <b>Myanma</b> (Azeri, Min Nan), <b>Myanma</b> - <b>??????</b> (Burmese), <b>Myanma</b> - ????? (Japanese), <b>M'yanma</b> - <i>??????</i> (Russian), <b>M'yanma</b> - <i>?'????</i> (Ukrainian), <b>Myanmar</b> (Acehnese, Alemannic, Aragonese, Asturian, Banyumasan, Central Bikolano, Czech, Danish, Dutch, former and alternate Estonian, Finnish, French, German, Indonesian, Italian, Malay, Maltese, Norwegian, Polish, Portuguese, Romanian, Spanish, Swedish, Turkish, Võro), <b>Myanmar</b> - ??????? (Armenian), <b>Myanmar</b> - ?????? (Hebrew)
<p><br />
<i>Former name, still widely used</i>: '<b>Abara-ma</b> - ?????? (Tibetan), <b>Barma</b> - ?????? (Bengali), <b>Barma</b> (Czech, Slovak), <b>Beoma</b> / <b>Poma</b> - ?? (Korean), <b>Birma</b> (Afrikaans variant, Dutch, Estonian, German, Indonesian variant, Latvian, Polish), <b>Birma</b> - ????? (Armenian), <b>Birma</b> - <i>??p?a</i> (Azeri, Bulgarian, Russian), <b>Birma</b> - <i>?????</i> (Belarusian), <b>Birmania</b> (Asturian, Italian, Romanian, Spanish), <b>Birmânia</b> (Portuguese), <b>Birmanie</b> (Franco-Provençal, French), <b>Birmanya</b> (Turkish), <b>Birmo</b> (Esperanto), <b>Biruma</b> - ??? (Japanese), <b>Burma</b> (Afrikaans, Alemannic, Banyumasan, Bosnian, Danish, Dutch variant, English, Faroese, Finnish, Indonesian, Malay, Min Nan, Norwegian, Portuguese variant, Scots Gaelic, Slovene, Swedish), <b>Burma</b> - <i>?????</i> (Bulgarian variant, Serbian), <b>Burma</b> - ????? (Hebrew), <b>Phoma</b> - ???? (Thai), <b>Piruma</b> (Inuktitut), <b>Virmanía</b> - <i>???µa??a</i> (Greek)</p>
</td>
</tr>
</table>
<h2><span class=""editsection"">[<a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit&amp;section=5"" title=""Edit section: N"">edit</a>]</span> <span class=""mw-headline"" id=""N"">N</span></h2>
<table border=""1"" cellspacing=""0"" cellpadding=""3"">
<tr>
<th><b>English Name</b></th>
<th><b>Other name(s) or older name(s)</b></th>
</tr>
<tr>
<td><a href=""/wiki/Namibia"" title=""Namibia"">Namibia</a></td>
<td><b>Naimibia</b> (Scots Gaelic), <b>Namibia</b> (Acehnese, Alemannic, Aragonese, Asturian, Bambara, Danish, Faroese, Finnish, German, Indonesian, Italian, Malay, Min Nan, Polish, Romanian, Spanish), <b>Namibia</b> - ?????? (Hebrew), <b>Namíbia</b> (Hungarian, Portuguese), <b>Namibia</b> - ???? (Japanese), <b>Namibia</b> - ???? (Korean), <b>Namibia</b> - ???????? (Thai), <b>Namibië</b> (Afrikaans, Dutch), <b>Namibie</b> (Czech, Franco-Provençal, French), <b>Namibija</b> (Latvian), <b>Namibija</b> (Lithuanian, Slovene), <b>Namibija</b> - <i>????????</i> (Serbian), <b>Namibio</b> (Esperanto), <b>Namibiya</b> - ???? (Amharic), <b>Namibiya</b> (Azeri), <b>Namibi?a</b> - ????????? (Bengali), <b>Namibiya</b> - <i>???????</i> (Bulgarian, Russian), <b>Namibiya</b> - <i>???????</i> (Ukrainian), <b>Nàmibiyà</b> - ????/???? (Mandarin Chinese), <b>Namibja</b> (Maltese), <b>Namibya</b> (Filipino, Turkish), <b>Namiibia</b> (Estonian, Võro), <b>Namímpia</b> - <i>?aµ?µp?a</i> (Greek), <b>Namipia</b> (Inuktitut)</td>
</tr>
<tr>
<td><a href=""/wiki/Nauru"" title=""Nauru"">Nauru</a></td>
<td><b>Naaroo</b> (Manx), <b>Naoero</b> (Nauruan), <b>Naolu</b> - ??/?? (Mandarin Chinese), <b>Naouroú</b> - <i>?a?????</i> (Greek), <b>Naouru</b> (Franco-Provençal), <b>Nárú</b> (Irish), <b>Nauro</b> (Esperanto), <b>Nauru</b> (Acehnese, Afrikaans, Alemannic, Aragonese, Aromanian, Asturian, Azeri, Basque, Bosnian, Catalan, Cebuano, Central Bikolano, Czech, Danish, Dutch, Estonian, Faroese, Fiji Hindi, Finnish, French, Galician, German, Indonesian, Inuktitut, Italian, Latvian, Lithuanian, Malay, Maltese, Min Nan, Polish, Portuguese, Romanian, Scots Gaelic, Slovene, Spanish, Welsh), <b>Nauru</b> - <i>?????</i> (Bulgarian, Russian, Serbian, Ukrainian), <b>Nauru</b> - ????? (Hebrew), <b>Nauru</b> - ??? (Japanese), <b>Nauru</b> - ??? (Korean), <b>Nauru</b> - ?????? (Thai), <b>Naurû</b> (West Frisian), <b>Nawru</b> (Filipino), <b>Nuòlu</b> - ??/?? (Mandarin Chinese variant)</td>
</tr>
<tr>
<td><a href=""/wiki/Nepal"" title=""Nepal"">Nepal</a></td>
<td><b>Balba</b> - <i>?????</i> (Mongolian), <b>Nepal</b> (Acehnese, Afrikaans, Alemannic, Aragonese, Asturian, Azeri, Bosnian, Breton, Central Bikolano, Dutch, Estonian, Faroese, Finnish, German, Indonesian, Italian, Malay, Maltese, Min Nan, Polish, Portuguese, Romanian, Scots Gaelic, Slovene, Spanish, Turkish), <b>Nepal</b> - <i>?????</i> (Bulgarian, Russian, Serbian, Ukrainian), <b>Nepál</b> (Czech, Hungarian), <b>Nèpal</b> (Franco-Provençal), <b>Népal</b> (French), <b>Nepál</b> - <i>?ep??</i> (Greek), <b>Nepal</b> - ???? (Hebrew), <b>Nepal</b> / <b>Nep'al</b> - ?? (Korean), <b>Nepal</b> - ????? (Thai), <b>Nepala</b> (Latvian), <b>Nepalas</b> (Lithuanian), <b>Nepalia</b> (Guarani), <b>Nepalo</b> (Esperanto), <b>Neparu</b> - ???? (Japanese), <b>Níbó'er</b> - ???/??? (Mandarin Chinese), <b>Nipaali</b> (Inuktitut), <b>Nipál</b> (Filipino)</td>
</tr>
<tr>
<td><a href=""/wiki/New_Caledonia"" title=""New Caledonia"">New Caledonia</a></td>
<td><b>Bagong Kalidonya</b> (Filipino), <b>Caledonia Newydd</b> (Welsh), <b>Caledonia Nuadh</b> (Scots Gaelic), <b>Jaunkaledonija</b> (Latvian), <b>Kaldonia</b> - ??????? or <b>Kaldonia Hachadasha</b> - ??????? ????? (Hebrew), <b>Kaledonia Barô</b> (Acehnese), <b>Kaledonia Baru</b> (Indonesian), <b>Kaledonia Berria</b> (Basque), <b>Kaledonia Mpya</b> (Swahili), <b>Naujoji Kaledonija</b> (Lithuanian), <b>Néa Kalidonía</b> - <i>??a ?a??d???a</i> (Greek), <b>Neukaledonien</b> (German), <b>Niu K?lidonia</b> - ????????????? (Thai), <b>Nouvelle-Calédonie</b> (French), <b>Nova Caledònia</b> (Catalan), <b>Nova Caledônia</b> (Portuguese), <b>Novaia Kaledoniia</b> - <i>????? ?????????</i> (Belarusian), <b>Nová Kaledonie</b> (Czech), <b>Nova Kaledonija</b> (Bosnian), <b>Nova Kaledonija</b> - <i>???? ??????????</i> (Serbian), <b>Nova Kaledoniya</b> - <i>???? ?????????</i> (Bulgarian, Ukrainian), <b>Novèla-Calèdonie</b> (Franco-Provençal), <b>Nowa Kaledonia</b> (Polish), <b>Nubelkalledoni</b> / <b>Nubelk'alledoni</b> - ?????? (Korean), <b>Nubhela Kaledonira Bhasha</b> - ????? ????????? ???? (Bengali), <b>Nueba Caledonia</b> (Aragonese), <b>Nueva Caledonia</b> (Aragonese, Spanish), <b>Nutaaq-Kalitunia</b> (Inuktitut), <b>Nya Kaledonien</b> (Swedish), <b>Ny-Caledonia</b> (Norwegian), <b>Nýja-Kaledónía</b> (Icelandic), <b>Nýkaledónia</b> (Faroese), <b>Ny Kaledonien</b> (Danish), <b>Nyukalledonia</b> / <b>Nyuk'alledonia</b> - ?????? (Korean variant), <b>Nyu-Karedonia</b> - ???????? (Japanese), <b>Sin Calédonie</b> (Min Nan), <b>Uusi-Kaledonia</b> (Finnish), <b>Uus-Kaledoonia</b> (Estonian), <b>Xin Kaliduoníyà</b> - ?????? (Mandarin Chinese), <b>Yeni Kaledoniya</b> (Azeri), <b>Noua Caledonie</b> (Romanian)</td>
</tr>
<tr>
<td><a href=""/wiki/New_Zealand"" title=""New Zealand"">New Zealand</a></td>
<td><b>Akhali Zelandia</b> - ????? ???????? (Georgian), <b>Aotearoa</b> (Maori), <b>Bagong Silan/Bagong Selanda</b> (Filipino, Tagalog), <b>Jaunzelande</b> (Latvian), <b>Naujoji Zelandija</b> (Lithuanian), <b>Néa Zilandía</b> - <i>??a ???a?d?a</i> (Greek), <b>Neuseeland</b> (Alemannic, German), <b>New Zealand</b> (Danish, Malay, Maltese, Norwegian), <b>Nieu-Seeland</b> (Afrikaans), <b>Nieuw-Zeeland</b> (Dutch), <b>Niu Jilyan?a</b> - ?????? ???????????? (Bengali), <b>Niu Sil?nd</b> - ?????????? (Thai), <b>Niu Tireni</b> (Maori variant), <b>Niu Xilán</b> - ???/??? (Mandarin Chinese variant), <b>Noua Zeelanda</b> (Romanian), <b>Nouvelle-Zélande</b> (French), <b>Novaia Zeliandyia</b> - <i>????? ????????</i> (Belarusian), <b>Novaya Zelandiya</b> - <i>????? ????????</i> (Russian), <b>Nova Zelanda</b> (Romansh), <b>Nova Zelandia</b> (Latin), <b>Nova Zelândia</b> (Portuguese), <b>Nova Zelandija</b> (Slovene), <b>Nova Zelandiya</b> - <i>???? ????????</i> (Bulgarian), <b>Nova Zelandiya</b> - <i>???? ????????</i> (Ukrainian), <b>Novèla-Zèlande</b> (Franco-Provençal), <b>Novi Zeland</b> (Croatian), <b>Novi Zeland</b> - <i>???? ??????</i> (Serbian), <b>Nový Zéland</b> (Czech, Slovak), <b>Nov-Zelando</b> (Esperanto), <b>Nowa Zelandia</b> (Polish), <b>Nueva Zelanda</b> (Aragonese, Asturian, Central Bikolano, Spanish), <b>Nueva Zelandia</b> (Spanish variant), <b>Nuova Zelanda</b> (Italian), <b>Nutaaq Sialanti</b> (Inuktitut), <b>Nya Zeeland</b> (Swedish), <b>Nýsæland</b> (Faroese), <b>Nyujillaendeu</b> / <b>Nyujillaendu</b> - ???? (Korean), <b>Nyujirando</b> - ???????? (Japanese), <b>Nyu-Ziland</b> - ???-????? (Hebrew), <b>Ny-Zealand</b> (Norwegian variant), <b>Sealan Nuadh</b> (Scots Gaelic), <b>Selandia Baru</b> (Indonesian), <b>Seland Newydd</b> (Welsh), <b>Seulandia Barô</b> (Acehnese), <b>Sin Jia?t-lân-jia</b> (Min Nan), <b>Tân Tây Lan</b> (Vietnamese), <b>Új-Zéland</b> (Hungarian), <b>Uusi-Seelanti</b> (Finnish), <b>Uus-Meremaa</b> (Estonian), <b>Vahtsõnõ Meremaa</b> (Võro), <b>Xin Xilán</b> - ???/??? (Mandarin Chinese), <b>Yeni Zelanda</b> (Turkish), <b>Yeni Zelandiya</b> (Azeri), <b>Zelanda e Re</b> (Albanian)</td>
</tr>
<tr>
<td><a href=""/wiki/Nicaragua"" title=""Nicaragua"">Nicaragua</a></td>
<td><b>Nicaragoa</b> (Franco-Provençal), <b>Nicaragua</b> (Afrikaans, Aragonese, Asturian, Danish, Dutch, Estonian, Finnish, French, German, Indonesian variant, Italian, Min Nan, Romanian, Scots Gaelic, Spanish), <b>Nicarágua</b> (Portuguese), <b>Níjialagua</b> - ???? (Mandarin Chinese), <b>Nikarágoua</b> - <i>???a?????a</i> (Greek), <b>Nikaragua</b> (Acehnese, Czech, Faroese, Indonesian, Inuktitut, Malay, Polish, Turkish), <b>Nikaragua</b> - <i>?????????</i> (Bulgarian, Russian), <b>Nikaragua</b> - ????????? (Hebrew), <b>Nikaragua</b> - ????? (Japanese), <b>Nikaragu?a</b> - ??????????? (Bengali), <b>Nikaragva</b> (Latvian, Lithuanian, Slovene), <b>Nikaragva</b> - <i>?????????</i> (Serbian), <b>Nikaragvo</b> (Esperanto), <b>Nikaragwa</b> - ???? (Amharic), <b>Nikaragwa</b> (Bambara, Filipino), <b>Nikaragwa</b> / <b>Nik'aragwa</b> - ???? (Korean), <b>Nikarahua</b> - <i>?????????</i> (Belarusian, Ukrainian), <b>Nikarakua</b> - ????????? (Thai), <b>Nikaraqua</b> (Azeri)</td>
</tr>
<tr>
<td><a href=""/wiki/Niger"" title=""Niger"">Niger</a></td>
<td><b>Naichœr</b> - ??????? (Thai), <b>Naijara</b> - ?????? (Bengali), <b>Nayger</b> (Filipino), <b>Nícher</b> (Aragonese), <b>Niger</b> (Acehnese, Afrikaans, Alemannic, Azeri, Bosnian, Breton, Cebuano, Central Bikolano, Czech, Danish, Dutch, Estonian, Faroese, Finnish, French, German, Indonesian, Italian, Lower Sorbian, Min Nan, Polish, Romanian, Scots Gaelic, Slovene, Welsh), <b>Nigér</b> - ??? (Amharic), <b>Niger</b> - <i>?????</i> (Bulgarian, Russian, Serbian),<b>Níger</b> (Catalan, Portuguese, Spanish), <b>Niger</b> (Maltese), <b>Nigera</b> (Latvian), <b>Nigeris</b> (Lithuanian), <b>Nigero</b> (Esperanto), <b>Nígiras</b> - <i>?????a?</i> (Greek), <b>Niher</b> - <i>?????</i> (Belarusian, Ukrainian), <b>Ni-jara</b> - ?????? (Tibetan), <b>Nijaru</b> - ?????? (Divehi), <b>Nijer</b> (Bambara, Turkish), <b>Nijer</b> - ???'? (Hebrew), <b>Nijereu</b> / <b>Nijeru</b> - ??? (Korean), <b>Nijeru</b> - ????? (Japanese), <b>Nijiira</b> (Inuktitut), <b>Nírì</b> - ?? (Mandarin Chinese variant), <b>Nírì'er</b> - ???/??? (Mandarin Chinese), <b>Níxer</b> (Asturian)</td>
</tr>
<tr>
<td><a href=""/wiki/Nigeria"" title=""Nigeria"">Nigeria</a></td>
<td><b>Naichiria</b> - ???????? (Thai), <b>Naijeria</b> - ?????? (Japanese), <b>Naijeri?a</b> - ?????????? (Bengali), <b>Nàijílìyà</b> - ????/???? (Mandarin Chinese variant), <b>Naijiria</b> (Inuktitut), <b>Naijiria</b> - ????? (Korean), <b>Naygériya</b> - ????? (Amharic), <b>Nicheria</b> (Aragonese), <b>Nigeeria</b> (Estonian), <b>Nigeeriä</b> (Võro), <b>Nigeria</b> (Acehnese, Alemannic, Danish, Dutch, Faroese, Finnish, French, German, Indonesian, Italian, Min Nan, Polish, Romanian, Scots Gaelic, Spanish), <b>Nigeria</b> - ?????? (Hebrew), <b>Nigéria</b> (Hungarian, Portuguese), <b>Nigerië</b> (Afrikaans), <b>Nigérie</b> (Czech), <b>Nigerija</b> (Latvian), <b>Nigerija</b> (Lithuanian, Slovene), <b>Nigerija</b> - <i>????????</i> (Serbian), <b>Nigerio</b> (Esperanto), <b>Nigeriya</b> (Azeri), <b>Nigeriya</b> - <i>???????</i> (Bulgarian, Russian), '<b>Nigerja</b> (Maltese), <b>Nigerya</b> (Central Bikolano), <b>Nigiría</b> - <i>??????a</i> (Greek), <b>Niherya</b> (Filipino), <b>Niheryia</b> - <i>???????</i> (Belarusian, Ukrainian), <b>Nijeria</b> (Bambara), <b>Nijerya</b> (Turkish), <b>Ni-ji-ri-ya</b> ??????????? (Tibetan), <b>Nírìlìyà</b> - ????/???? (Mandarin Chinese), <b>Nixeria</b> (Asturian, Galician)</td>
</tr>
<tr>
<td><a href=""/wiki/Niue"" title=""Niue"">Niue</a></td>
<td><b>Niu</b> - ???? (Divehi), <b>Niua</b> (Inuktitut), <b>Niuai</b> - ?? (Mandarin Chinese), <b>Niue</b> (Acehnese, Aragonese, Asturian, Basque, Bosnian, Catalan, Croatian, Czech, Danish, Estonian, Faroese, Fiji Hindi, Finnish, French, Galician, German, Icelandic, Indonesian, Irish, Italian, Latvian, Min Nan, Polish, Portuguese, Scots Gaelic, Spanish, Welsh), <b>Niue</b> - <i>????</i> (Belarusian, Ukrainian), <b>Niue</b> - <i>????</i> (Bulgarian, Kazakh, Serbian), <b>Niuè</b> (Franco-Provençal), <b>Niúe</b> - <i>????e</i> (Greek), <b>Niue</b> - ??? (Japanese), <b>Niue</b> - ??? (Korean), <b>Niue</b> - ???? (Ossetic), <b>Niue</b> - ?????? (Thai), <b>Niuje</b> (Lithuanian), <b>Nuu</b> - ??? (Bishnupriya Manipuri), <b>Nuywi</b> (Filipino)</td>
</tr>
<tr>
<td><a href=""/wiki/Norfolk_Island"" title=""Norfolk Island"">Norfolk Island</a></td>
<td><b>Eilean Norfolk</b> (Scots Gaelic), <b>Eiyei norfolk</b> - ??? ??????? (Hebrew), <b>Ila Norfolk</b> (Franco-Provençal), <b>Ilha Norfolk</b> (Portuguese), <b>Illa Norfolk</b> (Catalan), <b>Insulele Norfolk</b> (Romanian), <b>Kao Norfolk</b> - ????????????? (Thai), <b>Kepulauan Norfolk</b> (Indonesian), <b>Narphoka Dvipera Bhasha</b> - ????? ??????? ???? (Bengali), <b>Nísi Nórfolk</b> - <i>??s?? ???f???</i> (Greek), <b>Nofoku-to</b> - ??????? (Japanese), <b>Nopeok Jedo</b> / <b>Nop'ok Chedo</b> - ?? ?? (Korean), <b>Norfolk</b> (Afrikaans, Czech, Estonian, Polish variant), <b>Norfolka</b> (Latvian), <b>Norfolkas</b> (Lithuanian), <b>Norfolkinsaari</b> (Finnish), <b>Norfolkinsel</b> (German), <b>Norfolk Island</b> (Danish), <b>Norfolk-tó</b> (Min Nan), <b>Nuòfúkè dao</b> - ???? (Mandarin Chinese), <b>Nuuvuultiup Qikiqtat</b> (Inuktitut), <b>Ostriv Norfolk</b> - <i>?????? ???????</i> (Ukrainian), <b>Ostrov Norfolk</b> - <i>?????? ???????</i> (Bulgarian), <b>Ostrvo Norfok</b> - <i>?????? ??????</i> (Bosnian, Serbian), <b>Pulo ng Norfolk</b> (Filipino), <b>Pulo Norfolk</b> (Acehnese), <b>Vysla Norfalk</b> - <i>????? ???????</i> (Belarusian), <b>Wyspa Norfolk</b> (Polish), <b>Ynys Norfolk</b> (Welsh)</td>
</tr>
<tr>
<td><a href=""/wiki/North_Korea"" title=""North Korea"">North Korea</a></td>
<td><b>B?c Hàn</b> (Vietnamese variant), <b>Bei Chaoxian</b> - ??? (Mandarin Chinese), <b>Bukhan</b> / <b>Pukhan</b> - ?? (Korean - South Korea), <b>Chaoxian Mínzhuzhuyì Rénmín Gònghéguó</b> - ???????????) (full name in Mandarin Chinese), <b>Chosen Minshushugi Jinmin Kyowakoku</b> - ??????????? (full name in Japanese), <b>Choson</b> - ?? (Korean - North Korea), <b>Coiria a Tuath</b> (Scots Gaelic), <b>Corea del Nord</b> (Italian), <b>Corea del Norte</b> (Asturian, Spanish), <b>Corea Septentrionalis</b> (Latin), <b>Corê du Nord</b> (Franco-Provençal), <b>Coreea de Nord</b> (Romanian), <b>Corée du Nord</b> (French), <b>Coréia do Norte</b> (Brazilian Portuguese), <b>Coreia do Norte</b> (Portuguese), <b>Coreya d'o Norte</b> (Aragonese), <b>Gogledd Corea</b> (Welsh), <b>Hilagang Korea</b> (Filipino, Tagalog), <b>Hiusisayin Koria</b> (Armenian), <b>Joseon Minjujuui Inmin Gongwaguk</b> / <b>Choson Minjujuui Inmin Konghwaguk</b> - ??????????? (full name in Korean), <b>Kaoli N?a</b> - ??????????? (Thai), <b>Kita Chosen</b> - ??? (Japanese), <b>Kita Kuuria</b> (Inuktitut), <b>Korèa Barôh</b> (Acehnese), <b>Korea hatzfonit</b> - ?????? ??????? (Hebrew), <b>Korea Pólnocna</b> (Polish), <b>Korea ta' Fuq</b> (Maltese), <b>Korea Utara</b> (Indonesian, Malay), <b>Noord-Korea</b> (Afrikaans), <b>Nordkorea</b> (Alemannic, Danish, German, Swedish), <b>Norðurkorea</b> (Faroese), <b>Paunochnaia Kareia</b> - <i>????????? ?????</i> (Belarusian), <b>Pivnichna Koreya</b> - <i>???????? ?????</i> (Ukrainian), <b>Põhja-Korea</b> (Estonian), <b>Pohjois-Korea</b> (Finnish), <b>Severna Koreja</b> - <i>??????? ??????</i> (Serbian), <b>Severna Koreya</b> - <i>??????? ?????</i> (Bulgarian), <b>Severní Korea</b> (Czech), <b>Simali Koreya</b> (Azeri), <b>Šiaures Koreja</b> (Lithuanian), <b>Tiâu-sián</b> (Min Nan), <b>Tri?u Tiên</b> (Vietnamese), <b>Uttara Kori?a</b> - ????? ??????? (Bengali), <b>Vória Koréa</b> - <i>???e?a ????a</i> (Greek), <b>Ziemelkoreja</b> (Latvian), <b>Khoid Solongos</b> - ???? ???????? (Mongolian)</td>
</tr>
<tr>
<td><a href=""/wiki/Northern_Mariana_Islands"" title=""Northern Mariana Islands"">Northern Mariana Islands</a></td>
<td><b>Bei Maliyànà qúndao</b> - ??????? (Mandarin Chinese), <b>Bungmariana Jedo</b> / <b>Pungmariana Chedo</b> - ????? ?? (Korean), <b>Eileanan Mariana a Tuath</b> (Scots Gaelic), <b>Hilagang Maryanas</b> (Filipino, Tagalog), <b>Iles Marianes du Nord</b> (Franco-Provençal), <b>Ilhas Marianas do Norte</b> (Portuguese variant), <b>Illes Mariannes Septentrionals</b> (Catalan), <b>Islles Marianes del Norte</b> (Asturian), <b>Kita Mariana</b> - ????? (Japanese), <b>Kita Marianasi</b> (Inuktitut), <b>Marianas Setentrionais</b> (Portuguese), <b>Marianas Utara</b> (Indonesian, Malay), <b>Mariany Pólnocne</b> (Polish), <b>Marijanos Šiaurines salos</b> (Lithuanian), <b>Mu Kao Northœrn Mariana</b> - ?????????????????????????? (Thai), <b>Nördliche Marianen</b> (German), <b>Nordmarianerne</b> (Danish), <b>Nord-Marianoj</b> (Esperanto), <b>Notte Mariånas</b> (Chamorro), <b>Pak Mariana Kûn-tó</b> (Min Nan), <b>Paunochnyia Maryianskiia Vyspy</b> - <i>????????? ?????????? ?????</i> (Belarusian), <b>Pivnichni Marians'ki Ostrovy</b> - <i>???????? ?????????? ???????</i> (Ukrainian), <b>Põhja-Mariaanid</b> (Estonian), <b>Pohjois-Mariaanit</b> (Finnish), <b>Pulo-pulo Mariana Utara</b> (Acehnese), <b>Severna Marijanska ostrva</b> - <i>??????? ?????????? ??????</i> (Serbian), <b>Severni Marianski ostrovi</b> - <i>??????? ????????? ???????</i> (Bulgarian), <b>Severní Mariany</b> (Czech), <b>Simali Marian adalari</b> (Azeri), <b>Sjeverna Marijanska Ostrva</b> (Bosnian), <b>Vóries Mariánes Nísi</b> - <i>???e?e? ?a????e? ??s??</i> (Greek), <b>Ziemelu Marianas</b> (Latvian)</td>
</tr>
<tr>
<td><a href=""/wiki/Norway"" title=""Norway"">Norway</a></td>
<td><b>an Iorua</b> (Irish), <b>Narao?e</b> - ?????? (Bengali), <b>Na Uy</b> (Vietnamese), <b>Nirribhidh</b> (Scots Gaelic), <b>Noorweë</b> (Afrikaans), <b>Noorwegen</b> (Dutch), <b>Noreg</b> (Faroese, Norwegian-Nynorsk), <b>Noregur</b> (Icelandic), <b>Noreuwei</b> / <b>Noruwei</b> - ???? (Korean), <b>Norga</b> (Sami), <b>Norge</b> (Danish, Min Nan, Norwegian-Bokmål, Swedish), <b>Norja</b> (Finnish), <b>Norra</b> (Estonian, Võro), <b>Norsko</b> (Czech), <b>Nórsko</b> (Slovak), <b>Noruega</b> (Aragonese, Asturian, Catalan, Guaraní, Portuguese, Spanish), <b>Noruwega</b> (Filipino/Tagalog), <b>Noruwe</b> - ????? (Japanese), <b>Norveç</b> (Azeri, Turkish), <b>Norvèg·e</b> (Franco-Provençal), <b>Norvège</b> (French), <b>Norvegia</b> (Armenian, Basque, Italian, Latin, Romanian, Romansh), <b>Norvégia</b> (Hungarian), <b>Norvehia</b> - <i>????????</i> (Ukrainian), <b>Norvegija</b> (Latvian), <b>Norvegija</b> (Lithuanian), <b>Norvegio</b> (Esperanto), <b>Norvegiya</b> - <i>????????</i> (Bulgarian, Russian), <b>Norvegiya</b> - ??????? (Hebrew), <b>Norvegja</b> (Maltese), <b>Norvegjia</b> (Albanian), <b>Norvegye</b> - ????????? (Yiddish), <b>Norveška</b> - <i>????????</i> (Serbian), <b>Norveška</b> (Slovene), <b>Norvigía</b> - <i>???ß???a</i> (Greek), <b>Norway</b> (Malay, English), <b>Norweege</b> (Alemannic), <b>Norwegen</b> (German, Low Saxon), <b>Norwègia</b> (Acehnese), <b>Norwegia</b> (Indonesian, Polish), <b>Norwegska</b> (Lower Sorbian), <b>Norwéy</b> - ???? (Amharic), <b>Norwij</b> (Bambara), <b>Norwœi</b> - ???????? (Thai), <b>Norwy</b> (Welsh), <b>Nuówei</b> - ?? (Mandarin Chinese), <b>Nuruwai</b> (Inuktitut)</td>
</tr>
</table>
<h2><span class=""editsection"">[<a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit&amp;section=6"" title=""Edit section: O"">edit</a>]</span> <span class=""mw-headline"" id=""O"">O</span></h2>
<table border=""1"" cellspacing=""0"" cellpadding=""3"">
<tr>
<th><b>English Name</b></th>
<th><b>Other name(s) or older name(s)</b></th>
</tr>
<tr>
<td><a href=""/wiki/Oman"" title=""Oman"">Oman</a></td>
<td><b>Aman</b> - <i>????</i> (Belarusian), <b>Amàn</b> - ?? (Mandarin Chinese), <b>Omã</b> (Portuguese variant), <b>Omaan</b> (Estonian), <b>Omaan'</b> (Võro), <b>Oman</b> (Acehnese, Afrikaans, Alemannic, Azeri, Central Bikolano, Danish, Dutch, Faroese, Finnish, Franco-Provençal, French, German, Indonesian, Italian, Malay, Maltese, Min Nan, Polish, Portuguese variant, Romanian, Scots Gaelic, Slovene), <b>Omán</b> (Aragonese, Asturian, Czech, Hungarian, Spanish), <b>Oman</b> - <i>????</i> (Bulgarian, Russian, Serbian, Ukrainian), <b>Omán</b> - <i>?µ??</i> (Greek), <b>Oman</b> - ???? (Japanese), <b>Oman</b> - ?? (Korean), <b>Oman</b> - ????? (Thai), <b>Omana</b> - ???? (Assamese, Bengali), <b>Omana</b> (Latvian), <b>Omanas</b> (Lithuanian), <b>Omano</b> (Esperanto), <b>Omão</b> (Portuguese variant), <b>Umaan</b> (Inuktitut), '<b>Uman</b> - ????? (Arabic), <b>Umman</b> (Turkish)</td>
</tr>
</table>
<h2><span class=""editsection"">[<a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit&amp;section=7"" title=""Edit section: P"">edit</a>]</span> <span class=""mw-headline"" id=""P"">P</span></h2>
<table border=""1"" cellspacing=""0"" cellpadding=""3"">
<tr>
<th><b>English Name</b></th>
<th><b>Other name(s) or older name(s)</b></th>
</tr>
<tr>
<td><a href=""/wiki/Pakistan"" title=""Pakistan"">Pakistan</a></td>
<td><b>Bajisitan</b> - ???? (Mandarin Chinese), <b>Bakistan</b> - ??????? (Arabic), <b>Pacistan</b> (Welsh), <b>Pakiseutan</b> / <b>P'ak'isut'an</b> - ???? (Korean), <b>Pakistan</b> (Acehnese, Afrikaans, Alemannic, Armenian, Azeri, Danish, Dutch, Estonian, Faroese, Finnish, French, German, Icelandic, Indonesian, Italian, Malay, Maltese, Min Nan, Polish, Romanian, Romansh, Slovene, Turkish, Võro), <b>Pakistán</b> (Aragonese, Guaraní, Spanish), <b>Pakistan</b> - ????????? (Assamese, Bengali), <b>Pakistan</b> - <i>????????</i> (Bashkir, Bulgarian, Russian, Serbian), <b>Pákistán</b> (Czech), <b>Pakistán</b> - <i>?a??st??</i> (Greek), <b>Pakistan</b> - ?????? (Hebrew), <b>Pakistana</b> (Latvian), <b>Pakistanas</b> (Lithuanian), <b>Pakistano</b> (Esperanto), <b>Pakisthan</b> - ???????? (Thai), <b>Pakisutan</b> (Inuktitut), <b>Pakisutan</b> - ????? (Japanese), <b>Pakisztán</b> (Hungarian), <b>Pakystan</b> - <i>????????</i> (Ukrainian), <b>Paquistán</b> (Asturian), <b>Paquistan</b> (Franco-Provençal), <b>Paquistão</b> (Portuguese)</td>
</tr>
<tr>
<td><a href=""/wiki/Palau"" title=""Palau"">Palau</a></td>
<td><b>Belau</b> (Estonian, Palauan, Polish variant, Võro), <b>Bóliú</b> - ?? (Mandarin Chinese - Taiwan), <b>Pàláo</b> - ?? (Mandarin Chinese - PRC), <b>Palaos</b> (Asturian, Franco-Provençal, French), <b>Paláou</b> - <i>?a????</i> (Greek), <b>Palau</b> (Acehnese, Afrikaans, Aragonese, Austro-Bavarian, Azeri, Basque, Catalan, Cebuano, Central Bikolano, Czech, Danish, Dutch, Estonian alternate, Faroese, Finnish, German, Indonesian, Inuktitut, Irish, Italian, Lithuanian, Malay, Maltese, Min Nan, Polish, Portuguese, Romanian, Scots Gaelic, Slovene, Spanish, Welsh, West Frisian), <b>Palau</b> - <i>?????</i> (Belarusian), <b>Palau</b> - ????? (Bengali), <b>Palau</b> - <i>?????</i> (Bulgarian, Chuvash, Russian, Serbian, Ukrainian), <b>Palau</b> - ?????? (Divehi), <b>Palau</b> - ???? (Hebrew), <b>Pa-la'u</b> - ?????? (Tibetan), <b>Palauo</b> (Esperanto), <b>Palaw</b> - ????? (Thai), <b>Pallau</b> / <b>P'allau</b> - ??? (Korean), <b>Parao</b> - ??? (Japanese)</td>
</tr>
<tr>
<td><a href=""/wiki/Palestinian_territories"" title=""Palestinian territories"">Palestinian territories</a> (under <a href=""/wiki/Israel"" title=""Israel"">Israeli</a> control)</td>
<td><b>Baghestin</b> (Armenian), <b>Balèsitan</b> - ???? (Mandarin Chinese), <b>F?l?stin</b> (Azeri), <b>Filas?in</b> - ?????? (Arabic), <b>Filastiniyya</b> (Min Nan), <b>Filistin</b> (Turkish), <b>Harashut hapalestinait</b> - ????? ?????????? (Hebrew), <b>Palästina</b> (German), <b>Palas?inuge Daulet</b> - ???????????? ???????? (Divehi), <b>Palæstina</b> (Danish), <b>Palesteina</b> (Welsh), <b>Palestiina</b> (Estonian, Finnish, Võro), <b>Palestin</b> (Malay, Scots Gaelic), <b>Palèstina</b> (Acehnese), <b>Palestina</b> (Afrikaans, Aragonese, Asturian, Basque, Catalan, Czech, Dutch, Faroese, Filipino/Tagalog, Indonesian, Italian, Lithuanian, Maltese, Norwegian, Portuguese, Romanian, Spanish, Swedish), <b>Palestina</b> - <i>?????????</i> (Chuvash, Serbian), <b>Palestíni</b> - <i>?a?a?st???</i> (Greek), <b>Palestino</b> (Esperanto), <b>Palestinska administraciya</b> - <i>??????????? ?????????????</i> (Bulgarian), <b>Palestyna</b> - <i>?????????</i> (Ukrainian), <b>Palestyna</b> - <i>?????????</i> (Belarusian), <b>Palestyna</b> (Polish), <b>Palisutinian</b> (Inuktitut), <b>Palleseutain</b> / <b>P'allesut'ain</b> - ????? (Korean), <b>Paresuchina</b> - ????? (Japanese), <b>Teritoriile Palestiniene</b> (Romanian)</td>
</tr>
<tr>
<td><a href=""/wiki/Panama"" title=""Panama"">Panama</a></td>
<td><b>Banáma</b> - ???/??? (Mandarin Chinese), <b>Panama</b> (Acehnese, Afrikaans, Azeri, Bambara, Basque, Cebuano, Central Bikolano, Czech, Danish, Dutch, Estonian, Faroese, Finnish, Franco-Provençal, German, Icelandic, Indonesian, Inuktitut, Lithuanian, Lower Sorbian, Malay, Maltese, Polish, Romanian, Scots Gaelic, Slovene, Welsh), <b>Panamá</b> (Aragonese, Asturian, Breton, Extremaduran, French, Italian, Min Nan, Portuguese, Spanish), <b>Panama</b> - <i>??????</i> (Belarusian, Bulgarian, Chuvash, Russian, Serbian, Ukrainian), <b>Panama</b> - ?????? (Bengali), <b>Panamà</b> (Catalan), <b>Panama</b> - ???? (Hebrew), <b>Panama</b> - ??? (Japanese), <b>Panama</b> / <b>P'anama</b> - ??? (Korean), <b>Panama</b> - ?????? (Thai), <b>Pa-na-ma</b> - ?????? (Tibetan), <b>Panamás</b> - <i>?a?aµ??</i> (Greek), <b>Panamo</b> (Esperanto), <b>Penama</b> - ?????? (Divehi)</td>
</tr>
<tr>
<td><a href=""/wiki/Papua_New_Guinea"" title=""Papua New Guinea"">Papua New Guinea</a></td>
<td><b>Babùyà Niu Jinèiyà</b> - ???????/??????? (Mandarin Chinese variant), <b>Babùyà Xin Jinèiyà</b> - ???????/??????? (Mandarin Chinese), <b>Paapua Uus-Guinea</b> (Estonian), <b>Paapua Vahtsõnõ Ginea</b> (Võro), <b>Papoasie-Novèla-Guinê</b> (Franco-Provençal), <b>Papoea Nieu-Guinee</b> (Afrikaans), <b>Papoea-Nieuw-Guinea</b> (Dutch), <b>Papoúa Néa Gouinéa</b> - <i>?ap??a ??a G?????a</i> (Greek), <b>Papouasie-Nouvelle-Guinée</b> (French), <b>Papua Bagong Guineya</b> (Central Bikolano), <b>Papua Ginea Hachadasha</b> - ????? ????? ????? (Hebrew), <b>Papua Guinea Baru</b> (Indonesian variant), <b>Papua Guinea Nuadh</b> (Scots Gaelic), <b>Papua Naujoji Gvineja</b> (Lithuanian), <b>Papua-Neuguinea</b> (German), <b>Papua New Guinea</b> (Acehnese, Bislama, Malay), <b>Papua Niugini</b> (Indonesian variant, Tok Pisin), <b>Papua Niw Kini</b> - ???????????? (Thai), <b>Papua Noua Guinee</b> (Romanian), <b>Papua-Nova Guiné</b> (Portuguese), <b>Papua-Nová Guinea</b> (Czech, Slovak), <b>Papua Nova Gvineja</b> - <i>????? ???? ???????</i> (Serbian), <b>Papua Nova Gvineja</b> (Slovene), <b>Papua Nova Gvineya</b> - <i>????? ???? ??????</i> (Bulgarian, Ukrainian), <b>Papua-Novaia Gvineia</b> - <i>?????-????? ??????</i> (Belarusian), <b>Papua-Novaya Gvineya</b> - <i>?????-????? ??????</i> (Russian), <b>Papua-Nowa Gwinea</b> (Polish), <b>Papúa Nueva Guinea</b> (Asturian, Spanish), <b>Papua Nugini</b> (Indonesian), <b>Papua-Nuova Guinea</b> (Italian), <b>Papua Nutaaq Guinia</b> (Inuktitut), <b>Papua Nya Guinea</b> (Swedish), <b>Papua Ny Guinea</b> (Danish), <b>Papua Nýguinea</b> (Faroese), <b>Papua Ny-Guinea</b> (Norwegian), <b>Papuanyugini</b> / <b>P'ap'uanyugini</b> - ?????? (Korean), <b>Papua Nyuginia</b> - ????????? (Japanese), <b>Papuásia-Nova Guiné</b> (Portuguese variant), <b>Papua Sin Guinea</b> (Min Nan), <b>Pápua Új-Guinea</b> (Hungarian), <b>Papua-Uusi-Guinea</b> (Finnish), <b>Papuwa Bagong Guniya</b> (Filipino/Tagalog), <b>Papua Yeni Qvineya</b> (Azeri), <b>Papua y Nueva Guinea</b> (Aragonese), <b>Papuo-Nov-Gvineo</b> (Esperanto), <b>Papu?a Niugini</b> - ??????? ??????? (Bengali), <b>Papwa Gini Newydd</b> (Welsh)</td>
</tr>
<tr>
<td><a href=""/wiki/Paraguay"" title=""Paraguay"">Paraguay</a></td>
<td><b>Balagui</b> - ??? (Mandarin Chinese), <b>Paragoayi</b> (Franco-Provençal), <b>Paragouái</b> - <i>?a?a?????</i> (Greek), <b>Paraguai</b> (Aragonese, Inuktitut, Portuguese, Romansh, Scots Gaelic), <b>Paraguái</b> (Guarani), <b>Paraguai</b> - ????? (Japanese), <b>Paraguay</b> (Acehnese, Afrikaans, Asturian, Czech, Danish, Dutch, Estonian, Finnish, French, German, Hungarian, Indonesian, Italian, Malay, Min Nan, Romanian, Spanish, Turkish), <b>Paragvai</b> - <i>????????</i> (Belarusian, Ukrainian), <b>Paragvaj</b> - <i>????????</i> (Serbian, Slovene), <b>Paragvajo</b> (Esperanto), <b>Paragvajus</b> (Lithuanian), <b>Paragvay</b> - <i>????????</i> (Bulgarian, Russian), <b>Paragvæ</b> (Icelandic), <b>Paragwai</b> - ????????? (Hebrew), <b>Paragwai</b> / <b>P'aragwai</b> - ???? (Korean), <b>Paragwaj</b> (Maltese, Polish), <b>Parakwây</b> - ???????? (Thai), <b>Paraqvay</b> (Azeri), <b>Parawayi</b> (Aymara, Quechua), <b>Paregwai</b> (Welsh), <b>Pyaragu?e</b> - ??????????? (Bengali)</td>
</tr>
<tr>
<td><a href=""/wiki/Peru"" title=""Peru"">Peru</a></td>
<td><b>Bìlu</b> - ??/?? (Mandarin Chinese), <b>Perou</b> (Breton), <b>Pèrou</b> (Franco-Provençal), <b>Pérou</b> (French), <b>Peroú</b> - <i>?e???</i> (Greek), <b>Pèru</b> (Acehnese), <b>Peru</b> (Afrikaans, Alemannic, Austro-Bavarian, Azeri, Bislama, Bosnian, Cebuano, Central Bikolano, Chavacano, Czech, Danish, Dutch, Finnish, German, Hungarian, Indonesian, Lithuanian, Malay, Maltese, Polish, Portuguese, Romanian, Scots Gaelic, Slovene, Turkish), <b>Perú</b> (Aragonese, Asturian, Catalan, Faroese, Icelandic, Min Nan, Spanish), <b>Peru</b> - <i>????</i> (Belarusian), <b>Peru</b> - ???? (Bengali), <b>Peru</b> - <i>????</i> (Bulgarian, Chuvash, Russian, Serbian, Ukrainian), <b>Peru</b> (Guarani), <b>Peru</b> - ??? (Hebrew), <b>Perù</b> (Italian), <b>Peru</b> - ??? (Japanese), <b>Peru</b> / <b>P'eru</b> - ?? (Korean), <b>Peru</b> - ???? (Thai), <b>Pe-ru</b> - ?????? (Tibetan), <b>Peruo</b> (Esperanto), <b>Peruu</b> (Estonian, Võro), <b>Perw</b> (Welsh), <b>Piruu</b> (Inuktitut), <b>Piruw</b> (Aymara, Quechua)</td>
</tr>
<tr>
<td><a href=""/wiki/Philippines"" title=""Philippines"">Philippines</a></td>
<td><b>Feilubin</b> - ???/??? (Mandarin Chinese), <b>Felipines</b> (Franco-Provençal), <b>y Ffilipin</b> (Welsh), <b>Filibin</b> - ????? (Arabic), <b>Filipaina</b> (Samoan), <b>Filipiene</b> (Limburgish), <b>Filipiinid</b> (Estonian), <b>Filipiiniq</b> (Võro), <b>Filipijnen</b> (Dutch), <b>Fîlîpîn</b> (Kurdish), <b>Filipina</b> (Acehnese, Banyumasan, Indonesian, Malay), <b>Filipinai</b> (Lithuanian), <b>Filipinak</b> (Basque), <b>Filipinas</b> (Aragonese, Central Bikolano, Chavacano, Ilocano, Pampangan, Pangasinan, Portuguese, Spanish), <b>Filipinas</b> (Latvian), <b>Filipine</b> (Romanian), <b>Filipinen</b> (Frisian), <b>Filipines</b> (Asturian, Catalan), <b>Filipinet</b> (Albanian), <b>Filipini</b> (Croatian, Slovene), <b>Filipini</b> - <i>????????</i> (Bulgarian, Serbian), <b>Filipinim</b> - ????????? (Hebrew), <b>Filipinler</b> (Turkish), <b>Filipinoj</b> (Esperanto), <b>Filipiny</b> - <i>????????</i> (Belarusian), <b>Filipíny</b> (Czech, Slovak), <b>Filipiny</b> (Polish), <b>Filipiny</b> - <i>????????</i> (Ukrainian), <b>na h-Eileanan Filipineach</b> or <b>na Filipìonan</b> (Scots Gaelic variant), <b>Filippiinit</b> (Finnish), <b>Filippin</b> (Azeri), <b>Filippinane</b> (Norwegian - Nynorsk), <b>Filippine</b> (Italian), <b>Filippinene</b> (Norwegian - Bokmål), <b>Filippinerna</b> (Swedish), <b>Filippinerne</b> (Danish), <b>Filippínes</b> - <i>F???pp??e?</i> (Greek), <b>Filippini</b> (Maltese), <b>Filippint</b> - ?????????? (Thai), <b>Filippiny</b> - <i>?????????</i> (Russian), <b>Filippiny</b> - <i>?????????</i> (Ukrainian), <b>Filippseyjar</b> (Icelandic), <b>Filippyne</b> (Afrikaans), <b>Filipsoyggjar</b> (Faroese), <b>Firipin</b> - ????? (Japanese), <b>Fülöp-szigetek</b> (Hungarian), <b>Hui-li?p-pin</b> (Min Nan), <b>Philipaina</b> - ???????? (Assamese, Bengali), <b>Philipains</b> - ?????????? (Marathi), <b>Philipina</b> (Indonesian variant), <b>Philippinae</b> (Latin), <b>Philippine</b> (Alemannic), <b>Philippinen</b> (German, Luxembourgish), <b>Philippines</b> (French, Vietnamese), <b>Phi Lu?t Tân</b> (Vietnamese variant), <b>Pilipinas</b> (Cebuano, Tagalog, Waray-Waray, Welsh), <b>Pilipinebi</b> - ?????????? (Georgian), <b>Pilippinisi</b> (Inuktitut), <b>Pillipin</b> / <b>P'illip'in</b> - ??? (Korean), <b>Filipine</b> (Romanian)</td>
</tr>
<tr>
<td><a href=""/wiki/Pitcairn_Islands"" title=""Pitcairn Islands"">Pitcairn Islands</a></td>
<td><b>Eilean Bhaile a' Chùirn</b> (Scots Gaelic), <b>Isole Pitcairn</b> (Italian), <b>Kepulauan Pitcairn</b> (Indonesian), <b>Moo Koa Pitcairn</b> - ???????????????? (Thai), <b>Nísi Pítkern</b> - <i>??s?? ??t?a???</i> (Greek), <b>Ostrovy Pitkern</b> - <i>??????? ???????</i> (Ukrainian), <b>Ostrva Pitkern</b> - <i>?????? ???????</i> (Serbian), <b>Pitcairn</b> (Estonian, Finnish, Polish variant, Portuguese), <b>Pitcairnovy ostrovy</b> (Czech), <b>Pítèkaien qúndao</b> - ?????? (Mandarin Chinese), <b>Pitkeeon Jedo</b> / <b>P'itk'eon Chedo</b> - ??? ?? (Korean), <b>Pitkerno salos</b> (Lithuanian), <b>Pitokean Shoto</b> - ??????? (Japanese), <b>Pitsuin Qikiqtat</b> (Inuktitut), <b>Wyspy Pitcairn</b> (Polish)</td>
</tr>
<tr>
<td><a href=""/wiki/Poland"" title=""Poland"">Poland</a></td>
<td><b>Ba Lan</b> (Vietnamese), <b>Bolán</b> - ??/?? (Mandarin Chinese), <b>Bulanda</b> - ?????? (Arabic), <b>Gwlad Pwyl</b> (Welsh), <b>Lehastan</b> - ???????? (Armenian), <b>Lengyelország</b> (Hungarian), <b>Lenkija</b> (Lithuanian), <b>an Pholainn</b> (Irish), <b>a' Phòlainn</b> (Scots Gaelic), <b>Poalen</b> (Frisian), <b>Poland</b> (Malay), <b>Polandia</b> (Indonesian), <b>Pol?n</b> - ??????? (Thai), <b>Pole</b> (Afrikaans), <b>Polen</b> (Danish, Dutch, German, Low Saxon, Norwegian, Swedish), <b>Polija</b> (Latvian), <b>Polin</b> - ????? (Hebrew), <b>Poljska</b> (Bosnian, Croatian, Slovene), <b>Poljska</b> - <i>??????</i> (Serbian), <b>Pólland</b> (Faroese, Icelandic), <b>Pollandeu</b> / <b>P'ollandu</b> - ??? (Korean), <b>Pollando</b> (Esperanto), <b>Pologna</b> (Romansh), <b>Pologne</b> (French), <b>Poloneti</b> - ???????? (Georgian), <b>Polonia</b> (Basque, Italian, Latin, Romanian, Spanish), <b>Polonía</b> - <i>??????a</i> (Greek), <b>Polónia</b> (Portuguese), <b>Polònia</b> (Catalan), <b>Polônia</b> (Brazilian Portuguese), <b>Polonja</b> (Maltese), <b>Polonya</b> (Filipino, Tagalog, Turkish), <b>Polsa</b> or <b>L?histan</b> (Azeri), <b>Pol'šca</b> - <i>???????</i> (Belarusian), <b>Pol'sca</b> - <i>??????</i> (Ukrainian), <b>Polsha</b> - <i>?????</i> (Bulgarian), <b>Pol'sha</b> - <i>??????</i> (Russian), <b>Polska</b> (Lower Sorbian, Polish), <b>Polsko</b> (Czech), <b>Polsko</b> (Slovak), <b>Poola</b> (Estonian, Võro), <b>Porando</b> - ????? (Japanese), <b>Poyln</b> - ????? (Yiddish), <b>Puola</b> (Finnish), <b>Puulanti</b> (Inuktitut)</td>
</tr>
<tr>
<td><a href=""/wiki/Portugal"" title=""Portugal"">Portugal</a></td>
<td><b>Burtughal</b> - ?????? (Arabic), <b>B? Ðào Nha</b> (Vietnamese), <b>Lusitania</b> (Latin variant), <b>Pertual</b> (Mirandese), <b>a' Phortagail</b> (Scots Gaelic), <b>an Phortaingéil</b> (Irish), <b>Pontuket</b> - ???????? (Thai), <b>Poreutugal</b> / <b>P'orut'ugal</b> - ???? (Korean), <b>Portekiz</b> (Turkish), <b>Portiwgal</b> (Welsh), <b>Portogalía</b> - <i>???t??a??a</i> (Greek), <b>Portogallo</b> (Italian), <b>Portugal</b> (Afrikaans, Armenian, Basque, Catalan, Croatian, Danish, Dutch, Estonian, Faroese, French, German, Indonesian, Low Saxon, Malay, Portuguese, Romansh, Scots Gaelic, Spanish, Swedish, Võro), <b>Portugal</b> - ??????? (Hebrew), <b>Portúgal</b> (Icelandic), <b>Portugal</b> - <i>????????</i> or <b>Portugalija</b> - <i>???????????</i> (Serbian), <b>Portugal</b> - ??????????? (Yiddish), <b>Portugale</b> (Latvian), <b>Portugali</b> (Finnish), <b>Portugalia</b> (Polish, Romanian), <b>Portugália</b> (Hungarian), <b>Portugalija</b> (Lithuanian), <b>Portugalio</b> (Esperanto), <b>Portugaliya</b> - <i>??????????</i> (Bulgarian, Russian), <b>Portugall</b> (Maltese), <b>Portugallia</b> (Latin), <b>Portugalska</b> (Lower Sorbian, Slovene), <b>Portugalsko</b> (Czech, Slovak), <b>Portugis</b> (former Indonesian), <b>Porutogaru</b> - ????? (Japanese), <b>Púguó</b> - ??/?? (Mandarin Chinese variant), <b>Purtagal</b> - ???????? (Hindi), <b>Purutugali</b> (Inuktitut), <b>Portuhaliya</b> - <i>??????????</i> (Ukrainian), <b>Pútáoyá</b> - ??? (Mandarin Chinese)</td>
</tr>
<tr>
<td><a href=""/wiki/Monaco"" title=""Monaco"">Principality of Monaco</a></td>
<td><b>Furstendömet Monaco</b> (Swedish), <b>Fürstentum Monaco</b> (German), <b>Fyrstedømmet Monaco</b> (Danish, Norwegian), <b>Kerajaan Monako</b> (Indonesian), <b>Kneževina Monako</b> - <i>????????? ??????</i> (Serbian), <b>Kneževina Monako</b> (Slovene), <b>Knyazhestvo Monako</b> - <i>????????? ??????</i> (Bulgarian, Russian), <b>Knyazivstvo Monako</b> - <i>?????????? ??????</i> (Ukrainian), <b>Ksiestwo Monako</b> (Polish), <b>Monacké kniežatstvo</b> (Slovak), <b>Monacké knížectví</b> (Czech), <b>Monacói Hercegség</b> (Hungarian), <b>Monaco</b> (Polish variant), <b>Monacon ruhtinaskunta</b> (Finnish), <b>Monaco Vürstiriik</b> (Estonian), <b>Mónàge Dàgongguó</b> - ??????/?????? (Mandarin Chinese), <b>Monaka Princlando</b> (Esperanto), <b>Monako</b> (Faroese, Polish variant), <b>Monako</b> - ????? (Hebrew), <b>Monako Gongguk</b> / <b>Monak'o Kongguk</b> - ??? ?? (Korean), <b>Monako kunigaikštyste</b> (Lithuanian), <b>Monako Prensligi</b> (Turkish), <b>Monako Taikokoku</b> - ?????? (Japanese), <b>Munaku</b> (Inuktitut), <b>Prigkipáto tu Monakó</b> - <i>??????p?t? t?? ???a??</i> (Greek), <b>Principado de Mónaco</b> (Spanish), <b>Principado de Mônaco</b> (Brazilian Portuguese), <b>Principado do Mónaco</b> (Portuguese), <b>Principalità ta' Monako</b> (Maltese), <b>Principato di Monaco</b> (Italian), <b>Principatul Monaco</b> (Romanian), <b>Principauté de Monaco</b> (French), <b>Prinsdom Monaco</b> (Dutch), <b>Rajcharat Monako</b> - ???????????? (Thai), <b>Tywysogaeth Monaco</b> (Welsh), <b>Principatul Monaco</b> (Romanian), <b>Prionnsachd Mhonaco</b> (Scots Gaelic)</td>
</tr>
<tr>
<td><a href=""/wiki/Puerto_Rico"" title=""Puerto Rico"">Puerto Rico</a></td>
<td><b>Boduo Lígè</b> - ???? (Mandarin Chinese), <b>Perto Rico</b> - ??????????? (Thai), <b>Porto Rico</b> (Indonesian alternate, Italian, Portuguese), <b>Porto Riko</b> (Turkish), <b>Portoriko</b> (Czech), <b>Portoriko</b> - <i>?????????</i> (Serbian), <b>Portoryko</b> (Polish), <b>Puereutoriko</b> / <b>P'uerut'orik'o</b> - ?????? (Korean), <b>Puerto Rico</b> (Finnish, Polish variant, Scots Gaelic, Spanish), <b>Puerto Rikas</b> (Lithuanian), <b>Puerto Riko</b> - <i>?????? ????</i> (Bulgarian), <b>Puerto Riko</b> (Faroese, Indonesian), <b>Puérto Ríko</b> - <i>?????t? ????</i> (Greek), <b>Puerto-riko</b> - ?????? ???? (Hebrew), <b>Puerutoriko</b> - ?????? (Japanese), <b>Puerto Ryko</b> - <i>??????-????</i> (Ukrainian), <b>Puirutu Riku</b> (Inuktitut)</td>
</tr>
</table>
<h2><span class=""editsection"">[<a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit&amp;section=8"" title=""Edit section: See also"">edit</a>]</span> <span class=""mw-headline"" id=""See_also"">See also</span></h2>
<ul>
<li><a href=""/wiki/List_of_sovereign_states"" title=""List of sovereign states"">List of sovereign states</a></li>
<li><a href=""/wiki/List_of_Latin_place_names_in_Europe"" title=""List of Latin place names in Europe"" class=""mw-redirect"">List of Latin place names in Europe</a></li>
<li><a href=""/wiki/List_of_cities_in_the_Americas_with_alternative_names"" title=""List of cities in the Americas with alternative names"">List of cities in the Americas with alternative names</a></li>
<li><a href=""/wiki/Names_of_European_cities_in_different_languages"" title=""Names of European cities in different languages"">Names of European cities in different languages</a></li>
<li><a href=""/wiki/List_of_European_regions_with_alternative_names"" title=""List of European regions with alternative names"">List of European regions with alternative names</a></li>
<li><a href=""/wiki/List_of_European_rivers_with_alternative_names"" title=""List of European rivers with alternative names"">List of European rivers with alternative names</a></li>
</ul>
<h2><span class=""editsection"">[<a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit&amp;section=9"" title=""Edit section: External links"">edit</a>]</span> <span class=""mw-headline"" id=""External_links"">External links</span></h2>
<ul>
<li><a rel=""nofollow"" class=""external text"" href=""http://www.foreignword.com/countries/Danish.htm"">Country names in English French Spanish Italian German Swedish Finnish Dutch Danish Greek Portuguese Polish Russian Hungarian Arabic Japanese - here Danish</a></li>
<li><a rel=""nofollow"" class=""external text"" href=""http://www.gov.si/kszi/"">Slovene Governmental Commission for the Standardisation of Geographical Names</a> - in the first column are names as proposed by the commission, in the second column are short official names, in the third column are long official names. Accessed on 7 October 2005.</li>
<li><a rel=""nofollow"" class=""external text"" href=""http://www.sanmigueldirectory.com/"">Tourist guide of San Miguel de Allende - Información sobre México</a></li>
</ul>
<table cellspacing=""0"" class=""navbox"" style=""border-spacing:0;;"">
<tr>
<td style=""padding:2px;"">
<table cellspacing=""0"" class=""nowraplinks collapsible autocollapse navbox-inner"" style=""border-spacing:0;background:transparent;color:inherit;;"">
<tr>
<th scope=""col"" style="";"" class=""navbox-title"" colspan=""2"">
<div class=""noprint plainlinks hlist navbar mini"" style="""">
<ul>
<li class=""nv-view""><a href=""/wiki/Template:Countries_and_languages_lists"" title=""Template:Countries and languages lists""><span title=""View this template"" style="";;background:none transparent;border:none;"">v</span></a></li>
<li class=""nv-talk""><a href=""/wiki/Template_talk:Countries_and_languages_lists"" title=""Template talk:Countries and languages lists""><span title=""Discuss this template"" style="";;background:none transparent;border:none;"">t</span></a></li>
<li class=""nv-edit""><a class=""external text"" href=""//en.wikipedia.org/w/index.php?title=Template:Countries_and_languages_lists&amp;action=edit""><span title=""Edit this template"" style="";;background:none transparent;border:none;"">e</span></a></li>
</ul>
</div>
<div class="""" style=""font-size:110%;""><a href=""/wiki/Lists_of_countries_and_territories"" title=""Lists of countries and territories"">Countries</a> and <a href=""/wiki/Lists_of_languages"" title=""Lists of languages"">languages</a> lists</div>
</th>
</tr>
<tr style=""height:2px;"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"" style="";;"">Languages by continent</th>
<td style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;;;padding:0.25em 0; line-height:1.4em;"" class=""navbox-list navbox-odd"">
<div style=""padding:0em 0.25em""><span class=""nowrap""><a href=""/wiki/Languages_of_Africa"" title=""Languages of Africa"">Africa</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Indigenous_languages_of_the_Americas"" title=""Indigenous languages of the Americas"">Americas</a> (<a href=""/wiki/Languages_of_North_America"" title=""Languages of North America"">North</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Languages_of_South_America"" title=""Languages of South America"">South</a>)&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Languages_of_Asia"" title=""Languages of Asia"">Asia</a> (<a href=""/wiki/East_Asian_languages"" title=""East Asian languages"">East</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Languages_of_South_Asia"" title=""Languages of South Asia"">South</a>)&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Languages_of_Europe"" title=""Languages of Europe"">Europe</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Languages_of_Oceania"" title=""Languages of Oceania"">Oceania</a></span></div>
</td>
</tr>
<tr style=""height:2px"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"" style="";;"">Languages by country</th>
<td style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;;;"" class=""navbox-list navbox-even"">
<div style=""padding:0em 0.25em""><a href=""/wiki/List_of_official_languages"" title=""List of official languages"">Official languages</a> (<a href=""/wiki/List_of_official_languages_by_state"" title=""List of official languages by state"">by state</a>)</div>
</td>
</tr>
<tr style=""height:2px"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"" style="";;"">Unions based on language</th>
<td style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;;;"" class=""navbox-list navbox-odd"">
<div style=""padding:0em 0.25em""><a href=""/wiki/Arab_League"" title=""Arab League"">Arab League</a> (Arabic)&#160;<b>·</b> <span class=""nowrap""><a href=""/wiki/Dutch_Language_Union"" title=""Dutch Language Union"">Dutch Union</a> (Dutch)&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Organisation_internationale_de_la_Francophonie"" title=""Organisation internationale de la Francophonie"">Francophonie</a> (French)&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Latin_Union"" title=""Latin Union"">Latin Union</a> (Romance languages)&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Hispanophone"" title=""Hispanophone"">Hispanophone</a>, <a href=""/wiki/Hispanidad"" title=""Hispanidad"">Hispanidad</a> (Spanish)&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Community_of_Portuguese_Language_Countries"" title=""Community of Portuguese Language Countries"">CPLP</a>, <a href=""/wiki/Portuguese-speaking_African_countries"" title=""Portuguese-speaking African countries"">PALOP</a> (Portuguese)&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Joint_Administration_of_Turkic_Arts_and_Culture"" title=""Joint Administration of Turkic Arts and Culture"">TÜRKSOY</a>/<a href=""/wiki/Turkic_Council"" title=""Turkic Council"">Turkic Council</a> (Turkic languages)</span></div>
</td>
</tr>
<tr style=""height:2px"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"" style="";;"">Countries by language</th>
<td style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;;;"" class=""navbox-list navbox-even"">
<div style=""padding:0em 0.25em""></div>
<table cellspacing=""0"" class=""nowraplinks navbox-subgroup"" style=""border-spacing:0;;;;"">
<tr>
<td colspan=""2"" style=""width:100%;padding:0px;padding:0.15em 0; line-height:1.4em;;;"" class=""navbox-list navbox-odd"">
<div style=""padding:0em 0.25em""><a href=""/wiki/List_of_countries_by_spoken_languages"" title=""List of countries by spoken languages"">Countries by spoken languages</a></div>
</td>
</tr>
<tr style=""height:2px"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"" style="";padding-left:0em;padding-right:0em;font-weight:normal;;"">
<div style=""padding:0em 0.75em;"">by <a href=""/wiki/Official_language"" title=""Official language"">official language</a></div>
</th>
<td style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;padding:0.15em 0; line-height:1.4em;;;"" class=""navbox-list navbox-even"">
<div style=""padding:0em 0.25em""><span class=""nowrap""><a href=""/wiki/List_of_countries_where_Arabic_is_an_official_language"" title=""List of countries where Arabic is an official language"">Arabic</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/List_of_countries_where_English_is_an_official_language"" title=""List of countries where English is an official language"">English</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/List_of_countries_where_French_is_an_official_language"" title=""List of countries where French is an official language"">French</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/List_of_countries_where_Portuguese_is_an_official_language"" title=""List of countries where Portuguese is an official language"" class=""mw-redirect"">Portuguese</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/List_of_countries_where_Russian_is_an_official_language"" title=""List of countries where Russian is an official language"">Russian</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/List_of_countries_where_Spanish_is_an_official_language"" title=""List of countries where Spanish is an official language"">Spanish</a></span></div>
</td>
</tr>
<tr style=""height:2px"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"" style="";padding-left:0em;padding-right:0em;font-weight:normal;;"">
<div style=""padding:0em 0.75em;""><a href=""/wiki/Exonym_and_endonym"" title=""Exonym and endonym"">Endonyms</a></div>
</th>
<td style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;padding:0.15em 0; line-height:1.4em;;;"" class=""navbox-list navbox-odd"">
<div style=""padding:0em 0.25em""><a href=""/wiki/List_of_countries_and_capitals_in_native_languages"" title=""List of countries and capitals in native languages"">Countries and capitals in native languages</a>&#160;<span style=""font-weight:bold;"">·</span>  <a href=""/wiki/List_of_countries_by_native_names"" title=""List of countries by native names"" class=""mw-redirect"">Countries by native names</a></div>
</td>
</tr>
<tr style=""height:2px"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"" style="";padding-left:0em;padding-right:0em;font-weight:normal;;"">
<div style=""padding:0em 0.75em;""><a href=""/wiki/Exonym_and_endonym"" title=""Exonym and endonym"">Exonyms</a></div>
</th>
<td style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;padding:0.15em 0; line-height:1.4em;;;"" class=""navbox-list navbox-even"">
<div style=""padding:0em 0.25em""><span class=""nowrap""><a href=""/wiki/List_of_country_names_in_various_languages"" title=""List of country names in various languages"">Country names in various languages</a> (<a href=""/wiki/List_of_country_names_in_various_languages_(A%E2%80%93C)"" title=""List of country names in various languages (A–C)"">A–C</a>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/List_of_country_names_in_various_languages_(D%E2%80%93I)"" title=""List of country names in various languages (D–I)"">D–I</a>&#160;<b>·</b></span> <span class=""nowrap""><strong class=""selflink"">J–P</strong>&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/List_of_country_names_in_various_languages_(Q%E2%80%93Z)"" title=""List of country names in various languages (Q–Z)"">Q–Z</a>)&#160;<b>·</b></span> <span class=""nowrap""><a href=""/wiki/Languages_of_the_European_Union"" title=""Languages of the European Union"">Languages of the European Union</a></span></div>
</td>
</tr>
</table>
</td>
</tr>
<tr style=""height:2px"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"" style="";;"">Languages by population</th>
<td style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;;;"" class=""navbox-list navbox-odd"">
<div style=""padding:0em 0.25em""><a href=""/wiki/List_of_languages_by_number_of_native_speakers"" title=""List of languages by number of native speakers"">by number of native speakers</a></div>
</td>
</tr>
<tr style=""height:2px"">
<td></td>
</tr>
<tr>
<th scope=""row"" class=""navbox-group"" style="";;"">Languages by <a href=""/wiki/Language_family"" title=""Language family"">family</a></th>
<td style=""text-align:left;border-left-width:2px;border-left-style:solid;width:100%;padding:0px;;;"" class=""navbox-list navbox-even"">
<div style=""padding:0em 0.25em""><a href=""/wiki/List_of_language_families"" title=""List of language families"">language families</a></div>
</td>
</tr>
</table>
</td>
</tr>
</table>


<!-- 
NewPP limit report
Preprocessor node count: 1010/1000000
Post-expand include size: 38854/2048000 bytes
Template argument size: 19268/2048000 bytes
Expensive parser function count: 0/500
-->

<!-- Saved in parser cache with key enwiki:pcache:idhash:2922628-0!*!0!!*!*!* and timestamp 20120318143807 -->
</div>				<!-- /bodycontent -->
								<!-- printfooter -->
				<div class=""printfooter"">
				Retrieved from ""<a href=""http://en.wikipedia.org/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;oldid=476812101"">http://en.wikipedia.org/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;oldid=476812101</a>""				</div>
				<!-- /printfooter -->
												<!-- catlinks -->
				<div id='catlinks' class='catlinks'><div id=""mw-normal-catlinks"" class=""mw-normal-catlinks""><a href=""/wiki/Special:Categories"" title=""Special:Categories"">Categories</a>: <ul><li><a href=""/wiki/Category:Countries-languages-related_lists"" title=""Category:Countries-languages-related lists"">Countries-languages-related lists</a></li><li><a href=""/wiki/Category:Lists_of_country_names"" title=""Category:Lists of country names"">Lists of country names</a></li><li><a href=""/wiki/Category:Language_comparison"" title=""Category:Language comparison"">Language comparison</a></li></ul></div></div>				<!-- /catlinks -->
												<div class=""visualClear""></div>
				<!-- debughtml -->
								<!-- /debughtml -->
			</div>
			<!-- /bodyContent -->
		</div>
		<!-- /content -->
		<!-- header -->
		<div id=""mw-head"" class=""noprint"">
			
<!-- 0 -->
<div id=""p-personal"" class="""">
	<h5>Personal tools</h5>
	<ul>
		<li id=""pt-login""><a href=""/w/index.php?title=Special:UserLogin&amp;returnto=List+of+country+names+in+various+languages+%28J-P%29"" title=""You are encouraged to log in; however, it is not mandatory. [o]"" accesskey=""o"">Log in / create account</a></li>
	</ul>
</div>

<!-- /0 -->
			<div id=""left-navigation"">
				
<!-- 0 -->
<div id=""p-namespaces"" class=""vectorTabs"">
	<h5>Namespaces</h5>
	<ul>
					<li  id=""ca-nstab-main"" class=""selected""><span><a href=""/wiki/List_of_country_names_in_various_languages_(J%E2%80%93P)""  title=""View the content page [c]"" accesskey=""c"">Article</a></span></li>
					<li  id=""ca-talk""><span><a href=""/wiki/Talk:List_of_country_names_in_various_languages_(J%E2%80%93P)""  title=""Discussion about the content page [t]"" accesskey=""t"">Talk</a></span></li>
			</ul>
</div>

<!-- /0 -->

<!-- 1 -->
<div id=""p-variants"" class=""vectorMenu emptyPortlet"">
	<h4>
		</h4>
	<h5><span>Variants</span><a href=""#""></a></h5>
	<div class=""menu"">
		<ul>
					</ul>
	</div>
</div>

<!-- /1 -->
			</div>
			<div id=""right-navigation"">
				
<!-- 0 -->
<div id=""p-views"" class=""vectorTabs"">
	<h5>Views</h5>
	<ul>
					<li id=""ca-view"" class=""selected""><span><a href=""/wiki/List_of_country_names_in_various_languages_(J%E2%80%93P)"" >Read</a></span></li>
					<li id=""ca-edit""><span><a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=edit""  title=""You can edit this page. &#10;Please use the preview button before saving. [e]"" accesskey=""e"">Edit</a></span></li>
					<li id=""ca-history"" class=""collapsible""><span><a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;action=history""  title=""Past versions of this page [h]"" accesskey=""h"">View history</a></span></li>
			</ul>
</div>

<!-- /0 -->

<!-- 1 -->
<div id=""p-cactions"" class=""vectorMenu emptyPortlet"">
	<h5><span>Actions</span><a href=""#""></a></h5>
	<div class=""menu"">
		<ul>
					</ul>
	</div>
</div>

<!-- /1 -->

<!-- 2 -->
<div id=""p-search"">
	<h5><label for=""searchInput"">Search</label></h5>
	<form action=""/w/index.php"" id=""searchform"">
				<div id=""simpleSearch"">
						<input type=""text"" name=""search"" value="""" title=""Search Wikipedia [f]"" accesskey=""f"" id=""searchInput"" />						<button type=""submit"" name=""button"" title=""Search Wikipedia for this text"" id=""searchButton""><img src=""//bits.wikimedia.org/skins-1.19/vector/images/search-ltr.png?303-4"" alt=""Search"" /></button>								<input type='hidden' name=""title"" value=""Special:Search""/>
		</div>
	</form>
</div>

<!-- /2 -->
			</div>
		</div>
		<!-- /header -->
		<!-- panel -->
			<div id=""mw-panel"" class=""noprint"">
				<!-- logo -->
					<div id=""p-logo""><a style=""background-image: url(//upload.wikimedia.org/wikipedia/en/b/bc/Wiki.png);"" href=""/wiki/Main_Page""  title=""Visit the main page""></a></div>
				<!-- /logo -->
				
<!-- navigation -->
<div class=""portal"" id='p-navigation'>
	<h5>Navigation</h5>
	<div class=""body"">
		<ul>
			<li id=""n-mainpage-description""><a href=""/wiki/Main_Page"" title=""Visit the main page [z]"" accesskey=""z"">Main page</a></li>
			<li id=""n-contents""><a href=""/wiki/Portal:Contents"" title=""Guides to browsing Wikipedia"">Contents</a></li>
			<li id=""n-featuredcontent""><a href=""/wiki/Portal:Featured_content"" title=""Featured content – the best of Wikipedia"">Featured content</a></li>
			<li id=""n-currentevents""><a href=""/wiki/Portal:Current_events"" title=""Find background information on current events"">Current events</a></li>
			<li id=""n-randompage""><a href=""/wiki/Special:Random"" title=""Load a random article [x]"" accesskey=""x"">Random article</a></li>
			<li id=""n-sitesupport""><a href=""//wikimediafoundation.org/wiki/Special:Landingcheck?landing_page=WMFJA085&amp;language=en&amp;utm_source=donate&amp;utm_medium=sidebar&amp;utm_campaign=20101204SB002"" title=""Support us"">Donate to Wikipedia</a></li>
		</ul>
	</div>
</div>

<!-- /navigation -->

<!-- SEARCH -->

<!-- /SEARCH -->

<!-- interaction -->
<div class=""portal"" id='p-interaction'>
	<h5>Interaction</h5>
	<div class=""body"">
		<ul>
			<li id=""n-help""><a href=""/wiki/Help:Contents"" title=""Guidance on how to use and edit Wikipedia"">Help</a></li>
			<li id=""n-aboutsite""><a href=""/wiki/Wikipedia:About"" title=""Find out about Wikipedia"">About Wikipedia</a></li>
			<li id=""n-portal""><a href=""/wiki/Wikipedia:Community_portal"" title=""About the project, what you can do, where to find things"">Community portal</a></li>
			<li id=""n-recentchanges""><a href=""/wiki/Special:RecentChanges"" title=""A list of recent changes in the wiki [r]"" accesskey=""r"">Recent changes</a></li>
			<li id=""n-contact""><a href=""/wiki/Wikipedia:Contact_us"" title=""How to contact Wikipedia"">Contact Wikipedia</a></li>
		</ul>
	</div>
</div>

<!-- /interaction -->

<!-- TOOLBOX -->
<div class=""portal"" id='p-tb'>
	<h5>Toolbox</h5>
	<div class=""body"">
		<ul>
			<li id=""t-whatlinkshere""><a href=""/wiki/Special:WhatLinksHere/List_of_country_names_in_various_languages_(J%E2%80%93P)"" title=""List of all English Wikipedia pages containing links to this page [j]"" accesskey=""j"">What links here</a></li>
			<li id=""t-recentchangeslinked""><a href=""/wiki/Special:RecentChangesLinked/List_of_country_names_in_various_languages_(J%E2%80%93P)"" title=""Recent changes in pages linked from this page [k]"" accesskey=""k"">Related changes</a></li>
			<li id=""t-upload""><a href=""/wiki/Wikipedia:Upload"" title=""Upload files [u]"" accesskey=""u"">Upload file</a></li>
			<li id=""t-specialpages""><a href=""/wiki/Special:SpecialPages"" title=""A list of all special pages [q]"" accesskey=""q"">Special pages</a></li>
			<li id=""t-permalink""><a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;oldid=476812101"" title=""Permanent link to this revision of the page"">Permanent link</a></li>
<li id=""t-cite""><a href=""/w/index.php?title=Special:Cite&amp;page=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;id=476812101"" title=""Information on how to cite this page"">Cite this page</a></li>		</ul>
	</div>
</div>

<!-- /TOOLBOX -->

<!-- coll-print_export -->
<div class=""portal"" id='p-coll-print_export'>
	<h5>Print/export</h5>
	<div class=""body"">
		<ul id=""collectionPortletList""><li id=""coll-create_a_book""><a href=""/w/index.php?title=Special:Book&amp;bookcmd=book_creator&amp;referer=List+of+country+names+in+various+languages+%28J%E2%80%93P%29"" title=""Create a book or page collection"" rel=""nofollow"">Create a book</a></li><li id=""coll-download-as-rl""><a href=""/w/index.php?title=Special:Book&amp;bookcmd=render_article&amp;arttitle=List+of+country+names+in+various+languages+%28J%E2%80%93P%29&amp;oldid=476812101&amp;writer=rl"" title=""Download a PDF version of this wiki page"" rel=""nofollow"">Download as PDF</a></li><li id=""t-print""><a href=""/w/index.php?title=List_of_country_names_in_various_languages_(J%E2%80%93P)&amp;printable=yes"" title=""Printable version of this page [p]"" accesskey=""p"">Printable version</a></li></ul>	</div>
</div>

<!-- /coll-print_export -->

<!-- LANGUAGES -->
<div class=""portal"" id='p-lang'>
	<h5>Languages</h5>
	<div class=""body"">
		<ul>
			<li class=""interwiki-af""><a href=""//af.wikipedia.org/wiki/Lys_van_landname_in_verskeie_tale_(J-P)"" title=""Lys van landname in verskeie tale (J-P)"" lang=""af"" hreflang=""af"">Afrikaans</a></li>
			<li class=""interwiki-tr""><a href=""//tr.wikipedia.org/wiki/De%C4%9Fi%C5%9Fik_dillerde_%C3%BClke_adlar%C4%B1_(J-P)"" title=""Degisik dillerde ülke adlari (J-P)"" lang=""tr"" hreflang=""tr"">Türkçe</a></li>
		</ul>
	</div>
</div>

<!-- /LANGUAGES -->
			</div>
		<!-- /panel -->
		<!-- footer -->
		<div id=""footer"">
							<ul id=""footer-info"">
											<li id=""footer-info-lastmod""> This page was last modified on 14 February 2012 at 10:44.<br /></li>
											<li id=""footer-info-copyright"">Text is available under the <a rel=""license"" href=""//en.wikipedia.org/wiki/Wikipedia:Text_of_Creative_Commons_Attribution-ShareAlike_3.0_Unported_License"">Creative Commons Attribution-ShareAlike License</a><a rel=""license"" href=""//creativecommons.org/licenses/by-sa/3.0/"" style=""display:none;""></a>;
additional terms may apply.
See <a href=""//wikimediafoundation.org/wiki/Terms_of_use"">Terms of use</a> for details.<br/>
Wikipedia&reg; is a registered trademark of the <a href=""//www.wikimediafoundation.org/"">Wikimedia Foundation, Inc.</a>, a non-profit organization.<br /></li><li class=""noprint""><a class='internal' href=""//en.wikipedia.org/wiki/Wikipedia:Contact_us"">Contact us</a></li>
									</ul>
							<ul id=""footer-places"">
											<li id=""footer-places-privacy""><a href=""//wikimediafoundation.org/wiki/Privacy_policy"" title=""wikimedia:Privacy policy"">Privacy policy</a></li>
											<li id=""footer-places-about""><a href=""/wiki/Wikipedia:About"" title=""Wikipedia:About"">About Wikipedia</a></li>
											<li id=""footer-places-disclaimer""><a href=""/wiki/Wikipedia:General_disclaimer"" title=""Wikipedia:General disclaimer"">Disclaimers</a></li>
											<li id=""footer-places-mobileview""><a href='/w/index.php?title=List_of_country_names_in_various_languages_(J-P)&amp;useformat=mobile' class='noprint'>Mobile view</a></li>
									</ul>
										<ul id=""footer-icons"" class=""noprint"">
					<li id=""footer-copyrightico"">
						<a href=""//wikimediafoundation.org/""><img src=""//bits.wikimedia.org/images/wikimedia-button.png"" width=""88"" height=""31"" alt=""Wikimedia Foundation""/></a>
					</li>
					<li id=""footer-poweredbyico"">
						<a href=""//www.mediawiki.org/""><img src=""//bits.wikimedia.org/skins-1.19/common/images/poweredby_mediawiki_88x31.png"" alt=""Powered by MediaWiki"" width=""88"" height=""31"" /></a>
					</li>
				</ul>
						<div style=""clear:both""></div>
		</div>
		<!-- /footer -->
		<script src=""//bits.wikimedia.org/en.wikipedia.org/load.php?debug=false&amp;lang=en&amp;modules=skins.vector&amp;only=scripts&amp;skin=vector&amp;*"" type=""text/javascript""></script>
<script type=""text/javascript"">if(window.mw){
mw.loader.load([""mediawiki.user"",""mediawiki.page.ready"",""mediawiki.legacy.mwsuggest"",""ext.gadget.teahouse"",""ext.vector.collapsibleNav"",""ext.vector.collapsibleTabs"",""ext.vector.editWarning"",""ext.vector.simpleSearch"",""ext.UserBuckets"",""ext.articleFeedback.startup"",""ext.articleFeedbackv5.startup"",""ext.markAsHelpful""], null, true);
}</script>
<script src=""/w/index.php?title=Special:BannerController&amp;cache=/cn.js&amp;303-4"" type=""text/javascript""></script>
<script src=""//bits.wikimedia.org/en.wikipedia.org/load.php?debug=false&amp;lang=en&amp;modules=site&amp;only=scripts&amp;skin=vector&amp;*"" type=""text/javascript""></script>
<script src=""//geoiplookup.wikimedia.org/"" type=""text/javascript""></script><!-- Served by mw36 in 0.129 secs. -->
	</body>
</html>
";
    }
}