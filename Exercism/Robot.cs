using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public class Robot
    {
        private static List<string> namesList = new();
        public string Name { get; set; }
        
        public Robot()
        {
            Reset();
        }
        public string GetTwoRandomLetters()
        {
            Random firstRandomLetter = new();
            Random secondRandomLetter = new();

            int uppercaseLetterIndex1 = firstRandomLetter.Next(65, 91);
            int uppercaseLetterIndex2 = secondRandomLetter.Next(65, 91);

            char[] lettersForName = new char[] { Convert.ToChar(uppercaseLetterIndex1), Convert.ToChar(uppercaseLetterIndex2) };
            string twoRandomLetters = new string(lettersForName);
            return twoRandomLetters;
        }

        public int GetRandomThreeDigitNumber()
        {
            Random randomNumber = new();
            int randomThreeDigitNum = randomNumber.Next(100,999);
            return randomThreeDigitNum;
        }

        public string GenerateUniqueRandomName()
        {
            bool nameIsUnique = false;
            string newName = string.Empty;
            while (!nameIsUnique)
            {
                newName = $"{GetTwoRandomLetters()}{GetRandomThreeDigitNumber()}";
                nameIsUnique = !namesList.Contains(newName); // if nameslist.contains == false, then name is unqiue == true
            }
            namesList.Add(newName);
            return newName;
        }

        public void Reset()
        {
            Name = GenerateUniqueRandomName();
        }
    }
}
