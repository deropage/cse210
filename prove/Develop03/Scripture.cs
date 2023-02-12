using System;
using System.Windows;

class Scripture
{

    private List<string> _words = new List<string>();
    private Word _word = new Word();
    private string _content = "";
    private string _answer = "";
    private Random _rand = new Random();
    private int _index = 0;
    private int _counter = 0; 
    private int _changes = 0; 
    private string _answerHide = "";
    private int _answerHideNumber = 0;
    private string[] words = new string[] {};

    private List<int> _trackIndex = new List<int>();
    
  

    public Scripture(Reference reference, string scripture)
    {
        _content = scripture;
        Console.WriteLine("How many words do you want to hide every press of enter from 1-3");
        _answerHide = Console.ReadLine();
        _answerHideNumber = int.Parse(_answerHide);
        do
        {

            ShowScripture(reference);                                                             // Print Scripture
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");      // Ask user for input   
            _answer = Console.ReadLine();                                                // Receive the answer
            if(_changes == _words.Count && _words.Count > 0){_answer="quit";}            // check if the changes in list are completed
            HideWords();                                                                 // if there are words to change or the answer is not enter hide words

        } while (_answer != "quit");                                                     // Program will run while the answer is not quit
    }

    private void HideWords()                                                             //Hide Words method
    {
        _words.Clear();                                                                  //Clear the list for each pass
        words = _content.Split(" ");                                                     //Split scripture by words using the space as separator
        foreach (string word in words){_words.Add(word);}                                //Load the elements of the array into a list
        _counter = 0;                                                                    // Reset the counter of changes per enter
        while(_counter < _answerHideNumber && _changes < _words.Count)                                   // Will change 3 words each time of if there are less than 3 words will check for the changes done.
        {
            _index = _rand.Next(_words.Count);                                           //Get new random number for index
            if(_words[_index].Contains("_"))                                             // if the index of the list contains "_" will search for a new one
            {
                _index = _rand.Next(_words.Count);
            }
            else
            {
                _word = new Word(_words[_index]);                                       //if the index do not have "_" will add the string to Word type variable
                _words[_index] = _word.GetWord();                                       // Getting the word transformated
                _counter++;                                                             // updating the times that have changed each time
                _changes++;                                                             //Updating total changes
            }
        }
        _content = String.Join(" ", _words);                                            //Creating new string with changed words.
    }

    private void ShowScripture(Reference reference)                                                        //method to show scripture
    { 
        Console.Clear();                                                              //Clear console
        Console.Write(reference.GetReference());                                                                
        Console.WriteLine(" " + _content);                                                    //Print Scripture
    }



}