namespace ReportGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var reportGenerator = new ReportGenerator();
            
            var pdfReport = reportGenerator.CreateReport("PDF");
            pdfReport.Generate();

            var excelReport = reportGenerator.CreateReport("Excel");
            excelReport.Generate();

            var wordReport = reportGenerator.CreateReport("Word");
            wordReport.Generate();

            try
            {
                var invalidReport = reportGenerator.CreateReport("InvalidType");
                invalidReport.Generate();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
