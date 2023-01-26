using System;

public class Journal
{

    public Journal()
    {

    }
    public void MainMenu()
    {
        FileManagement mainFile = new FileManagement();
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
            else if (selection == 3)
            {
                Console.WriteLine("Please enter the name of your file with extension .txt");
                mainFile._fileName = Console.ReadLine();
                mainFile.LoadFile();
                mainEntries._answersFromPrompt = mainFile._listManagement ;
            }
            else if (selection == 4)
            {
                Console.WriteLine("Please enter the name of your file with extension .txt");
                mainFile._fileName = Console.ReadLine();
                mainFile._listManagement = mainEntries._answersFromPrompt;
                mainFile.SaveFile();
            }


        } while (selection != 5);
        

    }
}