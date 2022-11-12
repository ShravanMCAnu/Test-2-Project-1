// See https://aka.ms/new-console-template for more information
using System.Data;
using Test_2_Project_1;
ListOperations objOperations = new ListOperations();
try
{
    List<Employee> employees = new List<Employee>();
    Employee objEmployee;
    int choice = -1;
    do
    {
        Console.WriteLine("\nHello Welcome to CSharp Programming\n\nTo Perform List Operations ......\n\t 1.Add\n\t 2.Remove\n\t 3.Insert\n\t 4.RemoveAt\n\t 5.Show All Records\n\t 6.Search Employee\n\t 7.Record Count\n\t 8.Clear Console\n\t 9.Clear The List\n\t 10.Stop The Program\n  Choose Your Option....");
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                objOperations.AddEmployee(employees);
                break;
            case 2:
                objOperations.RemoveEmployee(employees);
                break;
            case 3:
                objOperations.InsertEmployee(employees);
                break;
            case 4:
                objOperations.RemoveAtEmployee(employees);
                break;
            case 5:
                objOperations.DisplayEmployee(employees);
                break;
            case 6:
                 objOperations.SearchEmployee(employees);
                break;
            case 7:
                objOperations.CountEmployee(employees);
                break;
            case 8:
                Console.Clear();
                break;
            case 9:
                objOperations.ClearList(employees);
                break;
        }
    }
    while (choice < 9);
    Console.WriteLine("Program Closed..........Press Enter Again for Exit The Console");
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}
