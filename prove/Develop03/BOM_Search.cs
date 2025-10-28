using System;
using System.Collections.Generic;
using System.IO;

namespace ScriptureMemorizer
{
    public class ScriptureLibrary
    {
        private List<Scripture> _scriptures;
        private Random _random;

        public ScriptureLibrary(string filename)
        {
            _scriptures = new List<Scripture>();
            _random = new Random();
            LoadScripturesFromTxt(filename);
        }

        private void LoadScripturesFromTxt(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            int index = 0;

            while (index < lines.Length)
            {
                string referenceLine = lines[index];

                if (string.IsNullOrWhiteSpace(referenceLine))
                {
                    index++;
                    continue;
                }

                if (index + 1 >= lines.Length)
                {
                    break; 
                }

                string textLine = lines[index + 1];

                string[] refParts = referenceLine.Split(':');

                if (refParts.Length == 2)
                {
                    string verseStr = refParts[1];
                    int lastSpaceIndex = refParts[0].LastIndexOf(' ');

                    if (lastSpaceIndex != -1)
                    {
                        string book = refParts[0].Substring(0, lastSpaceIndex);
                        string chapterStr = refParts[0].Substring(lastSpaceIndex + 1);

                        if (int.TryParse(chapterStr, out int chapter) && int.TryParse(verseStr, out int verse))
                        {
                            Reference reference = new Reference(book, chapter, verse);
                            Scripture scripture = new Scripture(reference, textLine);
                            _scriptures.Add(scripture);
                        }
                    }
                }
                
                index += 2;
            }
        }

        public Scripture GetRandomScripture()
        {
            if (_scriptures.Count == 0)
            {
                throw new InvalidOperationException("The scripture library is empty or could not be loaded.");
            }

            int index = _random.Next(_scriptures.Count);
            return _scriptures[index];
        }
    }
}