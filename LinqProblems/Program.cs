using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Problems problems = new Problems();


            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            problems.FindPhraseInString(words, "th");






            Console.ReadLine();
          
        }
    }
}
