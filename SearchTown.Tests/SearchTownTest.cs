using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTown.Tests
{
    [TestClass]
    public class SearchTownTest
    {
        private List<string> townsList = new List<string>()
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
        };

        [TestMethod]
        public void TestSearch_LessThan2Char_ShouldBe_NotFoundException()
        {
            Search searchTown = new Search();
            Assert.ThrowsException<NotFoundException>(() => searchTown.GetTowns("ab", townsList));
        }
    }
}
