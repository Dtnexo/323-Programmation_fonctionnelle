using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Words
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Partie 1 : Recherche par critère
            //A. Filtrage basique
            /*
            List<string> words = new List<string> { "bonjouxr", "hello", "monde", "vert", "rouge", "bleu", "jaune" };
            double x = words.Average(p  => p.Length);
            int wordAverage = (int)Math.Round(x);
            List<string> wordList = words.Where(p => p.Length >= 4 && !p.Contains('x') && p.Length == wordAverage).OrderBy(words => words).ToList();
            List<string> wordList2 = words.Where(p => p.Length >= 4 && !p.Contains('x') && p.Length == wordAverage).OrderDescending().ToList();
            wordList.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("-----");
            wordList2.ForEach(p => Console.WriteLine(p));
            */


            //B. Données parasites 1
            /*
            List<string> words = new List<string> { "whatThe!!!", "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune", "My kingdom for a horse !", "Ooops I did it again" };
            List<string> wordList = words.Where(p => p.Length >= 4 && !p.Contains(' ') && !p.Contains('!')).ToList();
            wordList.ForEach(p => Console.WriteLine(p));
            */

            //C.Données parasites 2
            /*
            List<string> words = new List<string> { "+++++", "<<<<<", ">>>>>", "bonjour", "hello", "@@@@", "vert", "rouge", "bleu", "jaune", "#####", "%%%%%%%" };
            Func<string, bool> startWithLetter = word => !Regex.IsMatch(word, "[+<>@#%]");
            List<string> wordList =words.Where(startWithLetter).ToList();
            wordList.ForEach(p => Console.WriteLine(p));
            */

            //D. Élitisme
            /*
            string[] words = { "i am the winner", "hello", "monde", "vert", "rouge", "bleu", "i am the looser" };
            Console.WriteLine("The winner is : "+words.First());
            Console.WriteLine("The looser is : " + words.Last());
            */
            //Partie 2: Epsilon
            List<epsilon> epsilons = new List<epsilon>
            {
                new epsilon { letter = 'A', frequency = 8.15 },
                new epsilon { letter = 'B', frequency = 0.97 },
                new epsilon { letter = 'C', frequency = 3.15 },
                new epsilon { letter = 'D', frequency = 3.73 },
                new epsilon { letter = 'E', frequency = 17.39 },
                new epsilon { letter = 'F', frequency = 1.12 },
                new epsilon { letter = 'G', frequency = 0.97 },
                new epsilon { letter = 'H', frequency = 0.85 },
                new epsilon { letter = 'I', frequency = 7.31 },
                new epsilon { letter = 'J', frequency = 0.45 },
                new epsilon { letter = 'K', frequency = 0.02 },
                new epsilon { letter = 'L', frequency = 5.69 },
                new epsilon { letter = 'M', frequency = 2.87 },
                new epsilon { letter = 'N', frequency = 7.12 },
                new epsilon { letter = 'O', frequency = 5.28 },
                new epsilon { letter = 'P', frequency = 2.80 },
                new epsilon { letter = 'Q', frequency = 1.21 },
                new epsilon { letter = 'R', frequency = 6.64 },
                new epsilon { letter = 'S', frequency = 8.14 },
                new epsilon { letter = 'T', frequency = 7.22 },
                new epsilon { letter = 'U', frequency = 6.38 },
                new epsilon { letter = 'V', frequency = 1.64 },
                new epsilon { letter = 'W', frequency = 0.03 },
                new epsilon { letter = 'X', frequency = 0.41 },
                new epsilon { letter = 'Y', frequency = 0.28 },
                new epsilon { letter = 'Z', frequency = 0.15 }
            };
            string[] words = {"ABA", "AACCS", "DEFG", "HIJKL", "MNOP", "QRSTU", "VWXYZ", "BCADE", "EFGHI", "JKLMN", "OPQRS", "TUVWX", "YZABC"
}; Func<string, string, bool> calculateFrequency = (letter, wordletter) => letter.Contains(wordletter);

            string frequenceWord(List<epsilon> epsls, string[] word)
            {
                foreach (string w in word)
                {
                    int i = 0;
                    epsls = epsls.Where(p => p.letter == w[i]).ToList().ForEach(p => Console.WriteLine(p));
                    i++;
                }
                return "";
            }

        }
        class epsilon
        {
            public char letter { get; set; }
            public double frequency { get; set; }
        }




    }

}