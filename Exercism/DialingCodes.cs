using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    class DialingCodes
    {
        public static Dictionary<int, string> GetEmptyDictionary() => new();
        

        public static Dictionary<int, string> GetExistingDictionary() => new Dictionary<int, string>
        {
            {1, "United States of America"},
            {55, "Brazil"},
            {91, "India" }
        };


        public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
        {
            var newDict = GetEmptyDictionary();
            newDict.Add(countryCode, countryName);
            return newDict;
        }

        public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
        }

        public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
        {
            if (existingDictionary.TryGetValue(countryCode, out string result))
            {
                return result;
            }
            else
                result = string.Empty;

            return result;
        }

        public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.ContainsKey(countryCode);

        public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
        {
            if (existingDictionary.ContainsKey(countryCode))
            {
                existingDictionary[countryCode] = countryName;
            }
            
            return existingDictionary;
        }

        public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
        {
            existingDictionary.Remove(countryCode);
            return existingDictionary;
        }

        public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
        {
            string longestCountry = string.Empty;

            if (existingDictionary.Count != 0)
            {
                longestCountry = existingDictionary.Values.Max();
            }
           
            return longestCountry;
        }
            
       
    }
}
