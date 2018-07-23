using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Problems
    {
        
        public void FindPhraseInString(List<string> Words, string phrase)
        {
            var resultList = Words.Where(w => w.Contains(phrase));
            foreach (string result in resultList)
            {
                Console.WriteLine(result);
            }
        }

        public void NonDuplicateNamesList(List<string> names)
        {
            List<string> resultList = names.Distinct().ToList();
            foreach (string result in resultList)
            {
                Console.WriteLine(result);
            }
        }

        public void FindAverageOfAverages(List<string> list)
        {
            var FinalAverage = list.Select(g => g.Split(',')).Select(g => Array.ConvertAll(g, decimal.Parse)).Select(g => (g.Sum() - g.Min()) / (g.Count() - 1)).Average();
            Console.WriteLine(FinalAverage);
        }

        public void AlphabeticalStringFrequencyConversion(String String)
        {
            var counts = String.ToUpper().GroupBy(c => c).OrderBy(c => c.Key).ToDictionary(grp => grp.Key, grp => grp.Count());
            string finalString = "";
            var counts2 = counts.OrderBy(c => c.Key);
            foreach (KeyValuePair<char, int> compression in counts2)
            {
                finalString += compression.Key.ToString() + compression.Value;
            }
            Console.WriteLine(finalString);
        }
    }
}
