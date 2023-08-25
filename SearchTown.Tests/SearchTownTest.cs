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
            Assert.ThrowsException<NotFoundException>(() => _searchTown.GetTowns("a"));
        }

        [TestMethod]
        public void TestSearch_moreThanOrEqual2_SchouldContain_List_Paris()
        {
            List<string> expected = new List<string>() { "Paris" };
            List<string> result = _searchTown.GetTowns("Pa");
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSearch_NotCaseSensitive_SchouldContain_List_Paris()
        {
            List<string> expected = new List<string>() { "Paris" };
            List<string> result = _searchTown.GetTowns("pa");
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSearch_PartOfName_ShouldContain_List_Budapest()
        {
            List<string> expected = new List<string>() { "Budapest" };
            List<string> result = _searchTown.GetTowns("ape");
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSearch_SpecialChar_ShouldContain_List_AllTowns()
        {
            List<string> expected = new List<string>()
            {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
            };
            List<string> result = _searchTown.GetTowns("*");
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
