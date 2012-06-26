using System.IO;
using HtmlAgilityPack;

namespace CountryStuff
{
    public interface IHtmlService
    {
        HtmlDocument GetWebPage(string url);
    }
}