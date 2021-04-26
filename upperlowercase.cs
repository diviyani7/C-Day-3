using System.IO;
using System;  
  
class Program  
{  
    public static void Main()  
    {  
        char result;  
        string name = "My name is Diviyani";  
        char[] charArry = name.ToCharArray();  
        foreach (var data in charArry)  
        {  
            if (Char.IsLower(data))  
            {  
                result = Char.ToUpper(data);  
            }  
            else  
            {  
                result = Char.ToLower(data);  
            }  
  
            Console.Write(result);  
        }  
    }  
}