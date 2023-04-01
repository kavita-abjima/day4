
using System;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp3;

class Programm
{
    static void Main(string[] args)
    {
        //conversion of strings
        string name = "Hello My name is Kavita";
        string lower = name.ToLower();
        Console.WriteLine(lower);

        string replace = name.Replace("K", "N");
        Console.WriteLine(replace);
        //string concanate
        string name2 = "Anurag";
        string lastname = "Jangir";
        string id = string.Concat(name2, lastname);
        Console.WriteLine(id);
        int age = 30;

        Console.WriteLine("My name is " + name2 + " My age is " + age);
        //string interpolation
        Console.WriteLine($"My name is {name2} and i am {age} year old");
        int length = id.Length;
        Console.WriteLine(length);
        string Substring = id.Substring(1, 4);
        Console.WriteLine(Substring);

        //Escape chr
        string displayName = $"Welcome! \n{name2}\t{lastname}";
        Console.WriteLine(displayName);
        string invalidFilepath = "C:\\data\\employeelist.xlst";
        Console.WriteLine(invalidFilepath);

        string markettagline = "Backing the\"best pies\"ever";
        Console.WriteLine(markettagline);


        //stringBuilder
        StringBuilder sb = new StringBuilder("Hii This is kavita");
        sb=sb.Replace("Soniya", "Kavita");
        string dummy = sb.ToString();
        Console.WriteLine(dummy);

        //String pasrsing
        Console.WriteLine("Enter the String");
        string w = Console.ReadLine();
        int wb = int.Parse(w);
        Console.WriteLine(wb);

        //tryparse
        int value;
        if (int.TryParse(w, out value))
            Console.WriteLine("parsing successful :" + value);
        else
            Console.WriteLine("parsing failed");

        //Methods
        
                 

        

    }
 
}

