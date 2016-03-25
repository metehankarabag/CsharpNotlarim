using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dersler//_81_WhenToUseDictionaryOverList
{

    /* DICTIONARY
     LIST gibi GENERIC kullanılarak oluşturulmuş ve parametre olarak 1. KEY TYPE, 2. OBJECT TYPE bekliyor.
     LIST'deki FIND() methodu liste içinde bir eşleşme olana kadar tüm itemleri arar.
     Sadece LIST'e bakacaksak DICTIONARY kullanmak daha iyidir. Çünkü sadece KEY sütunu üzerinde arama yapar.
    */
    public class _81_WhenToUseDictionaryOverList
    {
        public static void Main()
        {
            #region Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };
            Country country2 = new Country() { Code = "IND", Name = "INDIA ", Capital = "New Delhi" };
            Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C." };
            Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };
            Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

            //List<Country> listCountries = new List<Country>();
            //listCountries.Add(country1);
            //listCountries.Add(country2);
            //listCountries.Add(country3);
            //listCountries.Add(country4);
            //listCountries.Add(country5);

            Dictionary<string, Country> dictionaryCountries = new Dictionary<string, Country>();
            dictionaryCountries.Add(country1.Code, country1);
            dictionaryCountries.Add(country2.Code, country2);
            dictionaryCountries.Add(country3.Code, country3);
            dictionaryCountries.Add(country4.Code, country4);
            dictionaryCountries.Add(country5.Code, country5);
            #endregion

            string strUserChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter country code"); string strCountryCode = Console.ReadLine().ToUpper();
                Country resultCountry = dictionaryCountries.ContainsKey(strCountryCode) ? dictionaryCountries[strCountryCode] : null;
                if (resultCountry == null) Console.WriteLine("The country code you enetered does not exist");
                else Console.WriteLine("Name = " + resultCountry.Name + " Captial =" + resultCountry.Capital);

                do { Console.WriteLine("Do you want to continue - YES or NO?"); strUserChoice = Console.ReadLine().ToUpper(); }
                while (strUserChoice != "NO" && strUserChoice != "YES");
            }
            while (strUserChoice == "YES");
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }
    }
}
