using System;
using System.Windows;

class Scripture
{
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();
    private string _content = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    string variable = "";
    private Random rand = new Random();
    string[] words = new string[] {};
  

    public Scripture()
    {
        do
        {
            ShowScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            variable = Console.ReadLine();
            if (variable != "quit")
            {
                HideWords();
            }

        } while (variable != "quit");
    }

    private void HideWords()
    {
        _words.Clear();
        words = _content.Split(" ");
        foreach (string word in words)
        {
            Word _tempWord = new Word(word);
            _words.Add(_tempWord);
        }
        for (int i = 0; i < 3; i++)
        {
            int _index = rand.Next(_words.Count);
            Console.WriteLine(_words.Count);
            Console.WriteLine(_index);
            _words[_index]._word = "_";
            
        }
        _content = String.Join(", ", _words);
    }

    private void ShowScripture()
    {
        Console.Clear();
        Console.WriteLine(_content);
    }



}