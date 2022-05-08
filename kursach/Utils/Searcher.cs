using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confectionery.Utils
{
    class Searcher
    {
        private List<string> _words;
        public Searcher(string search)
        {
            _words = new List<string>(
                search.ToLower().Split(new[] { ' ', ',', '.', ';' },
                StringSplitOptions.RemoveEmptyEntries));
        }

        public bool MatchString(string str)
        {
            var lower = str.ToLower();
            var index = _words.FindIndex(w => lower.Contains(w));
            if (index >= 0)
            {
                _words.RemoveAt(index);
                return true;
            }
            return false;
        }
    }
}
