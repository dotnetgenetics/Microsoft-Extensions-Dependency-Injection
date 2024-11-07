namespace MicrosoftExtensionsDependencyInjection
{
   public class EmployeeDataAccess : IEmployeeDataAccess
   {
      public Employee Employee { get; set; }

      public EmployeeDataAccess()
      {
         Employee = new Employee();
      }

      public void SaveEmployee(Employee employee)
      {
         /* In real-world, this can be a method to save the object to database */
         this.Employee = employee;
      }

      public string ShowEmployee()
      {
         /* In real-world, this can be a method to get an employee object from the database */
         return $"ID - {Employee.EmployeeID}, Name - {Employee.EmployeeName}, Salary - {Employee.EmployeeSalary}";
      }
   }
}
