using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        Scripture scripture = new Scripture(reference);

    }

}
// The program can change 3 by 3 words and only change those words that have not changed yet.