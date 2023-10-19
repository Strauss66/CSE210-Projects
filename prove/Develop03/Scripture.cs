using System;
using System.Collections.Generic;

public class Scripture
{
    public string _chapter = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    List<Word> words = new List<Word>();
    List<int> hiddenWordIndices = new List<int>(); // Track hidden word indices
    Random random = new Random();

    public void Cutter()
    {
        string[] wordscr = _chapter.Split(' ');

        foreach (var word in wordscr)
        {
            Word newWord = new Word(word);
            words.Add(newWord);
        }
    }

    public int Display()
    {
        int hiddenWordCount = 0;

        for (int i = 0; i < words.Count; i++)
        {
            if (!hiddenWordIndices.Contains(i) && words[i].HideRandomly())
            {
                hiddenWordIndices.Add(i);
                hiddenWordCount++;
            }
            words[i].Display();
        }

        return hiddenWordCount;
    }

    public int GetWordCount()
    {
        return words.Count;
    }
}