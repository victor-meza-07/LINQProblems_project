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
            var notwords = words.Where(w => w.Any(x => w.Contains("th")));
            
            return notwords;
        }
    }
}
