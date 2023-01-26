using System;

public class Journal
{

    public Journal()
    {

    }
    public void MainMenu()
    {
        int selection = 0;
        Entry mainEntries = new Entry();
        do
        {
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            string input = Console.ReadLine();
            selection = int.Parse(input);
            if (selection == 1)
            {
                mainEntries.NewEntry();
            }
            else if(selection == 2)
            {
                foreach (string entry in mainEntries._answersFromPrompt)
                {
                    Console.WriteLine(entry);
                }
            }


        } while (selection != 5);
        

    }
}