namespace ADS.DataStructure.Implementation.Trie
{
    public class TrieNode
    {
        private static readonly int ALPHABET_SIZE = 26;
        private TrieNode[] children;
        private bool isEndOfWord;

        public TrieNode[] Children { get => children; set => children = value; }
        public bool IsEndOfWord { get => isEndOfWord; set => isEndOfWord = value; }

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
