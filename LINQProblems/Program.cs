using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQClass lINQClass = new LINQClass();
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var newWords = lINQClass.FirsProblem(words);
            foreach(var word in newWords)
            {
                Console.WriteLine(word);
            }
            
            Console.ReadLine();


            List<string> vs = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            vs = lINQClass.second(vs);
        }
    }
}
