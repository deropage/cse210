using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureManagement _list = new ScriptureManagement();
        Reference reference = new Reference(_list.GetSelecterReference());
        Scripture scripture = new Scripture(reference, _list.GetSelecterScripture());

    }

}
// The program can change 3 by 3 words and only change those words that have not changed yet.
// The program loads the scriptures from a file.
// The program will load any new scripture added to the File, while each scripture have "; "after the reference
// The program will give option to choose from loaded scriptures to the user
// The program will prompt the user for the numbers of words to hide every enter