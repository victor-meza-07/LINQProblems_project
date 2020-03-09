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
    }
}
