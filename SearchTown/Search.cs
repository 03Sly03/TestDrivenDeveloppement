using SearchTown.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<string> newTownsList = new List<string>();
            if (word.Length < 2)
                throw new NotFoundException();
            foreach (var town in TownsList)
            {
                if (town.ToLower().StartsWith(word.ToLower()))
                    newTownsList.Add(town);
            }
            return newTownsList;
        }
    }
}
