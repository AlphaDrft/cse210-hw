using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] tokens = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string token in tokens)
        {
            _words.Add(new Word(token));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<int> available = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                available.Add(i);
            }
        }

        if (available.Count == 0) return;

        int toHide = Math.Min(numberToHide, available.Count);
        for (int k = 0; k < toHide; k++)
        {
            int pickIndex = _random.Next(available.Count);
            int wordIndex = available[pickIndex];
            _words[wordIndex].Hide();
            available.RemoveAt(pickIndex);
        }
    }

    public string GetDisplayText()
    {
        string refText = _reference.GetDisplayText();
        List<string> parts = new List<string>();
        foreach (Word w in _words)
        {
            parts.Add(w.GetDisplayText());
        }
        string scriptureText = string.Join(" ", parts);
        return $"{refText} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
