using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Book_Titles
{
    public class Book
    {
        string title = "";
        
        public string Title
        {
            get
            {
                return FormatTitle(title);
            }
            set
            {
                title = value;
            }
        }

        public string FormatTitle(string titleString)
        {
            string[] titleWords = titleString.Split(' ');
            string newTitle = "";

            foreach(string word in titleWords)
            {
                newTitle += FormatWord(word) + " ";
            }

            newTitle = CapitalizeFirstLetter(newTitle);
            return newTitle.Trim();
        }

        public string FormatWord(string word)
        {
            string[] smallWords = { "in", "the", "a", "an", "and", "of" };
            bool shouldCap = true;

            foreach(string sWord in smallWords)
            {
                if(word == sWord)
                {
                    shouldCap = false;
                    break;
                }
            }

            if (!shouldCap)
                return word;

            return CapitalizeFirstLetter(word);
        }

        public string CapitalizeFirstLetter(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1);
        }
    }
}
