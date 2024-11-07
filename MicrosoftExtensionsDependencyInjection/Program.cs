using System;

namespace MicrosoftExtensionsDependencyInjection
{
    public class Program
    {
        static void Main(string[] args)
        {
            ManageInformationService manageInformationService;

            manageInformationService = new ManageInformationService();

            manageInformationService.ManageEmployee();
            manageInformationService.ManageProduct();

            Console.ReadLine();
        }
    }
}
