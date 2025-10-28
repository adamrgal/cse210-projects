using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _random = new Random();
            _words = new List<Word>();

            string[] textWords = text.Split(' ');
            foreach (string word in textWords)
            {
                _words.Add(new Word(word));
            }
        }

        public void HideRandomWords(int count)
        {
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
            int wordsToHide = Math.Min(count, visibleWords.Count);

            for (int i = 0; i < wordsToHide; i++)
            {
                int index = _random.Next(visibleWords.Count);
                Word wordToHide = visibleWords[index];

                wordToHide.Hide();
                visibleWords.RemoveAt(index);
            }
        }

        public string GetRenderedText()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(_reference.GetFormattedReference());
            sb.Append(" ");

            foreach (Word word in _words)
            {
                sb.Append(word.GetRenderedText());
                sb.Append(" ");
            }

            return sb.ToString().Trim();
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(w => w.IsHidden());
        }
    }
}