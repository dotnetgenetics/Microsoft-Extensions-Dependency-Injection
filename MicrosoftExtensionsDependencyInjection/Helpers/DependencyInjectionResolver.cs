using Microsoft.Extensions.DependencyInjection;

namespace MicrosoftExtensionsDependencyInjection.Helpers
{
   public class DependencyInjectionResolver
   {
      private ServiceProvider serviceProvider;

      public DependencyInjectionResolver()
      {
         serviceProvider = new ServiceCollection()
            .AddTransient<IEmployeeDataAccess, EmployeeDataAccess>()
            .AddTransient<IProductDataAccess, ProductDataAccess>()
            .BuildServiceProvider();
      }

      public IEmployeeDataAccess GetEmployeeRepository()
      {         
         return serviceProvider.GetService<IEmployeeDataAccess>();
      }

      public IProductDataAccess GetProductRepository()
      {
         return serviceProvider.GetService<IProductDataAccess>();
      }
   }
}
