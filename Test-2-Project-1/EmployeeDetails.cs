namespace Test_2_Project_1
{
    public class Employee
    {
        public Employee() { }
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public double Salary { get; set; }
        public int MyProperty { get; set; }
        public void AddNewEmployee()
        {
            Console.WriteLine("Employee Id: ");
            this.EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Employee Name: ");
            this.EmployeeName = Console.ReadLine();
            Console.WriteLine("Employee Salary: ");
            this.Salary = int.Parse(Console.ReadLine());
        }
        public void ShowEmployee()
        {
            Console.WriteLine("Employee ID: {0}\nEmployee Name: {1}\nSalary: {2}", this.EmployeeId, this.EmployeeName, this.Salary);
            Console.WriteLine("=========================================");
        }
    }
}
