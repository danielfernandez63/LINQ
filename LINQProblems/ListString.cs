using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    public class ListString
    {
       public  List<string> wordlist = new List<string>() {"the", "bike", "this", "it", "tenth", "mathematics"};
       public  List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };

        public ListString()
        {
            WordsStartWithTh(wordlist);
            WordsRemoveDuplicates(names);
        }


        public void WordsStartWithTh(List<string> wordString)
        {
            var words = wordString;
            var thWords = words.Where(w=> w.Contains("th"));
            foreach (var word in thWords)
            {
                Console.WriteLine(word);             
            }

            Console.ReadLine();
        }
    
        public void  WordsRemoveDuplicates(List<string> names)
        {
            var words = names;
            var removedWords = words.Distinct();
            foreach(var word in removedWords)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();

        }



    }
}
