#region

using System;
using System.Linq;
using CountryStuff;
using CountryStuff.Entities;
using HtmlAgilityPack;

#endregion

namespace CountriesPullet
{
    internal class Program
    {
        private static readonly string[] Sitelist = {
                                                        "http://en.wikipedia.org/wiki/List_of_country_names_in_various_languages_(J-P)"
                                                        ,
                                                        "http://en.wikipedia.org/wiki/List_of_country_names_in_various_languages_(D-I)"
                                                        ,
                                                        "http://en.wikipedia.org/wiki/List_of_country_names_in_various_languages_(Q-Z)"
                                                        ,
                                                        "http://en.wikipedia.org/wiki/List_of_country_names_in_various_languages_(A-C)"
                                                    };


        private static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            Console.WriteLine("Set up database");
            Bootstrapper.Setup();
            Console.WriteLine("Finished");

            using (CountryContext countryContext = new CountryContext())
            {


                try
                {
                    IHtmlService service = new HtmlService();


                    foreach (var site in Sitelist)
                    {
                        Console.WriteLine("Loading up page: " + site);
                        HtmlDocument webpage = service.GetWebPage(site);
                        Console.WriteLine("Got website");
                        Console.WriteLine("Strip countries...");
                        var countries = CountryStripper.GetCountries(webpage);
                        Console.WriteLine("Stripped");
                        foreach (Country country in countries)
                        {
                            Console.WriteLine(string.Format("Country: {0}", country.EnglishName));
                            countryContext.Countries.Add(country);
                        }

                        Console.WriteLine("Start Save");
                        countryContext.SaveChanges();
                        Console.WriteLine("Saved!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.Write(ex);
                    Console.WriteLine();
                }


                Console.WriteLine();
                Console.WriteLine("STATS");
                Console.WriteLine("-------------------");
                Console.WriteLine("Countries: " + countryContext.Countries.Count());
                Console.WriteLine("Language Sets: " + countryContext.LanguageSets.Count());
                Console.WriteLine("Languages: " + countryContext.Languages.Count());

            }
            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }
    }
}