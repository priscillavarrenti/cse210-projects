using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                hiddenCount++;
            }
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }
    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        List<string> wordTexts = new List<string>();
        foreach (Word w in _words)
        {
            wordTexts.Add(w.GetDisplayText());
        }
        string scriptureText = string.Join(" ", wordTexts);

        return referenceText + " " + scriptureText;
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