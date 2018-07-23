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

    }
}
