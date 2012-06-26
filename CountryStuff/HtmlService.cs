using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace CountryStuff
{
	public class HtmlService : IHtmlService
	{
		public HtmlDocument GetWebPage(string url)
		{
			WebClient client = new WebClient();
			client.Headers.Add("User-Agent","Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.19 (KHTML, like Gecko) Chrome/18.0.1025.152 Safari/535.19");
			HtmlDocument doc = new HtmlDocument();
			doc.Load(new MemoryStream(client.DownloadData(url)));
			return doc;
		}
	}
}