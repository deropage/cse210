using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int tempNumberInt;
        int listSum=0;
        float listAvg=0;
        int listMax=0;
        int listMinPositive = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do 
        {
            Console.Write("Enter number: ");
            string tempNumber = Console.ReadLine();
            tempNumberInt = int.Parse(tempNumber);
            if (tempNumberInt != 0)
            {
                numbers.Add(int.Parse(tempNumber));
            }
            
        }while (tempNumberInt != 0);

        listMinPositive = numbers[0];

        foreach (int number in numbers)
        {
            listSum = listSum + number;
            if (number > listMax)
            {
                listMax = number;
            }      
            if (number > 0 && number < listMinPositive)
            {
                listMinPositive = number;
            }
        }
        numbers.Sort();

        listAvg = (float)listSum / (float)numbers.Count;
        Console.WriteLine($"The Sum is: {listSum}");
        Console.WriteLine($"The Average is: {listAvg}");
        Console.WriteLine($"The largest number is: {listMax}");
        Console.WriteLine($"The smallest positive number is: {listMinPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        
    }
}