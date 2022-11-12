namespace Test_2_Project_1
{
    internal class ListOperations
    {
        public void AddEmployee(List<Employee> employees)
        {
            Employee objEmployee = new Employee();
            Console.WriteLine("How Many Employees,Do you want Add? ");
            int employeesCount = int.Parse(Console.ReadLine());
            for (int loopVariable = 1; loopVariable <= employeesCount; loopVariable++)
            {
                objEmployee = new Employee();
                objEmployee.AddNewEmployee();
                employees.Add(objEmployee);
            }
            Console.WriteLine("Employee Details Added");
        }
        public void RemoveEmployee(List<Employee> employees)
        {
            Console.WriteLine("No.of records exists in List is :" + employees.Count());
            Console.WriteLine("Mention Employee ID to remove his/her Details");
            int employeeId = int.Parse(Console.ReadLine());
            if (employees.Count() > 0)
            {
                foreach (Employee employee in employees)
                {
                    if (employeeId == employee.EmployeeId)
                    {
                        employees.Remove(employee);
                        Console.WriteLine("One Employee Details Removed");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No records found........");
            }
        }
        public void InsertEmployee(List<Employee> employees)
        {
            Employee objEmployee;
            Console.WriteLine("No.of records exists in List is :" + employees.Count());
            Console.WriteLine("Enter the index of new record where you want to insert?,index like 0,1,2,,.....");
            int Index = int.Parse(Console.ReadLine());
            objEmployee = new Employee();
            objEmployee.AddNewEmployee();
            employees.Insert(Index, objEmployee);
        }
        public void RemoveAtEmployee(List<Employee> employees)
        {
            Employee objEmployee;
            Console.WriteLine("The employees are:" + employees.Count());
            Console.WriteLine("\nThe Employee Records are: ");
            if (employees.Count() > 0)
            {
                foreach (Employee employee in employees)
                {
                    employee.ShowEmployee();
                }
                Console.WriteLine("Do you want to Remove any employee?, Please specify Index to search");
                int index = int.Parse(Console.ReadLine());
                foreach (Employee employee in employees)
                {
                    employees.RemoveAt(index);
                    break;
                }
            }
            else
            {
                Console.WriteLine("No records Found");
            }
        }
        public void CountEmployee(List<Employee> employees)
        {
            Console.WriteLine("The Employee Records are: " + employees.Count());
        }
        public void SearchEmployee(List<Employee> employees)
        {
            Console.WriteLine("No. of Employees" + employees.Count);
            Console.WriteLine("Do you want to search for a Employee?>, Specify Employee ID to Search");
            int EmployeeId = int.Parse(Console.ReadLine());
            Employee objEmployee = new Employee();
            foreach (Employee employee in employees)
            {
                if (EmployeeId == employee.EmployeeId)
                {
                    employee.ShowEmployee();
                    break;
                }
            }
            if (objEmployee != null)
            {
                Console.Write(" ");
            }
            else
            {
                Console.WriteLine("No Records Found");
            }
        }
        public void DisplayEmployee(List<Employee> employees)
        {
            if (employees.Count() == 0)
            {
                Console.WriteLine("No Records are Found.....");
            }
            else
            {
                foreach (Employee employee in employees)
                {
                    employee.ShowEmployee();
                }
            }
        }
        public void ClearList(List<Employee> employees)
        {
            if (employees.Count() == 0)
            {
                Console.WriteLine("List is Empty Already.......");
            }
            else
            {
                employees.Clear();
                Console.WriteLine("List is Cleared......");
            }
        }
    }
}
