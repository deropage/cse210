using System;
using System.IO;


public class FileManagement
{
    private string _fileName;
    private List<string> _goals = new List<string>();
    public FileManagement()
    {

    }
    public void SetGoals(string goal)
    {
        _goals.Add(goal);
    }
    public void SetFileName(string name)
    {
        _fileName = name;
    }
    public void ClearList()
    {
        _goals.Clear();
    }

    public void SaveFile()
    {
        using (StreamWriter outputFile  = new StreamWriter(@_fileName))
        {
            foreach (var index in _goals)
            {
                outputFile.WriteLine(index);                            // Save the File in the given File Namess
            }
        }   
    }

    
}

