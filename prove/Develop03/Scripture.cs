using System;
using System.Windows;

class Scripture
{

    private List<string> _words = new List<string>();
    private Word _word = new Word();
    private string _content = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    private string answer = "";
    private Random rand = new Random();
    private string[] words = new string[] {};
    private List<int> _trackIndex = new List<int>();
  

    public Scripture(Reference reference)
    {
        do
        {
            Console.Write(reference.GetReference());
            ShowScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();
            HideWords();


        } while (answer != "quit");
    }

    private void HideWords()
    {
        _words.Clear();
        words = _content.Split(" ");
        foreach (string word in words){_words.Add(word);}

        for (int i = 0; i < 3 ; i++)
        {
            int _index = rand.Next(_words.Count);
            if (!_trackIndex.Contains(_index))
            {
                _word = new Word(_words[_index]);
                _words[_index] = _word.GetWord();
                _trackIndex.Add(_index);
                Console.WriteLine(_trackIndex.Count);
                Console.WriteLine(_words.Count);
            } 
            else if (_trackIndex.Count < _words.Count-1) {i = i - 1;}
            
        } 

        _content = String.Join(" ", _words);
    }

    private void ShowScripture()
    {
        //Console.Clear();
        Console.WriteLine(_content);
    }



}