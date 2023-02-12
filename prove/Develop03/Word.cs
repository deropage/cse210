using System;

class Word
{
    private string _word = "";

    public Word ()
    {
    }

    public Word (string word)                                        //Words can be created with a string that will direclty run the HideLetters method with given string.
    {
        HideLetters(word);
    }

    public string HideLetters(string word)
    {
        _word = word.Replace(word, new string('_',word.Length));   //Changing all the letters in the word to "_" and returning the new word
        return _word;
    }
    public string GetWord ()                                       //Getter for word
    {
        return _word;
    }
}