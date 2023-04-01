using System;
using System.IO;


public class FileManagement
{
    private string _fileName;
    private string line;
    private List<string> _loadList = new List<string>();
    public FileManagement()
    {

    }
    public void SetFileName(string name)
    {
        _fileName = name;
    }

    public List<string> GetLoaded()
    {
        return _loadList;
    }

    public void SaveFile(List<string> stringList)
    {
        using (StreamWriter outputFile  = new StreamWriter(@_fileName))
        {
            foreach (var index in stringList)
            {
                outputFile.WriteLine(index);                            // Save the File in the given File Namess
            }
        }   
    }

    public void LoadFile(string fileName)
    {
        _fileName = fileName;
        using (StreamReader inputFile = new StreamReader(@_fileName))
        {
            while ((line = inputFile.ReadLine()) != null)
            {             
                _loadList.Add(line);                          //Adding to a temporary list all the lines of the file
            }
        }
    } 
}

