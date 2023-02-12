using System;

class Word
{
    public string _word = "";

    public Word (string word)
    {
        _word = word;
    }

    public void HideWord()
    {
        _word = "_";
    }
}