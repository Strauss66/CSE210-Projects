using System;
using System.Collections.Generic;

public class Word
{
    private bool _hidden = false;
    private string _content = "";

    public Word(string content)
    {
        _content = content;
    }

    public void Display()
    {
        if (_hidden == true)
        {
            Console.Write(RepeatLinq("_", _content.Length) + " ");
        }
        else
        {
            Console.Write(_content + " ");
        }
    }

    public static string RepeatLinq(string text, int n)
    {
        return new string(text[0], n);
    }

    public bool HideRandomly()
    {
        if (!_hidden)
        {
            Random random = new Random();
            bool shouldHide = random.Next(10) < 3; // 30% chance of hiding
            if (shouldHide)
            {
                _hidden = true;
                return true;
            }
        }
        return false;
    }
}