using System.Collections.Generic;
using System.Linq;

/// <summary>
/// ParsingApp
/// </summary>
namespace ParsingApp
{
    /// <summary>
    /// WordParser
    /// </summary>
    public static class WordParser
    {
        /// <summary>
        /// Read the incoming Sentence
        ///     --  and keep it in a list of strings
        /// </summary>
        /// <param name="mySentence"></param>
        /// <returns></returns>
        public static List<string> ReadSentence(string mySentence)
        {
            List<string> myList = new List<string>();
            string[] substrings = mySentence.Split(' ', '\n');

            foreach (var item in substrings)
            {
                myList.Add(item);
            }
            return myList;
        }

        /// <summary>
        /// Convert Word After Rules
        /// </summary>
        /// <param name="myWord"></param>
        /// <returns></returns>
        public static string ConvertWordAfterRules(string myWord)
        {
            myWord = myWord.Trim();
            string convetredWord = string.Empty;
            string firstLetter = string.Empty;
            string lastLetter = string.Empty;
            string midString = string.Empty;
            int midNumber = 0;
            int midPosStart = 0;
            int midPosEnd = 0;
            int wLength = myWord.Length;

            // first letter
            for (int posCounterFirst = 0; posCounterFirst < wLength; posCounterFirst++)
            {
                if (char.IsLetter(myWord[posCounterFirst]))
                {
                    firstLetter = myWord.Substring(0, posCounterFirst + 1);
                    midPosStart = posCounterFirst + 1;
                    break;
                }
            }

            // last letter
            for (int posCounterLast = 1; posCounterLast <= wLength; posCounterLast++)
            {
                if (char.IsLetter(myWord[wLength - posCounterLast]))
                {
                    lastLetter = myWord.Substring(wLength - posCounterLast, posCounterLast);
                    midPosEnd = wLength - posCounterLast;
                    break;
                }
            }

            // mid string distinct count
            if (wLength > 2)
            {
                midString = myWord.Substring(midPosStart, midPosEnd - midPosStart);
                midNumber = midString.Distinct().Count();
            }

            convetredWord = firstLetter + midNumber.ToString() + lastLetter;
            return convetredWord;
        }

        /// <summary>
        /// start_Processing
        /// </summary>
        /// <param name="mySentence"></param>
        /// <returns></returns>
        public static string start_Processing(string mySentence)
        {
            string newSentence = string.Empty;
            List<string> allWords = WordParser.ReadSentence(mySentence);

            foreach (var item in allWords)
            {
                newSentence = newSentence + WordParser.ConvertWordAfterRules(item) + " ";
            }

            return newSentence.Trim();
        }

    }
}