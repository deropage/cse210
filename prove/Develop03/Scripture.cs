using System;
using System.Windows;

class Scripture
{

    private List<string> _words = new List<string>();
    private Word _word = new Word();
    private string _content = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    private string _answer = "";
    private Random _rand = new Random();
    private int _index = 0;
    private int _counter = 0; 
    private int _changes = 0; 
    private string[] words = new string[] {};

    private List<int> _trackIndex = new List<int>();
    
  

    public Scripture(Reference reference)
    {
        do
        {
            
            Console.Write(reference.GetReference());
            ShowScripture();     
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            
            _answer = Console.ReadLine();
            if(_changes == _words.Count && _words.Count > 0){_answer="quit";}
            
            HideWords();
            
  


        } while (_answer != "quit");
    }

    private void HideWords()
    {
        _words.Clear();
        words = _content.Split(" ");
        foreach (string word in words){_words.Add(word);}
        _counter = 0;
        while(_counter < 3 && _changes < _words.Count)
        {
            _index = _rand.Next(_words.Count); 
            if(_words[_index].Contains("_"))
            {
                _index = _rand.Next(_words.Count);
            }
            else
            {
                _word = new Word(_words[_index]);
                _words[_index] = _word.GetWord();
                _counter++;
                _changes++;
            }
            //Console.Write(_changes);
        }

        _content = String.Join(" ", _words);
    }

    private void ShowScripture()
    {
        //Console.Clear();
        Console.WriteLine(_content);
    }



}