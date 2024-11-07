namespace MicrosoftExtensionsDependencyInjection
{
   public interface IEmployeeDataAccess
   {
      public void SaveEmployee(Employee employee);
      public string ShowEmployee();
   }
}
