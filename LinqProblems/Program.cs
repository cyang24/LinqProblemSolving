﻿using System;
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



            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            problems.NonDuplicateNamesList(names);

            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
                };

            problems.FindAverageOfAverages(classGrades);

            problems.AlphabeticalStringFrequencyConversion("Terrill");

            Console.ReadLine();
          
        }
    }
}
