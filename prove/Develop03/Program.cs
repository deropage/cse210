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