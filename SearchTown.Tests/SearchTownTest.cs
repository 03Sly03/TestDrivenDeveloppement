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
        private Search _searchTown;

        private List<string> TownsList { get; set; } = new List<string>()
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
        };

        [TestInitialize]
        public void SetUp()
        {
            _searchTown = new Search();
        }

        [TestCleanup]
        public void CleanUp()
        {
            _searchTown = null;
        }

        [TestMethod]
        public void TestSearch_LessThan2Char_ShouldBe_NotFoundException()
        {
            Assert.ThrowsException<NotFoundException>(() => _searchTown.GetTowns("ab", TownsList));
        }
    }
}
