using System;

namespace MicrosoftExtensionsDependencyInjection
{
   [Serializable]
   public class Product
   {
      public int ProductCode { get; set; }
      public string ProductName { get; set; }
      public double ProductPrice { get; set; }

      public Product()
      {
         ProductCode = 0;
         ProductName = string.Empty;
         ProductPrice = 0;
      }
   }
}
