namespace MicrosoftExtensionsDependencyInjection
{
   public class ProductDataAccess : IProductDataAccess
   {
      public Product Product { get; set; }

      public ProductDataAccess()
      {
         Product = new Product();
      }

      public void SaveProduct(Product product)
      {
         /* In real-world, this can be a method to save the object to database */
         this.Product = product;
      }

      public string ShowProduct()
      {
         /* In real-world, this can be a method to get an employee object from the database */
         return $"Code - {Product.ProductCode}, Name - {Product.ProductName}, Price - {Product.ProductPrice}";
      }
   }
}
