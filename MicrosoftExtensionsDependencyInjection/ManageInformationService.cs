using MicrosoftExtensionsDependencyInjection.Helpers;
using System;

namespace MicrosoftExtensionsDependencyInjection
{
   public class ManageInformationService
   {
      private static DependencyInjectionResolver resolver;

      public ManageInformationService()
      {
         resolver = new DependencyInjectionResolver();
      }

      public void ManageEmployee()
      {
         Employee employee;
         IEmployeeDataAccess empAccess;

         employee = new Employee();
         empAccess = resolver.GetEmployeeRepository();

         employee.EmployeeID = 10001;
         employee.EmployeeName = "Greg Esguerra";
         employee.EmployeeSalary = 500.00;

         empAccess.SaveEmployee(employee);
         Console.WriteLine("Employee Information");
         Console.WriteLine(empAccess.ShowEmployee());
      }

      public void ManageProduct()
      {
         Product product;
         IProductDataAccess prodAccess;

         product = new Product();
         prodAccess = resolver.GetProductRepository();

         product.ProductCode = 2550;
         product.ProductName = "Pringles Potato Chips";
         product.ProductPrice = 500.00;

         prodAccess.SaveProduct(product);
         Console.WriteLine("\n\nProduct Information");
         Console.WriteLine(prodAccess.ShowProduct());
      }
   }
}
