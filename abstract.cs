using System.IO;
using System;

abstract class Employee //abstarct
{
  public int EmployeeID { get; set;}
  public string EmployeeName { get; set;}
  public Employee(int _employeeID, string _employeeName)
  {
      EmployeeID = _employeeID;
      EmployeeName = _employeeName;
  }
}
   class Class5:Employee // concrete class
   {
       Class5(int _employeeID, string _employeeName)
       public void PrintData()
       {
        Console.WriteLine("EmployeeID:" +EmployeeID );
        Console.WriteLine("EmployeeName:" +EmployeeName );
       }
       public static void Main()
       {
           Class5 e = new Class5(99,"Diviyani");
           Console.WriteLine();
           e.PrintData();
           Console.ReadLine();
       }
   }