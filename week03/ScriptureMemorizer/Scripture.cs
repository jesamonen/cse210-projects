using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new List<Word>();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;

            // Split the string text into individual words
            string[] allWords = text.Split(' ');
            foreach (string wordText in allWords)
            {
                _words.Add(new Word(wordText));
            }
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            int wordsHiddenThisTurn = 0;

            // Simple loop to try hiding words until the target count is reached
            // or until the scripture is completely hidden.
            while (wordsHiddenThisTurn < numberToHide && !IsCompletelyHidden())
            {
                int randomIndex = random.Next(_words.Count);
                
                // Only hide it if it isn't already hidden (Stretch requirement)
                if (!_words[randomIndex].IsHidden())
                {
                    _words[randomIndex].Hide();
                    wordsHiddenThisTurn++;
                }
            }
        }

        public string GetDisplayText()
        {
            List<string> textPieces = new List<string>();
            foreach (Word word in _words)
            {
                textPieces.Add(word.GetDisplayText());
            }

            // Joins the list of text pieces back into a single readable paragraph
            return $"{_reference.GetDisplayText()} - {string.Join(" ", textPieces)}";
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    return false; // Found a word still showing
                }
            }
            return true;
        }
    }
}