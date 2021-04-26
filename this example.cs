using System.IO;
using System;

    class Class1
    {
        public int a; 
        Class1(int a)
        {
           this.a = a;
        }
        public static void Main()
        {
            Class1 class1= new Class1(1);
            Console.WriteLine(class1.a);
            Console.ReadLine();
        }
    }
