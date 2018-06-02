using System;

namespace ADS.DataStructure.Implementation.Trie
{
    public class TrieNode
    {
        private static readonly int ALPHABET_SIZE = 26;
        public TrieNode[] Children;
        public Boolean IsEndOfWord;

        public TrieNode()
        {
            Children = new TrieNode[ALPHABET_SIZE];
            IsEndOfWord = false;
        }

        public TrieNode Next(char C)
        {
            return Children[C - 'a'];
        }
    }
}
