using System;
using System.IO;
using System.Xml.Linq;
using CountryStuff.Entities;

namespace CountriesToXml
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (CountryContext context = new CountryContext())
            {
                Console.WriteLine("Starting COUNTREE outputterator...");
                XDocument countryList = new XDocument();
                countryList.Add(new XElement("countries"));
                AddCountries(countryList.Root, context);
                SaveToLocalFile(countryList);
                Console.WriteLine("Done - Hit <ENTER>");
                Console.ReadLine();
            }
        }

        private static void SaveToLocalFile(XDocument countryList)
        {
            string path = Environment.CurrentDirectory + "\\countries.xml";
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                countryList.Save(fileStream);
                Console.WriteLine("Output xml saved to "+ path);
            }
        }

        private static void AddCountries(XElement countryList, CountryContext context)
        {
            foreach (var country in context.Countries)
            {
                XElement xCountry = new XElement("country");
                xCountry.Add(new XAttribute("name", country.EnglishName));
                AddVariants(xCountry, country);

                countryList.Add(xCountry);
            }
        }

        private static void AddVariants(XElement xCountry, Country country)
        {
            foreach (var variant in country.Variants)
            {
                XElement xVariant = new XElement("variant");
                xVariant.Add(new XAttribute("name", variant.Name));

                AddLanguages(xVariant, variant);

                xCountry.Add(xVariant);
            }
        }

        private static void AddLanguages(XElement xVariant, Variant variant)
        {
            foreach (var language in variant.Languages)
            {
                XElement xLanguage = new XElement("language");
                xLanguage.Add(new XAttribute("name", language.Name));
                xVariant.Add(xLanguage);
            }
        }
    }
}