namespace MicrosoftExtensionsDependencyInjection
{
   public interface IProductDataAccess
   {
      public void SaveProduct(Product product);
      public string ShowProduct();
   }
}
