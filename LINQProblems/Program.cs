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

            List<string> vs = new List<string> { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };

            Console.WriteLine(lINQClass.ThirdProblem(vs));
        }
    }
}
