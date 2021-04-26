using System.IO;
using System;

namespace Day_3
{
    //Readonly and cost keyword
    class Class5
    {
        public static void Main()
        {
        string a = "It is a bad color";
        Console.WriteLine("string: " +a);
        string b= "is a";
        Console.WriteLine("string: " +b);
        if(a.Contains(b))
        {
            Console.WriteLine("b is a substring of a");
        }
	else
	{
	    Console.WriteLine("b is not a substring of a");
	}
            Console.ReadLine();
        }
    }
}
