using System;
using System.Collections.Generic;

namespace ADS.DataStructure.Implementation.Trie
{
    public class Trie
    {
        private readonly TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(IEnumerable<string> Keys)
        {
            foreach (string key in Keys)
                Insert(key);
        }

        public void Insert(string Key)
        {
            TrieNode Current = root;

            foreach (char C in Key)
            {
                if (Current.Children[C - 'a'] == null)
                    Current.Children[C - 'a'] = new TrieNode();

                Current = Current.Next(C);
            }

            Current.IsEndOfWord = true;
        }

        public bool Search(string Key)
        {
            TrieNode Current = root;

            foreach (char C in Key)
            {
                if (Current.Children[C - 'a'] == null)
                    return false;

                Current = Current.Next(C);
            }

            return Current.IsEndOfWord;
        }

        public void Delete(string Key)
        {
            TrieNode Current = root;

            foreach (char C in Key)
            {
                if (Current.Children[C - 'a'] == null)
                    throw new ArgumentException("Sepcified key not found!");

                Current = Current.Next(C);
            }

            if (Current.IsEndOfWord)
                Current.IsEndOfWord = false;
            else
                throw new ArgumentException("Sepcified key not found!");
        }

        public void Update(string OldKey, string NewKey)
        {
            if (Search(OldKey))
            {
                Delete(OldKey);
                Insert(NewKey);
            }
            else
                throw new ArgumentException("The specified old key does not exists!"); 
        }
    }
}
