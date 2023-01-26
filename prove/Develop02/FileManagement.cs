using System;
using System.IO;


public class FileManagement
{
    public string _fileName = " ";
    public List<string> _listManagement = new List<string>();


    public FileManagement()
    {

    }

    public void SaveFile()
    {
        using (StreamWriter outputFile  = new StreamWriter(@_fileName))
        {
            foreach (var index in _listManagement)
            {
                outputFile.WriteLine(index);
            }
        }   
    }

    public void LoadFile()
    {
        using (StreamReader inputFile = new StreamReader(@_fileName))
        {
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                _listManagement.Add(line);
            }
        }
    }
}

