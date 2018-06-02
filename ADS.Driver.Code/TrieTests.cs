using System;
using System.Collections.Generic;
using ADS.DataStructure.Implementation.Trie;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADS.Driver.Code
{
    [TestClass]
    public class TrieTests
    {
        [TestMethod]
        public void Trie_Insert_Delete_Update_Search_Test()
        {
            // Arrange
            List<string> SetOfStrings = new List<string>();
            SetOfStrings.Add("pqrs");
            SetOfStrings.Add("pprt");
            SetOfStrings.Add("psst");
            SetOfStrings.Add("ggrs");
            SetOfStrings.Add("pqrs");
            SetOfStrings.Add("pqrst");


            // Act
            Trie trie = new Trie();
            trie.Insert(SetOfStrings);

            // Assert
            Assert.IsTrue(trie.Search("psst"));
            Assert.IsTrue(trie.Search("pqrs"));
            Assert.IsTrue(!trie.Search("abcd"));

            trie.Update("psst", "abcd");
            Assert.IsTrue(!trie.Search("psst"));
            Assert.IsTrue(trie.Search("abcd"));

            trie.Delete("pqrs");
            Assert.IsTrue(!trie.Search("pqrs"));

            trie.Insert("rushang");
            trie.Insert("chauhan");
            Assert.IsTrue(trie.Search("rushang"));
            Assert.IsTrue(trie.Search("chauhan"));
        }
    }
}
