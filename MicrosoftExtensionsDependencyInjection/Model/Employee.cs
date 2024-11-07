using System;

namespace MicrosoftExtensionsDependencyInjection
{
   [Serializable]
   public class Employee
   {
      public int EmployeeID { get; set; }
      public string EmployeeName { get; set; }
      public double EmployeeSalary { get; set; }

      public Employee()
      {
         EmployeeID = 0;
         EmployeeName = string.Empty;
         EmployeeSalary = 0;
      }
   }
}
