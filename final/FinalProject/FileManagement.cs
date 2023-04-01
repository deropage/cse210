using System;
using System.IO;


public class FileManagement
{
    //Main variables to manage files
    private string _fileName;
    private string line;
    private List<string> _loadList = new List<string>();
    public FileManagement(){} //Main constructor
    public void SetFileName(string name){_fileName = name;} //Method to get the file name

    public List<string> GetLoaded(){return _loadList;} //Getting the list where all the data from a new file is stored

    public void SaveFile(List<string> stringList) //saving to a new file all the data in a given list
    {
        using (StreamWriter outputFile  = new StreamWriter(@_fileName))
        {
            foreach (var index in stringList)
            {
                outputFile.WriteLine(index);                            
            }
        }   
    }

    public void LoadFile(string fileName) // Loading data to a new list
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

