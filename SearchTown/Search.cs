using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace SearchTown
{
    public class Search
    {
        private List<string> TownsList { get; set; } = new List<string>()
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
        };

        public List<string> GetTowns(string word)
        {
            throw new NotImplementedException();
        }
    }
}
