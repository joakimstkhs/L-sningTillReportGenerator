namespace ReportGenerator
{
    using ReportGenerator.Services;
    using System;

    public class Program
    {
        public static void Main()
        {
            var factoryProvider = new ReportFactoryProvider();
            var reportGenerator = new ReportGeneratorService(factoryProvider);

            
            var pdfReport = reportGenerator.CreateReport("pdf");
            pdfReport.Generate();

            var powerpointReport = reportGenerator.CreateReport("powerpoint");
            powerpointReport.Generate();

            try
            {
                var invalidReport = reportGenerator.CreateReport("invalid");
                invalidReport.Generate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
          
            }

        }
    }
}