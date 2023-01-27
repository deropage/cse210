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
                mainEntries._answersFromPrompt = mainFile._listManagement;
                mainEntries.mainPrompt._askedQuestions = new List<string>(mainFile._promptTrack); //Copy the asked questions from the file to the asked questions of the program.
                mainEntries.questionIndex = mainFile._promptTrack.Count; // Getting the number of questions asked to keep track on the regular flow of the code

            }
            else if (selection == 4)
            {
                Console.WriteLine("Please enter the name of your file with extension .txt");
                mainFile._fileName = Console.ReadLine();
                mainFile._listManagement = mainEntries._answersFromPrompt; //Copy the answers to the list that works with file management class
                mainFile.SaveFile();
            }


        } while (selection != 5); //if the user selects 5 the program ends
        

    }
}