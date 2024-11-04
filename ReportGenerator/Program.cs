namespace ReportGenerator
{
    using System;
    using ReportGenerator.Services;

    public static class Program
    {
        public static void Main()
        {
            var factoryProvider = new ReportFactoryProvider();
            var reportGenerator = new ReportCreateService(factoryProvider);

            try
            {
                
                reportGenerator.CreateReport("pdf");
                reportGenerator.CreateReport("excel");
                reportGenerator.CreateReport("word");
                reportGenerator.CreateReport("powerpoint");

                
                reportGenerator.CreateReport("invalid");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            
            Console.WriteLine("\nAvailable report types:");
            foreach (var type in reportGenerator.GetAvailableReportTypes())
            {
                Console.WriteLine($"- {type}");
            }
        }
    }
}