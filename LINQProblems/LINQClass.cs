using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class LINQClass
    {
        public LINQClass()
        {}

        public IEnumerable<string> FirsProblem(List<string> words)
        {
            return words.Where(w => w.Any(x => w.Contains("th")));
        }

        public List<string> SecondProblem(List<string> names)
        {
            return names.Select(n => n).Distinct().ToList();
        }

        public double ThirdProblem(List<string> grades) 
        {

            //First Cast to double all of the things in this collection;
            //for each field, drop the min value, and average the rest;
            //average the collection;



            /*
             SLECT * from ListName
             where 
             */

            //var average = grades.Select(g => g.Split(',').Select(s => Convert.ToDouble(s)).Select(o => g.Where(p => p!= g.Min())));
            var split = grades.Select(g => g.Split(',').Select(s => Convert.ToDouble(s)));
            var split2 = split.Select(s => s.Where(x => x!= s.Min()));
            var split3 = grades.Select(a => a.Split(',').Select(b => Convert.ToDouble(b))).Select(c => c.Where(d => d != c.Min()));


            
            
            
            Console.ReadLine();
            
            return 10.0;
        }
    }
}
